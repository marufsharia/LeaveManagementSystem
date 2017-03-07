using MetroFramework.Forms;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmLogin : MetroForm
    {
        SQLiteConnection m_dbConnection=null;
        public string useremail = null;
        private string password = null;
        private string username = null;
        private string acountType = null;
        private int userId = -1;
        private int count = 0;
        public frmLogin()
        {
            InitializeComponent();
            dbConnector();
        }
        public void dbConnector()
        {

            string path = AppDomain.CurrentDomain.BaseDirectory;
            m_dbConnection = new SQLiteConnection(@"Data Source=" + path + "\\database\\LeaveDB.sqlite;Version=3;");
            m_dbConnection.Open();
    }
        private void linkLabelCreakeAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select UserEmail,Password,UserName,UserID,AccountType from tblUser";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //useremail = reader["UserEmail"].ToString();
                //password = reader["Password"].ToString();
               
                if (txtemail.Text.ToString() == reader["UserEmail"].ToString() && txtpassword.Text.ToString() == reader["Password"].ToString())
                {
                    count++;
                    useremail = reader["UserEmail"].ToString();
                    password = reader["Password"].ToString();
                    username = reader["UserName"].ToString();
                    userId = Convert.ToInt32(reader["UserID"].ToString());
                    acountType = reader["AccountType"].ToString();

                }
            }

            if (count == 1)
            {
                MessageBox.Show("Sucessfully Login");
                MessageBox.Show("Sucessfully Login"+username+"\n" + useremail + "\n" + userId + "\n" + acountType + "\n");
              frmContainer frmcont = new frmContainer();
                frmcont.Show();
                //m_dbConnection.Close();
                this.Hide();
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate Account found.\nSorry to Login");
            }
            else
            {
                MessageBox.Show("UserName or password not correct");
            }
        }////

        public string getUserName()
        {
            return this.username;
        }
        public string getUserEmail()
        {
            return useremail;
        }
        public string getAcountType()
        {
            return acountType;
        }
        public int getUserId()
        {
            return userId;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
