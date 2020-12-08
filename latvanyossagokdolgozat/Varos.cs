using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latvanyossagokdolgozat
{
    class Varos
    {
        private string nev;
        private int lakossag;
        private List<Latvanyossag> latvanyossagok;

        public Varos(string nev,int lakossag)
        {
            this.Nev = nev;
            this.Lakossag = lakossag;
            latvanyossagok = new List<Latvanyossag>();
        }

        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }

        public List<Latvanyossag> GetLatvanyossagok()
        {
            return this.latvanyossagok;
        }

        public void setLavanyossagok(Latvanyossag l)
        {
            this.latvanyossagok.Add(l);
        }

        public override string ToString()
        {
            return String.Format("{0} ({1})",this.nev,this.lakossag);
        }
    }
}
