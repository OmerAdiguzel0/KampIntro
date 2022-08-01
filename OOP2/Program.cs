using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.ID = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Ömer";
            musteri1.Soyadi = "Adıgüzel";
            musteri1.TCNo = "2315645320";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "145232";
            musteri2.SirketAdi = "Sude Nur";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3= new GercekMusteri();
            Musteri musteri4= new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);






        }
    }
}