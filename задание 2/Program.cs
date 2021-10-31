using System;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, b,t;
            int a;
            Console.Write("Введите кол-во: ");
            a = int.Parse(Console.ReadLine());
            pi = 4;
            b = 3;
            t = 1;
            if (a <= 1)
            {
                Console.WriteLine("П = " + pi);
            }
            else
            {
                for (int c = 1; c <= a; c++) 
                {
                    if ((c % 2) == 0)
                    {
                        t += (1 / b);
                        b += 2;
                    }
                    else
                    {
                        t -= (1 / b);
                        b += 2;
                    }
                }
                pi = t * 4;
                Console.WriteLine("П = " + pi);
 
            }
        }
    }
}
