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
            float ersterSummandalsZahl = Convert.ToSingle(erstersummand);
            float zweiterSummandalsZahl = Convert.ToSingle(zweitersummand);
        
            float summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();
        }
    }
}
