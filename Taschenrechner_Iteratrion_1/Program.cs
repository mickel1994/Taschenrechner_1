using System;

namespace Taschenrechner_Iteratrion_1

{
    class Program
    {
        static void Main(string[] args)
        {
            //  User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen
            Console.Write("Bitte gib den ersten Summanden ein:");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein:");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in Ganzzahlen
            int ersterSummmandalsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandalsZahl = Convert.ToInt32(zweiterSummand);

            //Berechnung ausführen
            int summe = ersterSummmandalsZahl + zweiterSummandalsZahl;

            //Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();


        }

    }
}
