using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Marka = "a";
            urun1.Numara = 40;
            urun1.Fiyat = 400;
            urun1.Puan = 5;

            Urun urun2 = new Urun();
            urun2.Marka = "b";
            urun2.Numara = 41;
            urun2.Fiyat = 350;
            urun2.Puan = 4;

            Urun urun3 = new Urun();
            urun3.Marka = "c";
            urun3.Numara = 39;
            urun3.Fiyat = 250;
            urun3.Puan = 4;

            Urun urun4 = new Urun();
            urun4.Marka = "d";
            urun4.Numara = 37;
            urun4.Fiyat = 150;
            urun4.Puan = 3;

            Urun[] urunler = new Urun[] 
            {
                urun1,
                urun2,
                urun3,
                urun4
            };

            Urun EnPahali = new Urun();
            EnPahali.Fiyat = 0;

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Marka + " / " + urun.Numara + " / " + urun.Fiyat + " / " + urun.Puan);
                if (urun.Fiyat > EnPahali.Fiyat)
                {
                    EnPahali = urun;

                }
            }
            Console.WriteLine("En Pahalı Ürün Markası: "+EnPahali.Marka);

            Console.ReadLine();

        }
    }


    class Urun
    {
        public string Marka { get; set; }
        public int Numara { get; set; }
        public double Fiyat { get; set; }
        public int Puan { get; set; }
    }
}
