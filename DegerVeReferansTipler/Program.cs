using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            //int,double,float,bool,decimal, = değer tip
            //class,array,interface = referans tip
            //stack ve heap
            //değer tip olanlar stack'te gerçekleşiyor
            //sayi1 = 10 = stack , sayi2 = 30 = stack
            //
        }
    }
}