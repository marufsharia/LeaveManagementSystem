using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class frmContainer : Form
    {

        public frmContainer()
        {
            InitializeComponent();

        }

        private void frmContainer_Load(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = new frmLogin().getUserEmail().ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
