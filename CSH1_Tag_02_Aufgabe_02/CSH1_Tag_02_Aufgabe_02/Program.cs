using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_02_Aufgabe_02
{
    class Program
    {
        static double DiffDouble(double zahl1, double zahl2)
        {
            double differenz = Math.Round(zahl1, 2) - Math.Round(zahl2, 2);

            if (differenz < 0)
                return differenz * -1;
            return differenz;
        }
        static void Main(string[] args)
        {
            double zahl1, zahl2, differenz;
            do
            {
                Console.Write("Bitte Zahl 1 angeben: ");
                zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Bitte Zahl 2 angeben: ");
                zahl2 = Convert.ToDouble(Console.ReadLine());

                differenz = DiffDouble(zahl1, zahl2);

                if (differenz != 0)
                {
                    Console.WriteLine($"Differenz lautet {differenz}! \nErgebnis ungleich 0, wiederhole Abfrage!");
                    Console.Beep();
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (differenz != 0);

            Console.WriteLine("Glückwunsch Differenz lautet 0! \nProgramm wird beendet!");
            Console.ReadKey();
        }
    }
}
