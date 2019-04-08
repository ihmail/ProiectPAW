using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProiectPAW
{
    public static class dbQuery
    {

        public static string hostname = Properties.Settings.Default.dbHostname;
        public static string port = Properties.Settings.Default.dbPort;
        public static string database = Properties.Settings.Default.dbDatabase;
        public static string username = Properties.Settings.Default.dbUsername;
        public static string password = Properties.Settings.Default.dbPassword;

        private static string connString()
        {
            return "Server="+hostname+";Port="+port+";Database="+database+";Uid="+username+";password="+password+";";
        }

        private static string connString(string hostname, string port,  string database, string username, string password)
        {
            return "Server=" + hostname + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";password=" + password + ";";
        }

        public static string checkDb()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    conn.Open();
                    return "true";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        internal static string checkNewDbConnection(string hostname, string port,  string database, string username, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString(hostname, port, database, username, password)))
                {
                    conn.Open();
                    return "true";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static bool Login(string user, string pass)
        {
            bool isValid = false;
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand("select username, password from users where username=@user;", conn);
            command.Parameters.AddWithValue("user", user);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (user == reader.GetString(0) && pass == reader.GetString(1))
                    {
                        isValid = true;
                    }
                }
            }
            reader.Close();
            conn.Close();
            return isValid;
        }

        public static User loggedIn(string user)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand("select username, first_name, last_name, specialization, job_title, type from users where username=@user;", conn);
            command.Parameters.AddWithValue("user", user);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            string userName, firstname, lastname, spec, job, type;
            userName = firstname = lastname = spec = job = type = String.Empty;
            while (reader.Read())
            {
                userName = reader.GetString(0);
                firstname = reader.GetString(1);
                lastname = reader.GetString(2);
                spec = reader.GetString(3);
                job = reader.GetString(4);
                type = reader.GetString(5);

            }
            User current = new User(userName, firstname, lastname, spec, job, type);
            return current;
        }

    }
}
