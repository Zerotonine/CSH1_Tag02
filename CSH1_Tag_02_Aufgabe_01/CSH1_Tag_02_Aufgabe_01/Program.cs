using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_02_Aufgabe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int iEingabe = 0;

            do
            {
                Console.Write("Bitte Zahl eingeben: ");
                iEingabe = Convert.ToInt32(Console.ReadLine());

                if ( iEingabe < 10)
                {
                    Console.WriteLine("Zahl muss mindestens 10 betragen!");
                    Console.Beep();
                    Console.ReadKey();
                    Console.Clear();
                } else
                {
                    Console.WriteLine("Herzlichen Glückwunsch! Sie sind klug genug bis 10 zu zählen!");
                    Console.ReadKey();
                }
            } while (iEingabe < 10);
        }
    }
}
