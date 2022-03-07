using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[]args)
        {
            Basketciler basketci1 = new Basketciler();
            basketci1.AdiVeSoyadi = "Ahmet Büyük";
            basketci1.Yasi = 21;
            basketci1.Boyu = 1.88;

            Basketciler basketci2 = new Basketciler();
            basketci2.AdiVeSoyadi = "Mehmet Sever";
            basketci2.Yasi = 19;
            basketci2.Boyu = 1.78;

            Basketciler basketci3 = new Basketciler();
            basketci3.AdiVeSoyadi = "Arman Onat";
            basketci3.Yasi = 29;
            basketci3.Boyu = 1.80;

            Basketciler basketci4 = new Basketciler();
            basketci4.AdiVeSoyadi = "Burak Durak";
            basketci4.Yasi = 23;
            basketci4.Boyu = 1.77;

            Basketciler basketci5 = new Basketciler() { AdiVeSoyadi = "Cafer", Yasi = 17, Boyu = 1.10 };
            


            Basketciler[] basketciler = new Basketciler[] {basketci1, basketci2, basketci3, basketci4, basketci5};

            foreach (var basketci in basketciler)
            {
                if (basketci.Boyu>=1.85)
                {
                    Console.WriteLine("Basketçinin Adı:" + basketci.AdiVeSoyadi + " " + "Yaşı:" + basketci.Yasi + " " + "Boy Durumu: UYGUN");
                }
                else
                {
                    Console.WriteLine("Basketçinin Adı:" + basketci.AdiVeSoyadi + " " + "Yaşı:" + basketci.Yasi + " " + "Boy Durumu: UYGUN DEĞİL");
                }
            }

           
            
        }
    }
    class Basketciler
    {
        public string AdiVeSoyadi { get; set; }
        public int Yasi { get; set; }
        public double Boyu { get; set; }
    }
}