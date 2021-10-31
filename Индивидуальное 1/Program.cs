using System;

namespace Индивидуальное_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if ((a >= 0) & (b >= 0))
            {
                if (a > b)
                {
                    a = Math.Sqrt(b);
                    Console.WriteLine("Корень числа b = " + a);
                }
                else
                {
                    b = Math.Sqrt(a);
                    Console.WriteLine("Корень числа a = " + b);
                }

            }
            else
                Console.WriteLine("Error");
        }
    }
}
