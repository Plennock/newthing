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
    public partial class meetingRequest : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        public User user;
        public List<User> relatedUsers = new List<User>();

        public meetingRequest(User blonk)
        {
            user = blonk;
            InitializeComponent();
        }

        private void meetingRequest_Load(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = "";
            int index = 0;
            if(user.UserID[0].ToString() == "S")
            {
                querry = $"SELECT * FROM relations WHERE UserID2= '{user.UserID}'";
                index = 0;
            }
            else if (user.UserID[0].ToString() == "P")
            {
                querry = $"SELECT * FROM relations WHERE UserID1= '{user.UserID}'";
                index = 1;
            }
            else
            {
                querry = $"SELECT * FROM relations";
                index = 0;
            }
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);
            DataTable dTable = new DataTable();
            sda.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    querry = $"SELECT * FROM users WHERE UserID= '{dTable.Rows[i][index].ToString()}'";
                    sda = new SQLiteDataAdapter(querry, con);
                    DataTable theUser = new DataTable();
                    sda.Fill(theUser);
                    relatedUsers.Add(new User(theUser.Rows[0][0].ToString(), theUser.Rows[0][1].ToString(), theUser.Rows[0][2].ToString(), theUser.Rows[0][3].ToString()));
                    Relations.Items.Add(relatedUsers[relatedUsers.Count-1].ForeName+" "+relatedUsers[relatedUsers.Count - 1].SurName);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User UserToMeet = relatedUsers[Relations.SelectedIndex];
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            DateTime daMeet = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, Convert.ToInt32(Hours.SelectedItem), Convert.ToInt32(Minutes.SelectedItem), 0);
            string querry = $"SELECT * FROM engagements WHERE UserID = '{user.UserID}' OR UserID = '{UserToMeet.UserID}'";;
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);
            DataTable times = new DataTable();
            sda.Fill(times);
            
            string ye = "";
            for (int i = 0; i < times.Rows.Count; i++)
            {
                if (times.Rows[i][2].ToString() == daMeet.ToString())
                {
                    ye = times.Rows[i][2].ToString();
                }
            }
            if(ye != "")
            {
                MessageBox.Show("One or both parties are occupied at this time, please select another date/time for the meeting", "erroe", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    /* cmd.CommandText = $"INSERT INTO engagements VALUES('{user.UserID}', " +
                         $"'Meeting with {UserToMeet.ForeName} {UserToMeet.SurName}', '{daMeet.Year}-{daMeet.Month}-{daMeet.Day} {daMeet.Hour}:{daMeet.Minute.ToString("D2")}:{daMeet.Second.ToString("D2")}')";
                     cmd.ExecuteNonQuery();
                    */
                     cmd.CommandText = $"INSERT INTO MeetingProposal VALUES('{UserToMeet.UserID}', " +
                         $"'Meeting with {user.ForeName} {user.SurName}', '{daMeet.Year}-{daMeet.Month}-{daMeet.Day} {daMeet.Hour}:{daMeet.Minute.ToString("D2")}:{daMeet.Second.ToString("D2")}')";
                     cmd.ExecuteNonQuery();
                    cmd.CommandText = $"INSERT INTO notifications VALUES('{UserToMeet.UserID}', " +
                         $"'Meeting request from {user.ForeName} {user.SurName}, {user.UserID}', 'MR')";
                    cmd.ExecuteNonQuery();
                    Menu menu = new Menu(user);
                    menu.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot insert data");
                }
            }
        }

        private void Relations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
;