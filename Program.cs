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

        }
    }
}
