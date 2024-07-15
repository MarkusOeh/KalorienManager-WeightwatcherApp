namespace KalorienManager_WeightwatcherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeScreen welcome = new WelcomeScreen(); // aufrufen mit: welcome.welcomeScreen()
            Hauptmenü hauptmenü = new Hauptmenü();
            Tutorialseite tutorial = new Tutorialseite();
            Tagesverlauf tagesverlauf = new Tagesverlauf();
            Vorlagenseite vorlagenseite = new Vorlagenseite();
            Kalenderwochen kalenderwochen = new Kalenderwochen();
            Gesamtverlauf gesamtverlauf = new Gesamtverlauf();
            LimitFestlegen limitfestlegen = new LimitFestlegen();

            Console.ForegroundColor = ConsoleColor.Green;
            welcome.welcomeScreen();
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

            Console.ReadKey();

        }
    }
}
