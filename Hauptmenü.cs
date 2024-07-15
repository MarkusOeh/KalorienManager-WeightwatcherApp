using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalorienManager_WeightwatcherApp
{
    public class Hauptmenü
    {
        public void hauptMenü()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\t-----HAUPTMENÜ-----");
            Console.WriteLine("");
            Console.WriteLine("\tTAGESVERLAUF");
            Console.WriteLine("\tVORLAGENSEITE");
            Console.WriteLine("\tGESAMTVERLAUF");
            Console.WriteLine("\tKALENDERWOCHEN");
            Console.WriteLine("\tTUTORIAL");
            Console.WriteLine("\n\tLIMIT FESTLEGEN");
            Console.ReadKey();
        }
    }
}
