using System;

namespace Taschenrechner_Iteratrion_1

{
    class Program
    {
        static void Main(string[] args)

        {
            //UserStory Addieren zweier Summanden mit Gleitkommazahl
            // Anforderung gib zwei Summanden ein


            Console.WriteLine("Gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.WriteLine("Gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in Gleitkommazahlen

            double ersterSummandalsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandalsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung ausführen 

            double Summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            // Ausgabe

            Console.WriteLine("Die Summe ist: {0}", ersterSummandalsZahl + zweiterSummandalsZahl);
            Console.ReadLine(); 
 

        }   

    }
}
