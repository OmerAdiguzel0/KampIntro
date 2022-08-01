using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.35;
            double dolarBugun = 7.25;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Düştü!");
            }
            else if (dolarBugun==dolarDun)
            {
                Console.WriteLine("Dolar Sabit!");
            }
            else
            {
                Console.WriteLine("Dolar Arttı!");
            }
            Console.ReadLine();
        }
    }
}
