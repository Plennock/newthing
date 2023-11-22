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
    public partial class ProgressReport : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public User user;
        public string desc;
        public string SupID;

        public ProgressReport(User blonk, string desco)
        {
            user = blonk;
            desc = desco;
            InitializeComponent();
        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void ProgressReport_Load(object sender, EventArgs e)
        {
            Description.Text = desc;
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string querry = $"SELECT * FROM relations WHERE UserID2= '{user.UserID}'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);

            DataTable dTable = new DataTable();
            sda.Fill(dTable); 
            if(dTable.Rows.Count > 0)
            {
                SupID = dTable.Rows[0][0].ToString();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("whoops");
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = $"INSERT INTO notifications VALUES('{SupID}', '{textBox1.Text} from {user.UserID}', 'RS')";
                cmd.ExecuteNonQuery();
                SupervisorMenu menu = new SupervisorMenu(user);
                menu.Show();
                this.Hide();
            }
        }
    }
}
