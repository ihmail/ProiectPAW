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

        internal static string hostname = Properties.Settings.Default.dbHostname;
        internal static string port = Properties.Settings.Default.dbPort;
        internal static string database = Properties.Settings.Default.dbDatabase;
        internal static string username = Properties.Settings.Default.dbUsername;
        internal static string password = Properties.Settings.Default.dbPassword;

        private static string connString()
        {
            return "Server="+hostname+";Port="+port+";Database="+database+";Uid="+username+";password="+password+";";
        }

        private static string connString(string hostname, string port,  string database, string username, string password)
        {
            return "Server=" + hostname + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";password=" + password + ";";
        }

        internal static string checkDb()
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

        internal static bool Login(string user, string pass)
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

        internal static User loggedIn(string user)
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

        internal static List<User> loadUsers()
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

        internal static List<MyPatientsList> loadMyPatientsView(int user_id)
        {
            List<MyPatientsList> patientsView = new List<MyPatientsList>();
            MySqlConnection conn = new MySqlConnection(connString());
            conn.Open();
            string load = "select p.cnp, concat(p.first_name, ' ', p.last_name), h.id_hosp, h.hosp_reason, h.hosp_date from patients p, users d, hospitalizations h where h.id_patient=p.cnp and h.id_doctor=d.id and h.id_doctor="+user_id+" and open=1 order by h.hosp_date;";
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

        internal static void deleteUser(User user)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            conn.Open();
            string delete = "delete from users where id="+user.id; //no need for sanitizing since the user id is never edited by the user
            MySqlCommand command = new MySqlCommand(delete, conn);
            command.ExecuteNonQuery();
            conn.Clone();
        }

        internal static void editUser(User user)
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

        internal static void changePass(User user, string password)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            string newPass = "update users set password=@pass where id=" + user.id;
            MySqlCommand command = new MySqlCommand(newPass, conn);
            command.Parameters.AddWithValue("pass", password);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        internal static bool checkDupe(string username)
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

        internal static void addUser(string username, string firstName, string lastName, string spec, string title, string type)
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

        internal static List<Gateo> getGateo(int hosp_id)
        {
            string getGateoComm = "select * from gateo where id_hosp=" + hosp_id + " order by date;";
            List<Gateo> gateoList = new List<Gateo>();
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand(getGateoComm, conn);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    gateoList.Add(new Gateo(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }
            finally
            {
                reader.Close();
            }
            conn.Close();
            return gateoList;

        }

        internal static Gateo getGateoToEdit(int gateo_id)
        {
            Gateo gateoToEdit = null;
            string editGateoComm = "select * from gateo where id_gateo="+gateo_id+";";
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand(editGateoComm, conn);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                gateoToEdit = new Gateo(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
            reader.Close();
            conn.Close();
            return gateoToEdit;
        }

        internal static void editGateo(int _id_gateo, string _gand, string _anal, string _trat, string _evol, string _obs)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            string editGateo = "update gateo set gandeste=@gand, analize=@anal, tratament=@trat, evolutie=@evol, observatii=@obs where id_gateo="+ _id_gateo + ";";
            MySqlCommand command = new MySqlCommand(editGateo, conn);
            command.Parameters.AddWithValue("gand", _gand);
            command.Parameters.AddWithValue("anal", _anal);
            command.Parameters.AddWithValue("trat", _trat);
            command.Parameters.AddWithValue("evol", _evol);
            command.Parameters.AddWithValue("obs", _obs);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        internal static void addGateo(int _hosp_id, string _gand, string _anal, string _trat, string _evol, string _obs)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            string editGateo = "INSERT INTO gateo (date, id_hosp, gandeste, analize, tratament, evolutie, observatii) VALUES(@added, "+_hosp_id+", @gand, @anal, @trat, @evol, @obs);";
            MySqlCommand command = new MySqlCommand(editGateo, conn);
            command.Parameters.AddWithValue("added", DateTime.Now);
            command.Parameters.AddWithValue("gand", _gand);
            command.Parameters.AddWithValue("anal", _anal);
            command.Parameters.AddWithValue("trat", _trat);
            command.Parameters.AddWithValue("evol", _evol);
            command.Parameters.AddWithValue("obs", _obs);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        internal static List<string> getPatientDetails(long cnp)
        {
            List<string> pDetails = new List<string>();
            MySqlConnection conn = new MySqlConnection(connString());
            string commandGetDetails = "select cnp, concat(first_name, ' ', last_name), birth_date, sex, app, apf, ahc from patients where cnp="+cnp+";";
            MySqlCommand command = new MySqlCommand(commandGetDetails, conn);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pDetails.Add(reader.GetString(0));
                pDetails.Add(reader.GetString(1));
                pDetails.Add(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                pDetails.Add(reader.GetString(3));
                pDetails.Add(reader.GetString(4));
                pDetails.Add(reader.GetString(5));
                pDetails.Add(reader.GetString(6));
            }
            reader.Close();
            conn.Close();
            return pDetails;
        }

        internal static void dischargePatient(int id_hosp, string dischargeReason)
        {
            string discharge = "update hospitalizations set discharge_diag=@reason, discharge_date='"+DateTime.Now.ToString("yyyy-MM-dd") +"', open=0 where id_hosp ="+id_hosp+";";
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand(discharge, conn);
            command.Parameters.AddWithValue("reason", dischargeReason);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        internal static void editPatient(long cnp, string app, string apf, string ahc)
        {
            string edit = "update patients set app=@app, apf=@apf, ahc=@ahc where cnp="+cnp+";";
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand(edit, conn);
            command.Parameters.AddWithValue("app", app);
            command.Parameters.AddWithValue("apf", apf);
            command.Parameters.AddWithValue("ahc", ahc);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        internal static void newHosp(long cnp, int doctor, string reason)
        {
            string add = "insert into hospitalizations(id_patient, id_doctor, hosp_reason, hosp_date, open) values(@cnp, @currentUser, @reason, '"+DateTime.Now.ToString("yyyy-MM-dd") + "', 1);";
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand(add, conn);
            command.Parameters.AddWithValue("cnp", cnp);
            command.Parameters.AddWithValue("currentUser", doctor);
            command.Parameters.AddWithValue("reason", reason);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        internal static bool checkPatient(long cnp)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            string check = "select * from patients where cnp=@cnp";
            MySqlCommand command = new MySqlCommand(check, conn);
            command.Parameters.AddWithValue("cnp", cnp);
            conn.Open();
            bool result = Convert.ToBoolean(command.ExecuteScalar());
            conn.Close();
            return result;
        }

        internal static bool checkHosp(long cnp)
        {
            MySqlConnection conn = new MySqlConnection(connString());
            string check = "select * from hospitalizations where id_patient=@cnp;";
            MySqlCommand command = new MySqlCommand(check, conn);
            command.Parameters.AddWithValue("cnp", cnp);
            conn.Open();
            bool result = Convert.ToBoolean(command.ExecuteScalar());
            conn.Close();
            return result;
        }

        internal static void addPatient(long cnp, string first_name, string last_name, string birth_date, string sex, string APP, string APF, string AHC)
        {
            string addPatient = "insert into patients values(@cnp, @first_name, @last_name, @birth_date, @sex, @APP, @APF, @AHC);";
            MySqlConnection conn = new MySqlConnection(connString());
            MySqlCommand command = new MySqlCommand(addPatient, conn);
            command.Parameters.AddWithValue("cnp", cnp);
            command.Parameters.AddWithValue("first_name", first_name);
            command.Parameters.AddWithValue("last_name", last_name);
            command.Parameters.AddWithValue("birth_date", birth_date);
            command.Parameters.AddWithValue("sex", sex);
            command.Parameters.AddWithValue("APP", APP);
            command.Parameters.AddWithValue("APF", APF);
            command.Parameters.AddWithValue("AHC", AHC);
            conn.Open();
            command.ExecuteNonQuery();
        }
    }
}
