using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmProfile : MetroForm
    {
        SQLiteConnection m_dbConnection;
        private int Userid = -1;
        public frmProfile()
        {
            InitializeComponent();
            frmContainer fContainer = new frmContainer(this);

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            m_dbConnection =
                new SQLiteConnection(@"Data Source=" + path + "\\database\\LeaveDB.sqlite;Version=3;");
            m_dbConnection.Open();
            //MessageBox.Show("Userid: "+ SetGetUserID);
            loadUserinfo();
            if (cBoxAccType.Text != "Admin")
            {
                cBoxAccType.Enabled = false;
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToString() != "" && txtUserEmail.Text.ToString() != "" && txtPassword.Text.ToString() != "" && txtCPassword.Text.ToString() != "" && txtSecurity.Text.ToString() != "" && txtAddress.Text.ToString() != "" && cBoxAccType.SelectedItem.ToString() != "")

            {
                UpdateUser();
                m_dbConnection.Close();
                MessageBox.Show("Successfully Update Profile", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frmLogin fLogin = new frmLogin();
                //fLogin.Show();
                this.Hide();
            }
            else
            {
                //MetroMessageBox.Show(fcreate, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please filled up all the field correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UpdateUser()
        {
            string sql = "Update  tblUser SET   UserName='" + txtUserName.Text + "', UserEmail='" + txtUserEmail.Text + "', Password='" + txtPassword.Text + "', ConfirmPassword='" + txtCPassword.Text + "', SecurityKey='" + txtSecurity.Text + "', Address='" + txtAddress.Text + "', AccountType='" + cBoxAccType.SelectedItem.ToString() + "', UserPhoto='null' WHERE UserID='"+ SetGetUserID+ "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }

        public int SetGetUserID
        {
            get { return Userid; }
            set{ this.Userid = value; }


        }

        public void loadUserinfo()
        {
            string sql = "select * from tblUser WHERE UserID='"+SetGetUserID+"'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtUserName.Text = reader["UserName"].ToString();
                txtUserEmail.Text = reader["UserEmail"].ToString();
                txtPassword.Text = reader["Password"].ToString();
                txtCPassword.Text = reader["ConfirmPassword"].ToString();
                txtSecurity.Text = reader["SecurityKey"].ToString();
                txtAddress.Text = reader["Address"].ToString();
                cBoxAccType.Text = reader["AccountType"].ToString();

            }
               
                


        }
    }
}
