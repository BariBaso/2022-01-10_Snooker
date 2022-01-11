using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snoker
{
    class Versenyzo
    {
        public int Helyezes { get; set; }
        public string Név { get; set; }
        public string Ország { get; set; }             //prop!!!!!!!!!!!!!!!!
        public int Nyeremeny { get; set; }


        public Versenyzo(string sor)
        {
            string[] t = sor.Split(';');
            Helyezes = int.Parse(t[0]);                 //beolvasás
            Név = t[1];
            Ország = t[2];
            Nyeremeny = int.Parse(t[3]);

        }
        
    }
}
