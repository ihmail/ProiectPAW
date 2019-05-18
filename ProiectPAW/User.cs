using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProiectPAW
{
    public class User
    {
        public int id;
        public string username;
        public string password;
        public string FirstName;
        public string LastName;
        public string specialization;
        public string JobTitle;
        public string type;

        public User(string user, string first, string last, string spec, string job, string type)
        {
            this.username = user;
            this.FirstName = first;
            this.LastName = last;
            this.specialization = spec;
            this.JobTitle = job;
            this.type = type;
        }

        public User(int id, string user, string first, string last, string spec, string job, string type)
        {
            this.id = id;
            this.username = user;
            this.FirstName = first;
            this.LastName = last;
            this.specialization = spec;
            this.JobTitle = job;
            this.type = type;
        }

        public User(int id, string user, string password, string first, string last, string spec, string job, string type)
        {
            this.id = id;
            this.username = user;
            this.password = password;
            this.FirstName = first;
            this.LastName = last;
            this.specialization = spec;
            this.JobTitle = job;
            this.type = type;
        }

    }
}
