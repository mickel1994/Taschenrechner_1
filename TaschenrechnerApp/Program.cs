using System;

namespace TaschenrechnerApp
{
    class MainClass
    {
         static void Main(string[] args)
        {
            //User Story "Addieren": Als Benutzer mcöhte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            Console.WriteLine("Bitte geben Sie den ersten Summanden ein:");
            string ersterSummand = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie den zweiten Summanden ein");
            string zweiterSummand = Console.ReadLine();

            //Wandel Text in Ganzzahlen
            int ersterSummandalsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandalsZahl = Convert.ToInt32(zweiterSummand);

            //Berechnung ausführen
            int Summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            //Ausgabe

            Console.WriteLine("Die Summe ist: {0}", Summe);
            Console.ReadLine();


        }
    }
}
