using MetroFramework.Forms;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmCreateAccount : MetroForm
    {
        MetroForm fcreate = null;
        SQLiteConnection m_dbConnection;
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToString() != "" && txtUserEmail.Text.ToString() != "" && txtPassword.Text.ToString() != "" && txtCPassword.Text.ToString() != "" && txtSecurity.Text.ToString() != "" && txtAddress.Text.ToString() != "" && cBoxAccType.SelectedItem.ToString() != "")

            {
                creteUser();
                m_dbConnection.Close();
                MessageBox.Show("Successfully Create a New User", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin fLogin = new frmLogin();
                fLogin.Show();
                this.Hide();
            }
            else
            {
                //MetroMessageBox.Show(fcreate, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please filled up all the field correctly", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void frmCreateAccount_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
            this.Hide();
        }

        private void creteUser()
        {
            string sql = "insert into tbluser (UserName, UserEmail,Password,ConfirmPassword,SecurityKey,Address,AccountType,UserPhoto) values ('"+txtUserName.Text+ "', '" + txtUserEmail.Text + "','" + txtPassword.Text + "','" + txtCPassword.Text + "','" + txtSecurity.Text + "','" + txtAddress.Text + "','" + cBoxAccType.SelectedItem.ToString() + "','null')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }

        private void frmCreateAccount_Load(object sender, System.EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            m_dbConnection =
                new SQLiteConnection(@"Data Source=" + path + "\\database\\LeaveDB.sqlite;Version=3;");
            m_dbConnection.Open();
            fcreate = this;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
