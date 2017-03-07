using MetroFramework.Forms;
using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmApplicationFrom : MetroForm
    {
        SQLiteConnection m_dbConnection;
        private int userId = -1;
        public frmApplicationFrom()
        {
            InitializeComponent();
            frmContainer fContainer = new frmContainer(this);
            dateTimePickerTo.Value = DateTime.Now.Date;
            dateTimePickerFrom.Value = DateTime.Now.Date;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime dayFrom = DateTime.Parse(dateTimePickerFrom.Text);
            DateTime dayTo = DateTime.Parse(dateTimePickerTo.Text);
            TimeSpan totaldays = dayTo.Subtract(dayFrom);
            if (totaldays.Days > 0)
            {
                if (txtReason.Text.ToString() != "" && lblTotaldays.Text.ToString() != "")
                {
                    SubmitLeaveApplication();
                    m_dbConnection.Close();
                    MessageBox.Show("Successfully Submitted Leave Application", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    //MetroMessageBox.Show(fcreate, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Please filled up all the field correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Please select date correctly\nLeave date and Application date can't be same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           



        }



        private void dateTimePickerTo_MouseLeave(object sender, EventArgs e)
        {
            DateTime dayFrom = DateTime.Parse(dateTimePickerFrom.Text);
            DateTime dayTo = DateTime.Parse(dateTimePickerTo.Text);
            TimeSpan totaldays = dayTo.Subtract(dayFrom);
            if (totaldays.Days > 0)
            {
                lblTotaldays.Text = "Total Days: " + totaldays.Days;
            }
            else
            {
                lblTotaldays.Text = " ";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dateTimePickerTo.Value = DateTime.Now.Date;
            dateTimePickerFrom.Value = DateTime.Now.Date;
            txtReason.Text = " ";
            lblTotaldays.Text = "";
            
        }

        private void frmApplicationFrom_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            m_dbConnection =
                new SQLiteConnection(@"Data Source=" + path + "\\database\\LeaveDB.sqlite;Version=3;");
            m_dbConnection.Open();
            //MessageBox.Show("Userid: "+ SetGetUserID);
        }


        public int SetGetUserID
        {
            get { return userId; }
            set { this.userId = value; }


        }

        private void SubmitLeaveApplication()
        {
            string strRes = txtReason.Text.Replace("'", "''");
            //string strRes= Regex.Replace(txtReason.Text, @"[\r\n\x00\x1a\\'""]", @"\$0");
            string sql = "insert into tblLeave (UserID, ApprovedBY,LeaveReason,LeaveDateFrom,LeaveDateTo,LeaveStatus,ApprovedTime,ApprovedDateTime,AdminComment) values ('" + userId+ "', 'null','" + strRes + "','" + dateTimePickerFrom.Text + "','" + dateTimePickerTo.Text + "','Pending','null','null','null')";
           // string sql = "insert into tblLeave(UserID, ApprovedBY, LeaveReason, LeaveDateFrom, LeaveDateTo, LeaveStatus, ApprovedTime, AdminComment) values('" + userId + "', 'null', 'test', '111-22-5', '22-22-22', 'Pending', 'notSet', 'No Comment yet')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }
    }
}
