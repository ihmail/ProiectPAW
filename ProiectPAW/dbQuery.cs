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
        static string connString = "Server=sql7.freemysqlhosting.net;Port=3306;Database=sql7287025;Uid=sql7287025;password=DEtyr9egBg;";
        public static bool Login(string user, string pass)
        {
            bool isValid = false;
            MySqlConnection conn = new MySqlConnection(connString);
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
            MySqlConnection conn = new MySqlConnection(connString);
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
