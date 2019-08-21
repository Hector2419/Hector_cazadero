using System;
namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, b;
            //hia
            Console.WriteLine("Imprime numeros del x hasta y");
            Console.WriteLine("cuando vale x?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuando vale m?");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("de cuanto en cuanto");
            b = Convert.ToInt32(Console.ReadLine());
           if (n>m)
            {
                for (int i = n; i > m; i -= b)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                for (int i = n; i < m; i += b)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}