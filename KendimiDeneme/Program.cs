using System;

namespace KendimiDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 2;

            Console.WriteLine(x + y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x - y);

            if (x < y)
            {
                Console.WriteLine(y + ", " + x + "'den büyük");
            }
            else
            {
                Console.WriteLine(x + ", " + y + "'den büyük");
            }

            Console.WriteLine("--------------------------------");          
         }
    }
}
    