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
            MySqlCommand command = new MySqlCommand("select id, username, password, first_name, last_name, specialization, job_title, type from users where username=@user;", conn);
            command.Parameters.AddWithValue("user", user);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            string userName, password, firstname, lastname, spec, job, type;
            int id = 0;
            userName = password = firstname = lastname = spec = job = type = String.Empty;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                userName = reader.GetString(1);
                password = reader.GetString(2);
                firstname = reader.GetString(3);
                lastname = reader.GetString(4);
                spec = reader.GetString(5);
                job = reader.GetString(6);
                type = reader.GetString(7);

            }
            reader.Close();
            conn.Close();
            User current = new User(id, userName, password, firstname, lastname, spec, job, type);
            return current;
        }

        public static List<User> loadUsers()
        {
            List<User> _users = new List<User>();
            MySqlConnection conn = new MySqlConnection(connString());
            conn.Open();
            string load = "select id, username, first_name, last_name, specialization, job_title, type from users;";
            MySqlCommand command = new MySqlCommand(load, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    _users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                }
            }
            finally
            {
                reader.Close();
            }
            conn.Close();
            return _users;
        }

        public static List<MyPatientsList> loadMyPatientsView(int user_id)
        {
            List<MyPatientsList> patientsView = new List<MyPatientsList>();
            MySqlConnection conn = new MySqlConnection(connString());
            conn.Open();
            string load = "select p.cnp, concat(p.first_name, ' ', p.last_name), h.id_hosp, h.hosp_reason, h.hosp_date from patients p, users d, hospitalizations h where h.id_patient=p.cnp and h.id_doctor=d.id and h.id_doctor="+user_id+";";
            MySqlCommand command = new MySqlCommand(load, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    patientsView.Add(new MyPatientsList(reader.GetInt64(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetDateTime(4)));
                }
            }
            finally
            {
                reader.Close();
            }
            conn.Close();
            return patientsView;
        }

        public static void deleteUser(User user)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            conn.Open();
            string delete = "delete from users where id="+user.id; //no need for sanitizing since the user id is never edited by the user
            MySqlCommand command = new MySqlCommand(delete, conn);
            command.ExecuteNonQuery();
            conn.Clone();
        }
        
        public static void editUser(User user)
        {
            string editUser = "update users set first_name=@firstName, last_name=@lastName, specialization=@spec, job_title=@title, type=@newType where id=" + user.id;
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand(editUser, conn);
            command.Parameters.AddWithValue("firstName", user.FirstName);
            command.Parameters.AddWithValue("lastName", user.LastName);
            command.Parameters.AddWithValue("spec", user.specialization);
            command.Parameters.AddWithValue("title", user.JobTitle);
            command.Parameters.AddWithValue("newType", user.type);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void changePass(User user, string password)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            string newPass = "update users set password=@pass where id=" + user.id;
            MySqlCommand command = new MySqlCommand(newPass, conn);
            command.Parameters.AddWithValue("pass", password);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static bool checkDupe(string username)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            string check = "select * from users where username=@user";
            MySqlCommand command = new MySqlCommand(check, conn);
            command.Parameters.AddWithValue("user", username);
            conn.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            if(result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static void addUser(string username, string firstName, string lastName, string spec, string title, string type)
        {
            string pass = "changeme";
            MySqlConnection conn = new MySqlConnection(connString());
            string addUser = "INSERT INTO users (username, password, first_name, last_name, specialization, job_title, type) VALUES ( @username, '"+pass+"', @firstName, @lastName, @spec, @title, @type);";
            MySqlCommand command = new MySqlCommand(addUser, conn);
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("firstName", firstName);
            command.Parameters.AddWithValue("lastName", lastName);
            command.Parameters.AddWithValue("spec", spec);
            command.Parameters.AddWithValue("title", title);
            command.Parameters.AddWithValue("type", type);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
