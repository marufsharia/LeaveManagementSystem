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
    public partial class frmAdminjj : MetroForm
    {
        SQLiteConnection m_dbConnection;
        public frmAdminjj()
        {
            InitializeComponent();
          //  SQLiteConnection.CreateFile("MyDatabase.sqlite");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            m_dbConnection =
                new SQLiteConnection(@"Data Source="+path+"\\database\\LeaveDB.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string sql = "select * from tblUser order by  UserID asc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                //MessageBox.Show("Name: " + reader["USERNAME"] + "\nAGE: " + reader["Age"]);
            listView1.Items.Add("Name: " + reader["UserName"] + "\tAGE: " + reader["UserEmail"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbluser (USERNAME, Age,Email,Image,Address) values ('Me', 3000,'marufsharia@gmail.com','null','nikunju2')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
