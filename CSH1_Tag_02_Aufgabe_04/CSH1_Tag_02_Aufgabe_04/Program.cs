using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_02_Aufgabe_04
{
    class Program
    {
        static double Eingabe(string s)
        {
            Console.Write(s);
            return Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
        }
        static void Main(string[] args)
        {
            double watt, zeit, kosten;

            watt = Eingabe("Bitte Verbrauch (Watt) eingeben: ");
            zeit = Eingabe("Bitte durschnittliche Laufzeit (pro Tag) des Rechners in Stunden eingeben: ");
            kosten = Eingabe("Bitte Kosten pro kW/h eingeben: ");

            Console.WriteLine($" Die Kosten pro Jahr betragen: {Math.Round(watt * zeit * (double)365 / (double)1000 * kosten, 2)} EUR");
            Console.ReadKey();
        }
    }
}
