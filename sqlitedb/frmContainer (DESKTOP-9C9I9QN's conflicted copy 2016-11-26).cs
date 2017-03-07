using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmContainer :MetroForm
    {

        private frmLogin frml;
        private string useremail = null;
        private string username = null;
        private string acountType = null;
        private int userId = -1;
        private frmProfile frmProfile;

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
     
       

        

      

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = getsetUserEmail.ToString() + "\t " + getsetUserName.ToString() + "\t " + getsetAcountType.ToString() + "\t " + getsetUserId.ToString() + "\t ";
        }

       

        private void frmContainer_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Login: " + getsetUserName+" ("+getsetAcountType+")";
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime local = zone.ToLocalTime(DateTime.Now);
            lbldatetime.Text ="Login Time: " + local.ToString();
            if (getsetAcountType != "Admin")
            {
                button1.Enabled = false;
            }
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

        private void mnuItemleave_Click(object sender, EventArgs e)
        {
            frmApplicationFrom fApplicaion = new frmApplicationFrom();
            fApplicaion.Show();
            fApplicaion.TopMost = true;
        }
    }
}
