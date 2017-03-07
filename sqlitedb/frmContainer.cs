using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmContainer : MetroForm
    {
        SQLiteConnection m_dbConnection = null;
        Dictionary<int, double> mydict = new Dictionary<int, double>();
        private frmLogin frml;
        private string useremail = null;
        private string username = null;
        private string acountType = null;
        private int userId = -1;
        private string levstatus = null;
        private string leaveFrom = null;
        private string leaveTo = null;
        private int leaveId = -1;
        private string leaveReason = null;
        private string adminCommment = null;
        private string adminName = null;
        private string approvedTime = null;
        private int adminID = -1;
        private StringBuilder NotificationStatus = new StringBuilder();
        private frmProfile frmProfile;
        private frmApplicationFrom frmApplicationFrom;
        private frmAdminLeaveApproved frmAdminLeaveApproved;
        private long ticks;
        public frmContainer()
        {
            InitializeComponent();

        }

        public frmContainer(frmLogin l)
        {
            this.frml = l;
        }

        public frmContainer(frmProfile frmProfile)
        {
            this.frmProfile = frmProfile;
        }

        public frmContainer(frmApplicationFrom frmApplicationFrom)
        {
            this.frmApplicationFrom = frmApplicationFrom;
        }

        public frmContainer(frmAdminLeaveApproved frmAdminLeaveApproved)
        {
            this.frmAdminLeaveApproved = frmAdminLeaveApproved;
        }

        ///

        public string getsetUserName
        {
            set { username = value; }
            get
            {
                return this.username;
            }

        }
        public string getsetUserEmail
        {
            get { return useremail; }
            set { useremail = value; }
        }

        public string getsetAcountType
        {
            get { return acountType; }
            set { acountType = value; }
        }
        public int getsetUserId
        {
            get { return userId; }
            set { userId = value; }
        }


        ///

        public void loadDb()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            m_dbConnection = new SQLiteConnection(@"Data Source=" + path + "\\database\\LeaveDB.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        

      

        
        
       

        private void frmContainer_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Login: " + getsetUserName+" ("+getsetAcountType+")";
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime local = zone.ToLocalTime(DateTime.Now);
            lbldatetime.Text ="Login Time: " + local.ToString();
            if (getsetAcountType != "Admin")
            {
                mnuadmin.Enabled = false;
            }
            loadDb();
            getLeaveId();
            loadApplyLeaveInfo();
            
        }

        private void frmContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to really exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void mnuItemProfile_Click(object sender, EventArgs e)
        {
            frmProfile fProfile = new frmProfile();
            fProfile.SetGetUserID = this.getsetUserId;
            fProfile.Show();
        }

        private void mnuItemLogout_Click(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
            this.Hide();
        }

        private void mnuItemLeave_Click(object sender, EventArgs e)
        {
            frmApplicationFrom fApplication = new frmApplicationFrom();
            fApplication.SetGetUserID= this.getsetUserId;
            fApplication.Show();
           fApplication.TopMost = true;
        }

        private void mnuItemleaveApplication_Click(object sender, EventArgs e)
        {

            frmAdminLeaveApproved fAdminLeaveApproved = new frmAdminLeaveApproved();
            fAdminLeaveApproved.setGetApproved_UserId= this.getsetUserId;
            fAdminLeaveApproved.Show();
            fAdminLeaveApproved.TopMost = true;
            
        }

        private void lblCloseNotification_Click(object sender, EventArgs e)
        {
            tm2.Enabled = true;
            panelNotificationbar.Visible = false;
            panelPopUp.Visible = false;
            LInklblDetail.Text = "show details";
            NotificationStatus.Clear();
            lblNotificationStatus.Text = "";
        }

        private void mnuItemleaveStatus_Click(object sender, EventArgs e)
        {
            getLeaveId();
            loadApplyLeaveInfo();
            getAdminName();
            NotificationStatus.Clear();
            NotificationStatus.Append("You may applied a Leave From " + leaveFrom);
            NotificationStatus.Append(" To " + leaveTo);
            NotificationStatus.Append(" is " + levstatus + ".");
            lblNotificationStatus.Text = NotificationStatus.ToString();

            /////PopUp panel 
            txtLeaveId.Text = leaveId.ToString();
            txtLeaveStatus.Text = levstatus;
            txtLeaveFrom.Text = leaveFrom;
            txtLeaveTo.Text = leaveTo;
            txtReason.Text = leaveReason;
            txtComment.Text = adminCommment;
            txtApprovedDate.Text = approvedTime;
            txtApprovedBy.Text = adminName;



            /////
            if (levstatus == "Pending")
            {
                panelNotificationbar.Visible = true;
                lblCloseNotification.ForeColor = System.Drawing.Color.Yellow;
                lblNotificationStatus.ForeColor= System.Drawing.Color.Orange;
            }
            else if (levstatus == "Accepted")
            {
                panelNotificationbar.BackColor = System.Drawing.Color.Green;
                lblNotificationStatus.ForeColor = System.Drawing.Color.White;
                panelNotificationbar.Visible = true;

            }
            else if (levstatus == "Rejected")
            {
                panelNotificationbar.BackColor = System.Drawing.Color.Red;
                lblNotificationStatus.ForeColor = System.Drawing.Color.Yellow;
                lblCloseNotification.ForeColor = System.Drawing.Color.White;
                panelNotificationbar.Visible = true;
               

            }


        }

        private void lblCloseNotification_MouseMove(object sender, MouseEventArgs e)
        {
            lblCloseNotification.ForeColor = System.Drawing.Color.Red; 
        }

        private void panelNotificationbar_MouseMove(object sender, MouseEventArgs e)
        {
            lblCloseNotification.ForeColor = System.Drawing.Color.Black;
           LInklblDetail.LinkColor = System.Drawing.Color.Blue;

        }

        public void loadApplyLeaveInfo()
        {
            
            string sql = "select * from tblLeave WHERE LeaveID='" + leaveId + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                leaveFrom=reader["LeaveDateFrom"].ToString();
                leaveTo=reader["LeaveDateTo"].ToString();
                levstatus= reader["LeaveStatus"].ToString();
                leaveReason= reader["LeaveReason"].ToString();
                adminCommment = reader["AdminComment"].ToString();
                approvedTime= reader["ApprovedDateTime"].ToString();
                adminID= int.Parse(reader["ApprovedBY"].ToString());
            }
            
        }

        public void getLeaveId()
            {
            mydict.Clear();
            string sql = "select * from tblLeave WHERE UserID='" + getsetUserId + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            //Console.WriteLine("===================================");
            while (reader.Read())
            {
                //LevaeID = int.Parse(reader["LeaveID"].ToString());
                //approvedTime = reader["ApprovedTime"].ToString();
                if (reader["ApprovedDateTime"].ToString() != "null")
                {
                    double dApprovedTime = double.Parse(reader["ApprovedTime"].ToString());
                    double dCurrentTime = GetElapsedTime();
                    double dTotalTime = dCurrentTime - dApprovedTime;
                    //Console.WriteLine("totaltime " + dTotalTime);
                    mydict.Add(int.Parse(reader["LeaveID"].ToString()), dTotalTime);
                 
                     
                }
               
            }
           // Console.WriteLine("===================================");
            /////get last Approved Id
            var items = from pair in mydict
                        orderby pair.Value descending
                        select pair;
            // Display results.
            foreach (KeyValuePair<int, double> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                leaveId = pair.Key;
            }


        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            int a = -1;
            var items = from pair in mydict
                        orderby pair.Value descending
                        select pair;
            // Display results.
            foreach (KeyValuePair<int, double> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                a = pair.Key;
            }
            MessageBox.Show("value " + a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void LInklblDetail_MouseClick(object sender, MouseEventArgs e)
        {

           
        }

        private void LInklblDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPopUp.BackColor = lblNotificationStatus.BackColor;
            panelPopUp.BringToFront();
            if (panelPopUp.Visible )
            {
                tm2.Enabled = true;
                LInklblDetail.Text = "show details";
               
            }
            else
            {
                tm.Enabled = true; 
                LInklblDetail.Text = "hide details";
            }
        }

        private void frmContainer_Resize(object sender, EventArgs e)
        {
            
        }

        private void LInklblDetail_MouseMove(object sender, MouseEventArgs e)
        {
            LInklblDetail.LinkColor = System.Drawing.Color.White;
        }

        public void getAdminName()
        {

            string sql = "select * from tblUser WHERE UserID='" + adminID + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                adminName = reader["UserName"].ToString();
               
            }
        }

        public void startTimer()
        {
            ticks = DateTime.Now.Ticks;
        }
        public double GetElapsedTime()
        {
            return (DateTime.Now.Ticks - ticks) / Math.Pow(10, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemabout_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.Show();
            fabout.TopMost = true;
           

        }

        private void tm_Tick(object sender, EventArgs e)
        {
            if (panelPopUp.Height >= 375)
            {
                
                this.tm.Enabled = false;
                

                
            }
            else {
               
                panelPopUp.Height += 10;
                panelPopUp.Visible = true;
            }
             

          
        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            if (panelPopUp.Height <= 5)
            {
                this.tm2.Enabled = false;
                panelPopUp.Visible = false;
                panelPopUp.Height = 5;


            }
            else
            {
              
                panelPopUp.Height -= 10;

            }
        }
    }
}
