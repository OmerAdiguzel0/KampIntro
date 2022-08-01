using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(double sayi1, double sayi2)
        {
            Console.WriteLine("Toplama Sonucu: " + (sayi1+sayi2));
        }

        public void Cikar(double sayi1, double sayi2)
        {
            Console.WriteLine("Çıkarma Sonucu: " + (sayi1-sayi2));
        }

        public void Bol(double sayi1, double sayi2)
        {
            Console.WriteLine("Bölme Sonucu: " + (sayi1/sayi2));
        }

        public void Carp(double sayi1, double sayi2)
        {
            Console.WriteLine("Çarpma Sonucu: " + (sayi1*sayi2));
        }

    }
}
