using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class MyPatientsList
    {
        public long cnp;
        public string name;
        public int hosp_id;
        public string hospReason;
        public DateTime hospDate;

        public MyPatientsList(long _cnp, string _name, int _hosp_id, string _hospReason, DateTime _hospDate)
        {
            this.cnp = _cnp;
            this.name = _name;
            this.hosp_id = _hosp_id;
            this.hospReason = _hospReason;
            this.hospDate = _hospDate;
        }

    }

  

}
