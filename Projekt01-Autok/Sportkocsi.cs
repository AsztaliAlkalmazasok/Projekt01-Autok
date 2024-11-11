using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt01_Autok
{
    internal class Sportkocsi
    {
        public string Marka {  get; set; }
        public string Tipus {  get; set; }
        public int Ar {  get; set; }
        public string Kep {  get; set; }

        public Sportkocsi(string marka, string tipus, int ar, string kep)
        {
            this.Marka = marka;
            this.Tipus = tipus;
            this.Ar = ar;
            this.Kep = kep;
        }
    }
}
