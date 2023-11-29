using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaKlase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zrakoplov pop34 = new zrakoplov("B-201",1456,8234);
            Console.WriteLine(pop34.ToString());

            zrakoplov x350 = new zrakoplov("Airbus",123, 8234);
            Console.WriteLine(x350.ToString());

            zrakoplov pc32 = new zrakoplov("Giga101", 14326, 8234);
            Console.WriteLine(pc32.ToString());
            Console.ReadKey();
        }

    }

