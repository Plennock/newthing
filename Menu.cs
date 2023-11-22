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
    public partial class Menu : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public DataTable relationals;
        public DataTable notifs;
        public DataTable engagements;
        public User user;
        public Menu(User plob)
        {
            user = plob;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
            label1.Text = $"Welcome {user.ForeName} {user.SurName}";
            NotifBox.Items.Clear();

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = $"SELECT * FROM notifications WHERE UserID= '{user.UserID}'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);

            DataTable dTable = new DataTable();
            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                for(int i = 0; i < dTable.Rows.Count; i++)
                {
                    NotifBox.Items.Add(dTable.Rows[i][1].ToString());
                }
            }

            EngagBox.Items.Clear();

            querry = $"SELECT * FROM engagements WHERE UserID= '{user.UserID}'";
            sda = new SQLiteDataAdapter(querry, con);

            DataTable eTable = new DataTable();
            sda.Fill(eTable);
            if (eTable.Rows.Count > 0)
            {
                for (int i = 0; i < eTable.Rows.Count; i++)
                {
                    EngagBox.Items.Add(eTable.Rows[i][1].ToString());
                }
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            meetingRequest meetingAsk = new meetingRequest(user);
            meetingAsk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = $"SELECT * FROM notifications WHERE UserID= '{user.UserID}' AND description = '{NotifBox.SelectedItem.ToString()}'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);

            DataTable dTable = new DataTable();
            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
               if(dTable.Rows[0][2].ToString() == "MR")
               {
                    MeetingApprove meetingApprove = new MeetingApprove(user);
                    meetingApprove.meetManID = dTable.Rows[0][1].ToString().Substring(dTable.Rows[0][1].ToString().Length - 2);
                    meetingApprove.desc = dTable.Rows[0][1].ToString();
                    meetingApprove.Show();
                    this.Hide();
               }
               else if (dTable.Rows[0][2].ToString() == "PR")
               {
                    string desc = dTable.Rows[0][1].ToString();
                    ProgressReport meetingApprove = new ProgressReport(user, desc);
                    cmd.CommandText = $"DELETE FROM notifications WHERE UserID= '{user.UserID}' AND description = '{NotifBox.SelectedItem.ToString()}'";
                    cmd.ExecuteNonQuery();
                    meetingApprove.Show();
                    this.Hide();
               }
            }
        }
    }
}
