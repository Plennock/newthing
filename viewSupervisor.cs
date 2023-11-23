using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace newthing
{
    public partial class viewSupervisor : Form
    {
        public User user;
        List<User> relatedUsers = new List<User>();
        List<User> relatedStudents = new List<User>();
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        public viewSupervisor(User blonk)
        {
            user = blonk;
            InitializeComponent();
        }

        private void viewSupervisor_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("MERKEKE");
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = "";
            querry = $"SELECT * FROM relations";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);
            DataTable dTable = new DataTable();
            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    querry = $"SELECT * FROM users WHERE UserID= '{dTable.Rows[i][0].ToString()}'";
                    sda = new SQLiteDataAdapter(querry, con);
                    DataTable theUser = new DataTable();
                    sda.Fill(theUser);
                    if(relatedUsers.Count == 0)
                    {
                        relatedUsers.Add(new User(theUser.Rows[0][0].ToString(), theUser.Rows[0][1].ToString(), theUser.Rows[0][2].ToString(), theUser.Rows[0][3].ToString()));
                        Relations.Items.Add(relatedUsers[relatedUsers.Count - 1].ForeName + " " + relatedUsers[relatedUsers.Count - 1].SurName);
                    }
                    else if (!(theUser.Rows[0][0].ToString() == relatedUsers[relatedUsers.Count-1].UserID))
                    {
                        relatedUsers.Add(new User(theUser.Rows[0][0].ToString(), theUser.Rows[0][1].ToString(), theUser.Rows[0][2].ToString(), theUser.Rows[0][3].ToString()));
                        Relations.Items.Add(relatedUsers[relatedUsers.Count - 1].ForeName + " " + relatedUsers[relatedUsers.Count - 1].SurName);
                    }
                }
            }
        }

        private void Relations_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }


        private void Relations_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            relatedStudents.Clear();
            var con = new SQLiteConnection(cs);
            User userToView = relatedUsers[Relations.SelectedIndex];
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = "";
            querry = $"SELECT * FROM relations WHERE UserID1= '{userToView.UserID}'";
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
                    relatedStudents.Add(new User(theUser.Rows[0][0].ToString(), theUser.Rows[0][1].ToString(), theUser.Rows[0][2].ToString(), theUser.Rows[0][3].ToString()));
                    listBox1.Items.Add(relatedStudents[relatedStudents.Count - 1].ForeName + " " + relatedStudents[relatedStudents.Count - 1].SurName);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HistoryBox.Items.Clear();
            User userToView = relatedStudents[listBox1.SelectedIndex];
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = "";
            querry = $"SELECT * FROM oldReports WHERE UserID= '{userToView.UserID}'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);
            DataTable dTable = new DataTable();
            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    HistoryBox.Items.Add(dTable.Rows[i][2].ToString());
                }
            }
        }

        private void HistoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            User userToView = relatedStudents[listBox1.SelectedIndex];
            DateTime tiempo = DateTime.Parse(HistoryBox.SelectedItem.ToString());
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = "";
            querry = $"SELECT * FROM oldReports WHERE time= '{tiempo.Year}-{tiempo.Month}-{tiempo.Day.ToString("D2")} {tiempo.Hour}:{tiempo.Minute.ToString("D2")}:{tiempo.Second.ToString("D2")}'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);
            DataTable dTable = new DataTable();
            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                Details.Text = dTable.Rows[0][1].ToString();
            }
            else
            {
                Details.Text = "No report here.";
            }
        }

        private void ExitToMenuButton_Click(object sender, EventArgs e)
        {
            TutorMenu tutmen = new TutorMenu(user);
            this.Close();   
            tutmen.Show();
        }
    }
}
