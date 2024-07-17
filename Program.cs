namespace KalorienManager_WeightwatcherApp
{
    internal class Program
    {


        //________________________LISTEN GLOBAL DEFINIEREN________________________
        class TagesListe
        {
            public string Menge { get; set; }
            public string Gericht { get; set; }
            public double Kcal { get; set; }
        }
        static List<TagesListe> tagesListe = new List<TagesListe>();


        class VorlagenListe
        {
            public string VorlageEinheit { get; set; }
            public string GerichtVorlage { get; set; }
            public double KcalVorlage { get; set; }
        }
        static List<VorlagenListe> vorlagenListe = new List<VorlagenListe>();


        class GesamtverlaufListe
        {
            public string DatumGV { get; set; }
            public double KcalGV { get; set; }
        }
        static List<GesamtverlaufListe> gesamtverlaufListe = new List<GesamtverlaufListe>();


        class KalenderWochenListe
        {
            public string Jahr { get; set; }
            public string KW { get; set; }
            public double Gewicht { get; set; }
        }
        static List<KalenderWochenListe> kalenderWochenListe = new List<KalenderWochenListe>();


        class TagesLimitListe
        {
            public double Tageslimit { get; set; }
        }
        static List<TagesLimitListe> tagesLimitListe = new List<TagesLimitListe>();
        //***********************LISTEN GLOBAL DEFINIEREN ENDE***********************



        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tWillkommen bei KalorienManager App\n");
                Console.WriteLine("\t(T)AGESVERLAUF\n");
                Console.WriteLine("\t(V)ORLAGENSEITE\n");
                Console.WriteLine("\t(G)ESAMTVERLAUF\n");
                Console.WriteLine("\t(K)ALENDERWOCHEN\n");
                Console.WriteLine("\tT(U)TORIAL\n");
                Console.WriteLine("\n\t(L)IMIT FESTLEGEN");
                string auswahl = Console.ReadLine().ToLower().Trim();

                switch (auswahl)
                {
                    case "t":
                        TagesVerlauf();
                        break;
                    case "v":
                        Vorlagenseite();
                        break;
                    case "g":
                        GesamtVerlauf();
                        break;
                    case "k":
                        KalenderWochen();
                        break;
                    case "u":
                        TutorialSeite();
                        break;
                    case "l":
                        LimitFestlegen();
                        break;
                    default:
                        Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }



        //________________________TAGESVERLAUF________________________
        static void TagesVerlauf()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t-----TAGESVERLAUF-----\n");
                double summeKcal = 0;
                foreach (TagesListe item in tagesListe)
                {
                    Console.WriteLine($" \t {item.Menge}\t\t {item.Gericht}\t\t{item.Kcal}");
                    summeKcal += item.Kcal;
                }
                Console.WriteLine($"\n\tGesamtsumme der Kcal: {summeKcal}");
                if (tagesLimitListe.Count > 0)
                {
                    double tageslimit = tagesLimitListe[0].Tageslimit;
                    double rest = tageslimit - summeKcal;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\t DU DARFST HEUTE NOCH {rest} KCAL KONSUMIEREN\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine("\n\tBITTE NOCH TAGESLIMIT ANGEBEN!\n");
                }


                Console.WriteLine("\t(N)EUER EINTRAG");
                Console.WriteLine("\t(L)ETZTEN EINTRAG LÖSCHEN");
                Console.WriteLine("\t(V)ORLAGENSEITE\n");
                Console.WriteLine("\t(H)AUPTMENÜ");

                string auswahl = Console.ReadLine().ToLower().Trim();

                switch (auswahl)
                {
                    case "n":
                        NeuerEintragTagesverlauf();
                        break;
                    case "l":
                        EntferneLetztenEintragTagesverlauf();
                        break;
                    case "v":
                        Vorlagenseite();
                        break;
                    case "h":
                        return;
                    default:
                        Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }
        static void NeuerEintragTagesverlauf()
        {
            TagesListe item = new TagesListe();
            Console.Write("MENGE EINGEBEN");
            item.Menge = Console.ReadLine();
            Console.Write("GERICHT EINGEBEN");
            item.Gericht = Console.ReadLine();
            Console.Write("KCAL EINGEBEN");
            item.Kcal = Convert.ToDouble(Console.ReadLine());
            tagesListe.Add(item);
            Console.WriteLine("\n\tDANKE");
            Thread.Sleep(500);
        }
        static void EntferneLetztenEintragTagesverlauf()
        {
            if (tagesListe.Count > 0)  // Überprüfen, ob die Liste nicht leer ist
            {
                tagesListe.RemoveAt(tagesListe.Count - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tWIRD GELÖSCHT");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tDIE LISTE LEER");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Thread.Sleep(1000);
        }

        //***********************TAGESVERLAUF ENDE***********************




        //________________________VORLAGENSEITE________________________
        static void Vorlagenseite()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t-----Vorlagenseite-----\n");
                foreach (VorlagenListe item in vorlagenListe)
                {
                    Console.WriteLine($" \t {item.VorlageEinheit}\t\t {item.GerichtVorlage}\t\t{item.KcalVorlage}");
                }
                Console.WriteLine("\t(N)EUER EINTRAG");
                Console.WriteLine("\t(L)ETZTEN EINTRAG LÖSCHEN");
                Console.WriteLine("\t(T)AGESVERLAUF\n");
                Console.WriteLine("\t(H)AUPTMENÜ");

                string auswahl = Console.ReadLine().ToLower().Trim();

                switch (auswahl)
                {
                    case "n":
                        NeuerEintragVorlagenseite();
                        break;
                    case "l":
                        EntferneLetztenEintragVorlagenSeite();
                        break;
                    case "t":
                        TagesVerlauf();
                        break;
                    case "h":
                        return;
                    default:
                        Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }

        static void NeuerEintragVorlagenseite()
        {
            VorlagenListe item = new VorlagenListe();
            Console.Write("PRO 100g? Pro Portion? Pro Stück?");
            item.VorlageEinheit = Console.ReadLine();
            Console.Write("GERICHT EINGEBEN");
            item.GerichtVorlage = Console.ReadLine();
            Console.Write("KCAL EINGEBEN");
            item.KcalVorlage = Convert.ToDouble(Console.ReadLine());
            vorlagenListe.Add(item);
            Console.WriteLine("\n\tDANKE");
            Thread.Sleep(500);
        }

        static void EntferneLetztenEintragVorlagenSeite()
        {
            if (vorlagenListe.Count > 0)  // Überprüfen, ob die Liste nicht leer ist
            {
                vorlagenListe.RemoveAt(vorlagenListe.Count - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tWIRD GELÖSCHT");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tDIE LISTE IST SCHON LEER");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Thread.Sleep(1000);
        }
        //***********************VORLAGENSEITE ENDE***********************




        //________________________GESAMTVERLAUFSEITE________________________

        static void GesamtVerlauf()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t-----GESAMTVERLAUF-----\n");
                foreach (GesamtverlaufListe item in gesamtverlaufListe)
                {
                    Console.WriteLine($" \t {item.DatumGV}\t\t{item.KcalGV}");
                }
                Console.WriteLine("\t(N)EUER EINTRAG");
                //Console.WriteLine("\t (L)ETZTEN EINTRAG LÖSCHEN");
                Console.WriteLine("\t(T)AGESVERLAUF\n");
                Console.WriteLine("\t(H)AUPTMENÜ");

                string auswahl = Console.ReadLine().ToLower().Trim();

                switch (auswahl)
                {
                    case "n":
                        NeuerEintragGesamtverlauf();
                        break;
                    case "t":
                        TagesVerlauf();
                        break;
                    case "h":
                        return;
                    default:
                        Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }

        static void NeuerEintragGesamtverlauf()
        {
            GesamtverlaufListe item = new GesamtverlaufListe();
            Console.Write("DATUM? YYYY.MM.DD");
            item.DatumGV = Console.ReadLine();
            Console.Write("GESAMT-KCAL DES TAGESEINGEBEN");
            item.KcalGV = Convert.ToDouble(Console.ReadLine());
            gesamtverlaufListe.Add(item);
            Console.WriteLine("\n\tDANKE");
            Thread.Sleep(500);
        }

        //***********************GESAMTVERLAUFSEITE ENDE***********************


        //________________________KALENDERWOCHENSEITE________________________
        static void KalenderWochen()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t-----KALENDERWOCHEN MIT GEWICHT-----\n");
                foreach (KalenderWochenListe item in kalenderWochenListe)
                {
                    Console.WriteLine($" \t {item.Jahr}\t\t {item.KW}\t\t{item.Gewicht}");
                }
                Console.WriteLine("\t(N)EUER EINTRAG");
                //Console.WriteLine("\t(L)ETZTEN EINTRAG LÖSCHEN");
                Console.WriteLine("\t(H)AUPTMENÜ");

                string auswahl = Console.ReadLine().ToLower().Trim();

                switch (auswahl)
                {
                    case "n":
                        NeuerEintragKalenderwochen();
                        break;
                    //case "l":
                    //    LetztenEintragLöschen();
                    //    break;
                    case "h":
                        return;
                    default:
                        Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }
        static void NeuerEintragKalenderwochen()
        {
            KalenderWochenListe item = new KalenderWochenListe();
            Console.Write("MENGE EINGEBEN");
            item.Jahr = Console.ReadLine();
            Console.Write("GERICHT EINGEBEN");
            item.KW = Console.ReadLine();
            Console.Write("KCAL EINGEBEN");
            item.Gewicht = Convert.ToDouble(Console.ReadLine());
            kalenderWochenListe.Add(item);
            Console.WriteLine("\n\tDANKE");
            Thread.Sleep(500);
        }
        //***********************KALENDERWOCHENSEITE ENDE***********************


        //________________________TUTORIALSEITE________________________
        static void TutorialSeite()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t(H)AUPTMENÜ\n\n");
                Console.WriteLine("\n\t-----TUTORIALSEITE-----\n");
                Console.WriteLine("Willkommen zur WeightWatchers App - Dein Kalorien Manager zum Abnehmen!");
                Console.WriteLine("");
                Console.WriteLine("Du willst Gewicht verlieren? Dann ist diese App genau das Richtige für dich! \nMit dem Kalorien Manager kannst du dein Ziel erreichen, indem du deine Ernährung genau im Blick behältst und Schritt für Schritt abnimmst. Folge den Anweisungen und du wirst erfolgreich sein.");
                Console.WriteLine("");
                Console.WriteLine("So funktioniert's:");
                Console.WriteLine("1. Kalorienaufnahme verstehen \nUm Gewicht zu verlieren, musst du weniger Kalorien zu dir nehmen, als du verbrauchst. Dies nennt man ein Kaloriendefizit.");
                Console.WriteLine("");
                Console.WriteLine("2. Essen abwiegen und protokollieren \nAuf allen Lebensmitteln stehen hinten drauf die enthaltenen Kcal pro 100g. Wiege dein Essen ab und multipliziere mit den angegebenen Kcal/100g. Trage die Kalorien in die App ein. So behältst du den Überblick und stellst sicher, dass du unter deinem Kalorienlimit bleibst.");
                Console.WriteLine("");
                Console.WriteLine("3. Zwei Wochen normal essen \nIss zwei Wochen lang ganz normal wie immer und trage alle deine Mahlzeiten in die App ein. So ermittelst du die Kalorien die dein Körper täglich verbraucht");
                Console.WriteLine("");
                Console.WriteLine("4. Kalorienziel festlegen \nNachdem du deinen täglichen Kalorienverbrauch ermittelt hast, ziehe 500 kcal davon ab. Das ist dein tägliches Kalorienziel, um effektiv abzunehmen.");
                Console.WriteLine("");
                Console.WriteLine("Hintergrundwissen: \n 1 kg menschliches Körperfett enthält 7000 kcal \nUm 1 kg Körperfett zu verlieren, musst du insgesamt 7000 kcal einsparen. Mit einem täglichen Defizit von 500 kcal hast du das in 2 Wochen erreicht");
                Console.WriteLine("");
                Console.WriteLine("Tipps für den Erfolg: \n Bewegung integrieren \nUnterstütze deinen Abnehmprozess mit regelmäßiger Bewegung. Das erhöht deinen Kalorienverbrauch und verbessert dein Wohlbefinden.");
                Console.WriteLine("");
                Console.WriteLine("Mit der KalorienManager/WeightWatcher App hast du ein mächtiges Werkzeug an deiner Seite, das dir hilft, deine Ziele zu erreichen. Starte noch heute und mach den ersten Schritt zu einem gesünderen und glücklicheren Leben!");
                Console.WriteLine("");
                Console.WriteLine("\t(H)AUPTMENÜ\n\n");

                string auswahl = Console.ReadLine().ToLower().Trim();

                switch (auswahl)
                {
                    case "h":
                        return;
                    default:
                        Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                        break;
                }
            }
        }
        //***********************TUTORIALSEITE ENDE***********************


        //_______________________LIMIT FESTLEGEN SEITE________________________
        static void LimitFestlegen()
        {
            TagesLimitListe item = new TagesLimitListe();
            Console.Write("TAGESLIMIT EINGEBEN");
            item.Tageslimit = Convert.ToDouble(Console.ReadLine());
            tagesLimitListe.Add(item);
            Console.WriteLine("\n\tDANKE");
            Thread.Sleep(500);
        }
        //***********************LIMIT FESTLEGEN ENDE***********************
    }
}
