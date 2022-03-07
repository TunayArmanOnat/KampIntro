using System;

namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 52;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Enging Demiroğ";
            kurs1.IzlenmeOrani = 512;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "Ahmet";
            kurs2.IzlenmeOrani = 533;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "JavaScript";
            kurs3.KursunEgitmeni = "Hilal";
            kurs3.IzlenmeOrani = 1;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursunEgitmeni = "Gündüz Gece";
            kurs4.IzlenmeOrani = 556;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}