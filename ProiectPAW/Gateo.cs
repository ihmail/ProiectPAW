using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Gateo
    {
        internal int id_gateo;
        internal DateTime gateo_date;
        internal int id_hosp;
        internal string gandeste;
        internal string analize;
        internal string tratament;
        internal string evolutie;
        internal string observatii;


        internal Gateo(int _id_gateo, DateTime _date_gateo,int _id_hosp, string gand, string anal, string trat, string evol, string obs)
        {
            this.id_gateo = _id_gateo;
            this.gateo_date = _date_gateo;
            this.id_hosp = _id_hosp;
            this.gandeste = gand;
            this.analize = anal;
            this.tratament = trat;
            this.evolutie = evol;
            this.observatii = obs;
        }

        //internal int getID(Gateo g)
        //{
        //    return g.id_gateo;
        //}
    }


}
