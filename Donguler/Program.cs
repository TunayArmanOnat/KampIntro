using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kursu";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java Kursu";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kursu", "Temel Kurs", "Java Kursu", "Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek döner --  foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}