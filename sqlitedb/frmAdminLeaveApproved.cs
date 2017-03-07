using MetroFramework.Forms;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmAdminLeaveApproved : MetroForm
    {
        SQLiteConnection m_dbConnection = null;
        private string useremail = null;
        private string password = null;
        private string username = null;
        private string acountType = null;
        private int userId = -1;
        private int levaeId = -1;
        private string strlevaveFrom = null;
        private string strleaveTo = null;
        private string strReason = null;
        private int approved_UserId = -1;
        private  long ticks;
        public frmAdminLeaveApproved()
        {
            InitializeComponent();
            frmContainer fContainer = new frmContainer(this);
            dbConnector();
            loadRequest();
        }
        public void dbConnector()
        {

            string path = AppDomain.CurrentDomain.BaseDirectory;
            m_dbConnection = new SQLiteConnection(@"Data Source=" + path + "\\database\\LeaveDB.sqlite;Version=3;");
            m_dbConnection.Open();
        }
        public void loadRequest()
        {
            listView1.Items.Clear();
            string sql = "select * from tblLeave WHERE LeaveStatus='Pending'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //listView1.Items.Add(reader["LeaveID"] + "\t" + reader["UserID"]);
                add(reader["LeaveID"].ToString(), reader["LeaveReason"].ToString(), reader["LeaveDateFrom"].ToString(), reader["LeaveDateTo"].ToString());

            }
        }

        private void frmAdminLeaveApproved_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_dbConnection.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            
            if (listView1.Items.Count > 0 )
            {
                loadSelectedLeaveInfo();
                loadLeavetUserInfo();
                DateTime dayFrom = DateTime.Parse(lblFrom.Text);
                DateTime dayTo = DateTime.Parse(lblTo.Text);
                TimeSpan totaldays = dayTo.Subtract(dayFrom);
                if (totaldays.Days > 1)
                    lblTotal.Text = "Total " + totaldays.Days + " days";
                else {
                    lblTotal.Text = "Total " + totaldays.Days + " day";
                }
            }
            

        }

        private void add(string LeaveID, string LeaveReason, string LeaveDateFrom, string LeaveDateTo)
        {
            string[] row = { LeaveID, LeaveReason, LeaveDateFrom, LeaveDateTo };
            ListViewItem listviewitem = new ListViewItem(row);
            listView1.Items.Add(listviewitem);

        }

        private void frmAdminLeaveApproved_Load(object sender, EventArgs e)
        {
           listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add(" ID ",80);
            listView1.Columns.Add("Reason", 150);
            listView1.Columns.Add(" From ", 150);
            listView1.Columns.Add(" To ", 150);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Acquire SelectedItems reference.
            var selectedItems = listView1.SelectedItems;
            if (selectedItems.Count > 0)
            {
                // Display text of first item selected.
                levaeId = int.Parse(selectedItems[0].Text);
            }
            else
            {
                // Display default string.
               // this.txtReason.Text = "Empty";
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
           // txtReason.Text="You clicked " + listView1.SelectedItems[0].Text;
           // loadSelectedLeaveInfo();
           // loadLeavetUserInfo();
        }

        public void loadLeavetUserInfo()
        {
            string sql = "select * from tblUser WHERE UserID='" + userId + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblUsername.Text = reader["UserName"].ToString();
                lblEmail.Text = reader["UserEmail"].ToString();
                lblRank.Text = reader["AccountType"].ToString();
                lblRank2.Text = reader["AccountType"].ToString();

            }
        }
        public void loadSelectedLeaveInfo()
        {
            string sql = "select * from tblLeave WHERE LeaveID='" + levaeId + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                userId = int.Parse(reader["UserID"].ToString());
                txtReason.Text = reader["LeaveReason"].ToString();
                lblFrom.Text =reader["LeaveDateFrom"].ToString();
                lblTo.Text =reader["LeaveDateTo"].ToString();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtComment.Text = "";
        }

        public int setGetApproved_UserId
        {
            get { return approved_UserId; }
            set { this.approved_UserId = value; }


        }

        public string StrlevaveFrom
        {
            get
            {
                return strlevaveFrom;
            }

            set
            {
                strlevaveFrom = value;
            }
        }

        public string StrlevaveFrom1
        {
            get
            {
                return strlevaveFrom;
            }

            set
            {
                strlevaveFrom = value;
            }
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            Reject();


        }

        public void Approve()
        {
            
            if (MessageBox.Show("Are You Accepte this Leave?", "Accept?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                DateTime now = DateTime.Now;
               
                if (userId != -1)

                {
                    string strComment = txtComment.Text.Replace("'", "''");
                    string sql = "Update  tblLeave SET ApprovedBY='" + setGetApproved_UserId + "',LeaveStatus='Accepted',AdminComment='"+ strComment + "',ApprovedTime='" +GetElapsedTime() + "',ApprovedDateTime='"+ now.ToString("G") + "' WHERE LeaveID='" + levaeId + "'";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    txtComment.Text = "";
                    MessageBox.Show("Successful", "Accepted Leave!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadRequest();


                }
                else
                {
                    //MetroMessageBox.Show(fcreate, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Please select a request first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

        }


        public void Reject()
        {
            if (MessageBox.Show("Are You Reject this Leave?", "Reject?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                DateTime now = DateTime.Now;
                if (userId != -1)

                {
                    string strComment = txtComment.Text.Replace("'", "''");
                    string sql = "Update  tblLeave SET ApprovedBY='" + setGetApproved_UserId + "',LeaveStatus='Rejected',AdminComment='" + strComment + "',ApprovedTime='" + GetElapsedTime() + "',ApprovedDateTime='" + now.ToString("G") + "'WHERE LeaveID='" + levaeId + "'";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    txtComment.Text = "";
                    MessageBox.Show("Successful", "Rejected Leave!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadRequest();

                }
                else
                {
                    //MetroMessageBox.Show(fcreate, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Please select a request first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            Approve();
        }




        public  void startTimer()
        {
            ticks = DateTime.Now.Ticks;
        }
        public  double GetElapsedTime()
        {
            return (DateTime.Now.Ticks - ticks) / Math.Pow(10, 4);
        }
    }


}
