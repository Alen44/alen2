using System;

namespace površina_i_opseg_kruga
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, povrsina, opseg, radius;
            pi = Math.PI;
            Console.WriteLine("Upisi radius kruga");
            radius = Convert.ToDouble(Console.ReadLine());
            povrsina = radius * radius * pi;
            opseg = radius * pi;
            Console.WriteLine("Povrsina je " + povrsina + "a opseg je" + opseg);
            Console.ReadKey();
        }
    }
}
