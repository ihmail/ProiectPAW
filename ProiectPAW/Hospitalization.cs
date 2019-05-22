using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Hospitalization
    {
        internal int id_hosp;
        internal int id_doc;
        internal string reason;
        internal string diagnosis;
        internal string admissionDate;
        internal string dischargeDate;
        internal string status;

        internal Hospitalization(int _id_hosp, int _id_doc,string _reason, string _diagnosis, string _admissionDate, string dischargeDate, string _status)
        {
            this.id_hosp = _id_hosp;
            this.id_doc = _id_doc;
            this.reason = _reason;
            this.diagnosis = _diagnosis;
            this.admissionDate = _admissionDate;
            this.dischargeDate = dischargeDate;
            this.status = _status;
        }
    }

    
}
