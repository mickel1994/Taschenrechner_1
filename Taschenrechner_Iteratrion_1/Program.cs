using System;

namespace Taschenrechner_Iteratrion_1

{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.WriteLine("Gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            //Umwandeln von Schrift in Zahlen

            float ersterSummandalsZahl = Convert.ToSingle(ersterSummand);
            float zweiterSummandalsZahl = Convert.ToSingle(zweiterSummand);

            // Addieren von den Summanden

            float summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            //Ergebniss

            Console.WriteLine("Die Summe beider zahlen ist: {0}", ersterSummandalsZahl + zweiterSummandalsZahl);
            Console.ReadLine();




  



          

            


            

        }

    }
}
