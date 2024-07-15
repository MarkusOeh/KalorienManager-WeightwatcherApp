using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalorienManager_WeightwatcherApp
{
    public class LimitFestlegen
    {
        public void limitFestlegen()
        {
            double tageslimit;
            while (true)
            {
                Console.WriteLine("Wie viele Kalorien soll dein Tageslimit sein?");
                string input = Console.ReadLine();

                if (double.TryParse(input, out tageslimit))
                {
                    Console.WriteLine($"Dein Tageslimit an Kalorien ist: {tageslimit}");
                    Console.ReadKey();
                    break; // Schleife beenden, da eine gültige Zahl eingegeben wurde
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine gültige Zahl ein.\n");
                }
            }
        }
    }
}
