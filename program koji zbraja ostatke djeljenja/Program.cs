using System;

namespace program_koji_zbraja_ostatke_djeljenja
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, rezultat;
            Console.WriteLine("Upisi 2 broja");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = a % 3;
            d = b % 3;
            rezultat = c + d;
            Console.WriteLine(rezultat);
            Console.ReadKey();
        }
    }
}
