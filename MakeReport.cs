using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MakeReport : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        List<User> relatedUsers = new List<User>();
        public User user;

        public MakeReport(User plob)
        {
            user = plob;
            InitializeComponent();
        }

        private void MakeReport_Load(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = "";
            querry = $"SELECT * FROM relations WHERE UserID1= '{user.UserID}'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);
            DataTable dTable = new DataTable();
            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    querry = $"SELECT * FROM users WHERE UserID= '{dTable.Rows[i][1].ToString()}'";
                    sda = new SQLiteDataAdapter(querry, con);
                    DataTable theUser = new DataTable();
                    sda.Fill(theUser);
                    relatedUsers.Add(new User(theUser.Rows[0][0].ToString(), theUser.Rows[0][1].ToString(), theUser.Rows[0][2].ToString(), theUser.Rows[0][3].ToString()));
                    StudentList.Items.Add(relatedUsers[relatedUsers.Count - 1].ForeName + " " + relatedUsers[relatedUsers.Count - 1].SurName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            for (int i = 0; i < relatedUsers.Count; i++)
            {
                if(StudentList.GetItemCheckState(i) == CheckState.Checked)
                {
                    cmd.CommandText = $"INSERT INTO notifications VALUES('{relatedUsers[i].UserID}', '{textBox1.Text}', 'PR')";
                    cmd.ExecuteNonQuery();
                }
            }
            SupervisorMenu menu = new SupervisorMenu(user);
            menu.Show();
            this.Hide();
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendToAll_CheckedChanged(object sender, EventArgs e)
        {
            if(SendToAll.Checked)
            {
                for (int i = 0; i < StudentList.Items.Count; i++)
                {
                    StudentList.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < StudentList.Items.Count; i++)
                {
                    StudentList.SetItemChecked(i, false);
                }
            }
        }
    }
}
