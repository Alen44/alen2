using System;

namespace dani_u_tjednu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi dan u tjednu");
            Console.WriteLine("PON UTO SRI CET PET SUB NED");

            String dan = Console.ReadLine();

            switch (dan)
            {
                case "PON":
                case "UTO":
                case "SRI":
                case "CET":
                case "PET": Console.WriteLine("Radni dan"); break;

                case "SUB":
                case "NED": Console.WriteLine("Neradni dan"); break;
                default: Console.WriteLine("Nepoznati dan?!"); break;
            }
        }
    }
}
