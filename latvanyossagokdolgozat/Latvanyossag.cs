using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latvanyossagokdolgozat
{
    class Latvanyossag
    {
        private string nev;
        private string leiras;
        private int ar;
        private int varosid;

        public Latvanyossag(string nev, string leiras, int ar, int varosid)
        {
            this.Nev = nev;
            this.Leiras = leiras;
            this.Ar = ar;
            this.Varosid = varosid;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Varosid { get => varosid; set => varosid = value; }

        public override string ToString()
        {
            return String.Format("{0} ({1} Ft)",this.nev,this.ar);
        }
    }
}
