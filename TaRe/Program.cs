using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaRe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addieren von zwei Zahlen
            Console.WriteLine("Gib den ersten Summanden ein ");
            string erstersummand = Console.ReadLine();
            Console.Write("Gib den zweiten Summanden ein ");
            string zweitersummand = Console.ReadLine();
            Console.ReadLine();

            //Wandel Text in Numerische Werte um
            int ersterSummandalsZahl = Convert.ToInt32(erstersummand);
            int zweiterSummandalsZahl = Convert.ToInt32(zweitersummand);
        
            int summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();
        }
    }
}
