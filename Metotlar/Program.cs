using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Ad = "Karpuz";
            urun1.Fiyat = 4.5;
            urun1.Aciklama = "Diyarbakır Karpuzu";

            Urun urun2 = new Urun();
            urun2.Ad = "Peynir";
            urun2.Fiyat = 65;
            urun2.Aciklama = "Köy Peyniri";

            Urun[] urunler = new Urun[] 
            {
                urun1,
                urun2
            };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Ad +" / "+ urun.Fiyat +" / "+ urun.Aciklama);
            }

            Console.WriteLine("--------------Method-----------------");

            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
