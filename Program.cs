namespace KalorienManager_WeightwatcherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeScreen welcome = new WelcomeScreen(); // aufrufen mit: welcome.welcomeScreen()
            Tutorialseite tutorial = new Tutorialseite();
            Tagesverlauf tagesverlauf = new Tagesverlauf();
            Vorlagenseite vorlagenseite = new Vorlagenseite();
            Kalenderwochen kalenderwochen = new Kalenderwochen();
            Gesamtverlauf gesamtverlauf = new Gesamtverlauf();
            LimitFestlegen limitfestlegen = new LimitFestlegen();

            Console.ForegroundColor = ConsoleColor.Green;
            welcome.welcomeScreen();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\t-----HAUPTMENÜ-----");
                Console.WriteLine("");
                Console.WriteLine("\t(T)AGESVERLAUF");
                Console.WriteLine("\t(V)ORLAGENSEITE");
                Console.WriteLine("\t(G)ESAMTVERLAUF");
                Console.WriteLine("\t(K)ALENDERWOCHEN");
                Console.WriteLine("\tT(U)TORIAL");
                Console.WriteLine("\n\t(L)IMIT FESTLEGEN");

                string auswahl = Console.ReadLine().ToLower().Trim();

                switch (auswahl)
                {
                    case "t":
                        tagesverlauf.tagesVerlauf();
                        break;
                    case "v":
                        vorlagenseite.vorlagenSeite();
                        break;
                    case "g":
                        gesamtverlauf.gesamtVerlauf();
                        break;
                    case "k":
                        kalenderwochen.kalenderWochen();
                        break;
                    case "u":
                        tutorial.tutorialSeite();
                        break;
                    case "l":
                        limitfestlegen.limitFestlegen();
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }
    }
}
