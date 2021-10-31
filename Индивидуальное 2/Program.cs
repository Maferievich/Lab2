using System;

namespace Индивидуальное_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            for(int i=1; i <=10000; i++)
            {
                if(10000%i==0)
                {
                    a = 10000 / i;
                    if (a % 2 == 1)
                        Console.WriteLine(a);

                }
            }
        }
    }
}
