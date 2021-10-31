using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a, b, c, d , x1, x2;
            Console.WriteLine("Введите значения a,b,c для уравнения ax^2+bx+c=0");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (a == 0)
                a = 1;
            if (b == 0)
                b = 1;
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                d = Math.Sqrt(d);
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("Корни уравнения = " + x1+ " " +x2);
            }
            if (d == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("Корень уравнения = " + x1);
            }
            if (d < 0)
            {

                d = Math.Sqrt((Math.Abs(d)));
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("Дискриминант меньше 0, решение на множестве комплексных чисел: " + "х1= " +x1 +"i, х2= "+x2+"i");
            }

        }
    }
}
