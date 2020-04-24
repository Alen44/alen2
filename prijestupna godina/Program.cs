using System;

namespace prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite godinu");
            int a;
            if (a % 400 == 0)
            {
                Console.WriteLine("godina je prijestupna");
            }
            else if (a % 100 == 0)
            {
                Console.WriteLine("godina nije prijestupna");
            }
            else if(a % 4 == 0)
            {
                Console.WriteLine("godina je prijestupna");
            }
            else
            {
                Console.WriteLine("godina nije prijestupna");
            }
        }
    }
}
