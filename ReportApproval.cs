using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace newthing
{
    public partial class ReportApproval : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public string studentID;
        public string ReportContent;
        public User user;

        public ReportApproval(User blonk, string stud, string cont)
        {
            user = blonk;
            studentID = stud;
            ReportContent = cont;
            InitializeComponent();
        }

        private void ReportApproval_Load(object sender, EventArgs e)
        {

        }

        private void Approve_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = $"INSERT INTO oldReports VALUES('{studentID}', '{textBox1.Text}', '{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day} {DateTime.Now.Hour}:{DateTime.Now.Minute.ToString("D2")}:{DateTime.Now.Second.ToString("D2")}')";
            cmd.ExecuteNonQuery();
            SupervisorMenu menu = new SupervisorMenu(user);
            menu.Show();
            this.Hide();
        }

        private void Reject_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("give feedback please.");
            }
            else
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = $"INSERT INTO notifications VALUES('{studentID}', '{textBox1.Text}', 'PR')";
                cmd.ExecuteNonQuery();
                SupervisorMenu menu = new SupervisorMenu(user);
                menu.Show();
                this.Hide();
            }
        }
    }
}
