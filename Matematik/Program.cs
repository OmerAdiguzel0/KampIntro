using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem islem = new DortIslem();
            islem.Topla(4,8);
            islem.Cikar(4,8);
            islem.Carp(4,8);
            islem.Bol(4,8);

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
