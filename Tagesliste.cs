using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalorienManager_WeightwatcherApp
{
    public class Tagesliste
    {
        public static List<Tagesliste> tag;
        public string Menge { get; set; }
        public string Gericht { get; set; }
        public double Kcal { get; set; }

        public Tagesliste(string menge, string gericht, double kcal)
        {
            Menge = menge;
            Gericht = gericht;
            Kcal = kcal;
        }
    }
}
