using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace newthing
{
    public class Data
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public void create_db()
        {
            if ((System.IO.File.Exists(path)))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"data source =" + path))
                {
                    sqlite.Open();
                    string sql = "DROP DATABASE IF EXISTS data_table";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "DROP TABLE IF EXISTS users";
                    command = new SQLiteCommand(sql, sqlite);
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
                    sql = "CREATE TABLE IF NOT EXISTS notifications(UserID varchar(20), description MEDIUMTEXT)";
                    command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO notifications VALUES('P1', 'yeah'), ('S1', 'yeah'), ('P2', 'someb')";
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
    }
}
