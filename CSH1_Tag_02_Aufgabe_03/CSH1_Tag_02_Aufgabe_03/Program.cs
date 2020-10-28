using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_02_Aufgabe_03
{
    class Program
    {
        static int InputINT(string infoText)
        {
            Console.Write(infoText);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int eingabe = 0;

            while(eingabe != 42)
            {
                eingabe = InputINT("Bitte Zahl eingeben: ");
                if (eingabe != 42)
                {
                    Console.WriteLine($"{eingabe} ist nicht die Antwort auf alle Fragen! \nNächster Versuch :)");
                    Console.Beep();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine($"Glückwunsch! {eingabe} ist die Antwort aller Fragen \nund denk dran nicht ohne dein Handtuch aus dem Haus zu gehen!");
            Console.ReadKey();
        }
    }
}
