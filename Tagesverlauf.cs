using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalorienManager_WeightwatcherApp
{
    public class Tagesverlauf
    {
        public void tagesVerlauf()
        {

            Console.Clear();
            Console.WriteLine("\t-----TAGESVERLAUF-----\n");
            Console.WriteLine("\n\n\t MENGE\t\tNAHRUNGSMITTEL\t\tKCAL");
            Console.WriteLine("\t 200g\t\tTesteintrag\t\t500");
            Console.WriteLine("\t 1Stk\t\tTestkuchen\t\t600");
            Console.WriteLine("\t 1 Portion\t\tTestessen\t\t1000");
            Console.WriteLine("\n\n\t SUMME: XXX KALORIEN");
            Console.WriteLine("\n\t DU DARFST NOCH SUMME minus TAGESLIMIT KONSUMIEREN\n\n");
            Console.WriteLine("\t (N)EUER EINTRAG");
            Console.WriteLine("\t (L)ETZTEN EINTRAG LÖSCHEN");
            Console.WriteLine("\t (Z)U VORLAGENLISTE SPRINGEN");
            Console.ReadKey();

        }
    }
}
