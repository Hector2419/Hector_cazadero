using System;
namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            //hia
            Console.WriteLine("Imprime numeros del x hasta y de -1");
            Console.WriteLine("cuando vale x?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuando vale m?");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > m; i--)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}