using System.Collections.Generic;

namespace KalorienManager_WeightwatcherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\tWillkommen bei KalorienManager App");
            Console.ReadKey();

            List<Tagesliste> heute = new List<Tagesliste>();

            HauptMenü(heute);










            //________________________HAUPTMENÜ________________________
            static void HauptMenü(List<Tagesliste> heute)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t-----HAUPTMENÜ-----\n\n");
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
                            TagesVerlauf(heute);
                            break;
                        case "v":
                            VorlagenListe(heute);
                            break;
                        case "g":
                            GesamtVerlauf(heute);
                            break;
                        case "k":
                            KalenderWochen(heute);
                            break;
                        case "u":
                            TutorialSeite(heute);
                            break;
                        case "l":
                            LimitFestlegen(heute);
                            break;
                        default:
                            Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                            break;
                    }
                }
            }
            //***********************HAUPTMENÜ ENDE***********************
















            //________________________TAGESVERLAUF________________________
            static void TagesVerlauf(List<Tagesliste> heute)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\t-----TAGESVERLAUF-----\n");
                    double limit = 3000;
                    Console.WriteLine($"\n\t DAS LIMIT IST {limit}kcal\n\n");
                    Console.WriteLine("\n\t MENGE\t\tNAHRUNGSMITTEL\t\tKCAL\n");
                    foreach (Tagesliste item in heute)
                    {
                        Console.WriteLine($" \t {item.Menge}\t\t {item.Gericht}\t\t{item.Kcal}");
                    }
                    static double SummeBerechnen(List<Tagesliste> heute)
                    {
                        return heute.Sum(item => item.Kcal);
                    }
                    Console.WriteLine("\n\n\n\t ----------------------------");
                    double summeheute = SummeBerechnen(heute);
                    Console.WriteLine($"\t SUMME: {summeheute} KALORIEN");

                    double rest = limit - summeheute;
                    Console.WriteLine($"\n\t DU DARFST NOCH {rest} KCAL KONSUMIEREN\n\n");

                    Console.WriteLine("\t (N)EUER EINTRAG");
                    Console.WriteLine("\t (L)ETZTEN EINTRAG LÖSCHEN");
                    Console.WriteLine("\t (Z)U VORLAGENLISTE SPRINGEN");
                    Console.WriteLine("\t (H)AUPTMENÜ");

                    string auswahl = Console.ReadLine().ToLower().Trim();

                    switch (auswahl)
                    {
                        case "n":
                            NeuerEintragTagesverlauf(heute);
                            break;
                        case "l":
                            LetztenEintragLöschen(heute);
                            break;
                        case "z":
                            ZuVorlagenListeSpringen(heute);
                            break;
                        case "h":
                            HauptMenü(heute);
                            break;
                        default:
                            Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                            break;
                    }
                }
            }
            static void NeuerEintragTagesverlauf(List<Tagesliste> heute)
            {
                Console.Clear();
                Console.Write("\n\tBITTE GIB DIE MENGE EIN:\n\t");
                string menge = Console.ReadLine();
                Console.Write("\n\tBITTE GIB DAS GERICHT EIN:\n\t");
                string gericht = Console.ReadLine();
                Console.Write("\n\tBITTE GIB DIE KALORIENANZAHL EIN:\n\t");
                double kcal = double.Parse(Console.ReadLine());
                heute.Add(new Tagesliste(menge, gericht, kcal));
                Console.WriteLine("\n\tDANKE");
                Thread.Sleep(500);
                TagesVerlauf(heute);
            }
            static void LetztenEintragLöschen(List<Tagesliste> heute)
            {
                Console.Clear();
                Console.WriteLine("\n\tTEST EINTRAG LÖSCHEN BESTANDEN. ZURÜCK ZU HAUPTMENÜ");
                Console.ReadKey();
                HauptMenü(heute);
            }
            static void ZuVorlagenListeSpringen(List<Tagesliste> heute)
            {
                Console.Clear();
                Console.WriteLine("\n\tTEST VORLAGENLISTE BESTANDEN. JETZT ZU VORLAGEN SPRINGEN");
                Console.ReadKey();
                VorlagenListe(heute);
            }
            //***********************TAGESVERLAUF ENDE***********************
















            //________________________VORLAGENSEITE________________________
            static void VorlagenListe(List<Tagesliste> heute)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t-----VORLAGEN-----");
                    Console.WriteLine("\t (N)EUE VORLAGE EINTRAGEN");
                    Console.WriteLine("\t (E)INTRAG LÖSCHEN");
                    Console.WriteLine("\t (Z)U TAGESLISTE SPRINGEN");
                    Console.WriteLine("\t (H)AUPTMENÜ");

                    string auswahl = Console.ReadLine().ToLower().Trim();

                    switch (auswahl)
                    {
                        case "n":
                            NeueVorlageEintragen(heute);
                            break;
                        case "l":
                            EintragLöschen(heute);
                            break;
                        case "z":
                            TagesVerlauf(heute);
                            break;
                        case "h":
                            HauptMenü(heute);
                            break;
                        default:
                            Console.WriteLine("\n\tUngültige Auswahl. Bitte erneut versuchen.");
                            break;
                    }
                }
            }
            static void NeueVorlageEintragen(List<Tagesliste> heute)
            {
                Console.Clear();
                Console.WriteLine("\n\tTEST NeueVorlageEintragen BESTANDEN. ZURÜCK ZU VORLAGENLISTE");
                Console.ReadKey();
                VorlagenListe(heute);
            }
            static void EintragLöschen(List<Tagesliste> heute)
            {
                Console.Clear();
                Console.WriteLine("\n\tTEST EintragLöschen BESTANDEN. ZURÜCK ZU VORLAGENLISTE");
                Console.ReadKey();
                VorlagenListe(heute);
            }
            //***********************VORLAGENSEITE ENDE***********************
















            //________________________GESAMTVERLAUF________________________
            static void GesamtVerlauf(List<Tagesliste> heute)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t-----GESAMTVERLAUF TESTSEITE-----\n");
                    Console.ReadKey();
                    HauptMenü(heute);
                }
            }
            //***********************GESAMTVERLAUF ENDE***********************
















            //________________________KALENDERWOCHEN________________________
            static void KalenderWochen(List<Tagesliste> heute)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tKALENDERWOCHEN TESTSEITE");
                    Console.ReadKey();
                    HauptMenü(heute);
                }
            }
            //***********************KALENDERWOCHEN ENDE***********************
















            //________________________TUTORIAL________________________
            static void TutorialSeite(List<Tagesliste> heute)
            {
                while (true)
                {
                    Console.Clear();
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

                    Console.WriteLine("DRÜCKE EINE TASTE ZURÜCK ZUM HAUPTMENÜ");
                    Console.ReadKey();
                    HauptMenü(heute);
                }
            }
            //***********************TUTORIAL ENDE***********************





















            //________________________LIMIT FESTLEGEN________________________
            static void LimitFestlegen(List<Tagesliste> heute)
            {
                double tageslimit;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tWie viele Kalorien soll dein Tageslimit sein?");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out tageslimit))
                    {
                        Console.WriteLine($"\n\tDein Tageslimit an Kalorien ist: {tageslimit}");
                        Console.ReadKey();
                        HauptMenü(heute);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n\tUngültige Eingabe. Bitte gib eine gültige Zahl ein.\n");
                    }
                }

            }
            //***********************LIMIT FESTLEGEN ENDE***********************

        }
    }
}
