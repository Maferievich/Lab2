using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,d;
            a = 0;
            b = 1;
            c = 0;
            d = 0;
            while (c<10000)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
                if ((c > 999)&(c<10000))
                    d++;
            }
            Console.WriteLine("4-х значных числел в ряде Фибоначчи = " + d);
        }
    }
}
