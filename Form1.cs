using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace newthing
{
    public partial class Login : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void create_db()
        {
            if ((System.IO.File.Exists(path)))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"data source =" + path))
                {
                    sqlite.Open();
                    string sql = "DROP TABLE IF EXISTS users";  
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "CREATE TABLE IF NOT EXISTS users(UserID varchar(20), LoginID varchar(20), Forename MEDIUMTEXT, Surname MEDIUMTEXT)";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO users VALUES('S1', 'pass1', 'John', 'Lincoln'), " +
                        "('S2', 'pass2', 'Mark', 'Sellet'), ('S3', 'pass3', 'Sabine', 'McColl')," +
                        "('P1', 'pass1', 'Ben', 'Penders'), ('P2', 'pass2', 'Malcom', 'Marsh'), " +
                        "('T1', 'pass1', 'Spencerette', 'Toran')";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    sql = "DROP TABLE IF EXISTS relations";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "CREATE TABLE IF NOT EXISTS relations(UserID1 varchar(20), UserID2 varchar(20))";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO relations VALUES('P1', 'S1'), ('P1', 'S2'), ('P2', 'S3')";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    sql = "DROP TABLE IF EXISTS notifications";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "CREATE TABLE IF NOT EXISTS notifications(UserID varchar(20), description MEDIUMTEXT, code varchar(45))";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO notifications VALUES('P1', 'yeah', 'MR'), ('S1', 'Meeting request from Ben Penders, P1', 'MR'), ('S1', 'someb', 'PR')";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    sql = "DROP TABLE IF EXISTS MeetingProposal";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "CREATE TABLE IF NOT EXISTS MeetingProposal(recipientID varchar(20), senderID varchar(20), description MEDIUMTEXT, time DATETIME)";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO MeetingProposal VALUES('P1', 'S1', 'yeah', '2023-11-27 15:30:00'), ('S1', 'P1', 'Meeting request from Ben Penders, P1', '2023-11-24 13:00:00')";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    sql = "DROP TABLE IF EXISTS engagements";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "CREATE TABLE IF NOT EXISTS engagements(UserID varchar(20), description MEDIUMTEXT, time DATETIME)";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO engagements VALUES('P1', 'meeting with mark Sellet', '2023-11-18 15:30:00'), " +
                        "('S2', 'meeting with Ben Penders', '2023-11-18 15:30:00'), " +
                        "('S1', 'some bullshii', '2023-11-20 15:00:00')";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();

                    sql = "DROP TABLE IF EXISTS oldReports";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "CREATE TABLE IF NOT EXISTS oldReports(UserID varchar(20), description MEDIUMTEXT, time DATETIME)";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO oldReports VALUES('S1', 'I feel confident about todays lab and am looking forward to the next one', '2023-11-12 15:00:00'), " +
                        "('S2', 'I still need to work on some things from todays lab but will let my supervisor know if i need further help', '2023-11-02 15:00:00'), " +
                        "('S1', 'my meeting with Ben Penders went well', '2023-11-02 13:00:00')";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("NO!");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("YEah all good", "Error", MessageBoxButtons.OK);
            create_db();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //insert data
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string UserName, Password;

            UserName = txt_UserID.Text;
            Password = txt_Password.Text;

            try
            {
                string querry = $"SELECT * FROM users WHERE UserID = '{txt_UserID.Text}' AND LoginID = '{txt_Password.Text}'";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);
                if(dTable.Rows.Count > 0)
                {
                    UserName = txt_UserID.Text;
                    Password = txt_Password.Text;
                    User user = new User(dTable.Rows[0][0].ToString(), dTable.Rows[0][1].ToString(), dTable.Rows[0][2].ToString(), dTable.Rows[0][3].ToString());
                    if(user.UserID[0].ToString() == "S")
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
                else
                {
                    MessageBox.Show("Not right details :/", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login try again :/");
                txt_UserID.Clear();
                txt_Password.Clear();
                txt_UserID.Focus();
            }
            finally
            {
                con.Close();
            }
            /*
            try
            {
                cmd.CommandText = "INSERT INTO Test(ID, Name) VALUES(@ID, @Name)";

                string NAME = txt_UserID.Text;
                string ID = txt_Password.Text;

                cmd.Parameters.AddWithValue("@Name", NAME);
                cmd.Parameters.AddWithValue("@ID", ID);

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Name";
                string[] row = new string[] { ID, NAME };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot insert data");
            }
            */
        }

        //update
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            txt_UserID.Clear();
            txt_Password.Clear();
            txt_UserID.Focus();

            /*
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "UPDATE Test Set ID=@ID where name=@Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", txt_UserID.Text);
                cmd.Parameters.AddWithValue("@ID", txt_Password.Text);

                string NAME = txt_UserID.Text;
                string ID = txt_Password.Text;

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot insert data");
                return;
            }
            */
        }


        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /*
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE Test Set where name=@Name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", txt_UserID.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot delete data");
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "DELETE FROM Test";

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();*/
        }
           
    }

}
