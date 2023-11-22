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
    public partial class MeetingApprove : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public string desc;
        public string meetManID;
        public User user;
        public User UserToMeet;
        public DateTime daMeet;

        public MeetingApprove(User blonk)
        {
            user = blonk;
            InitializeComponent();
        }

        private void MeetingApprove_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection(cs);
            con.Open();
            cmd = new SQLiteCommand(con);
            label2.Text = desc;
            string querry = $"SELECT * FROM users WHERE UserID = '{meetManID}'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);
            DataTable dTable = new DataTable();

            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                UserToMeet = new User(dTable.Rows[0][0].ToString(), dTable.Rows[0][1].ToString(), dTable.Rows[0][2].ToString(), dTable.Rows[0][3].ToString());
            }

            querry = $"SELECT * FROM MeetingProposal WHERE senderID = '{meetManID}' AND recipientID = '{user.UserID}' AND description = '{desc}'";
            sda = new SQLiteDataAdapter(querry, con);

            DataTable prop = new DataTable();
            sda.Fill(prop);
            time.Text = prop.Rows[0][3].ToString();
            DateTime.TryParse(time.Text, out daMeet);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"INSERT INTO engagements VALUES('{user.UserID}', " +
                         $"'Meeting with {UserToMeet.ForeName} {UserToMeet.SurName}', '{daMeet.Year}-{daMeet.Month}-{daMeet.Day} {daMeet.Hour}:{daMeet.Minute.ToString("D2")}:{daMeet.Second.ToString("D2")}')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"INSERT INTO engagements VALUES('{UserToMeet.UserID}', " +
                $"'Meeting with {user.ForeName} {user.SurName}', '{daMeet.Year}-{daMeet.Month}-{daMeet.Day} {daMeet.Hour}:{daMeet.Minute.ToString("D2")}:{daMeet.Second.ToString("D2")}')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"DELETE FROM notifications WHERE UserID = '{user.UserID}' AND description = '{desc}'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"DELETE FROM MeetingProposal WHERE senderID = '{meetManID}' AND recipientID = '{user.UserID}' AND description = '{desc}'";
            cmd.ExecuteNonQuery();
            if (user.UserID[0].ToString() == "S")
            {
                Menu form2 = new Menu(user);
                form2.Show();
                con.Close();
                this.Hide();
            }
            else if (user.UserID[0].ToString() == "P")
            {
                SupervisorMenu form2 = new SupervisorMenu(user);
                form2.Show();
                con.Close();
                this.Hide();
            }
            else if (user.UserID[0].ToString() == "T")
            {
                TutorMenu form2 = new TutorMenu(user);
                form2.Show();
                con.Close();
                this.Hide();
            }
        }

        private void Reject_Click(object sender, EventArgs e)
        {
            MessageBox.Show(daMeet.ToString());
        }
    }
}
