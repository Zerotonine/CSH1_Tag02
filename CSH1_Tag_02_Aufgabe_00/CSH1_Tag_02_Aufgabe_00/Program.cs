using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_02_Aufgabe_00
{
    class Program
    {
        static int ZahlAbfragen()
        {
            Console.Write("Bitte Zahl eingeben: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int i = ZahlAbfragen();
            Console.WriteLine($"Die eingebene Zahl lautet: {i}");
            Console.ReadKey();
        }
    }
}
