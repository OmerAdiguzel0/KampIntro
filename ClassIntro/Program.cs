using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs = new Kurs();
            kurs.KursAdi = "C#";
            kurs.Egitmen = "Ömer Adıgüzel";
            kurs.IzlenmeOrani = 95;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Semih Bayram";
            kurs1.IzlenmeOrani = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Muammer Baytar";
            kurs2.IzlenmeOrani = 96;

            //Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " % " + kurs.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] 
            {
                kurs,
                kurs1,
                kurs2
            };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + " : " + item.Egitmen + " % " + item.IzlenmeOrani);
            }

            Console.ReadLine();

        }
    }


    class Kurs
    {

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

}
