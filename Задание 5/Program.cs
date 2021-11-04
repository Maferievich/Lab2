using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            
            double N,X,Y,Z,N1,x;
            N = double.Parse(Console.ReadLine());
            if (N < 0)
                Console.WriteLine("Это не натуральное число");
            else
            {


                x = 0;

                for (double i = 1; i < N; i++)
                {
                    for (double o = 1; o < N; o++)
                    {

                        for (double p = 1; p < N; p++)
                        {
                            X = i * i * i;
                            Y = o * o * o;
                            Z = p * p * p;
                            N1 = X + Y + Z;

                            if (N1 == N)
                            {
                                Console.WriteLine("кубы числа N= " + X + " " + Y + " " + Z);
                                x = 1;

                            }
                        }

                    }

                }
                if (x != 1)
                    Console.Write("No such combinations!");

            }
        }
    }
}
