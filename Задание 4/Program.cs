using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  q;
            double x, slg, precos,b,c,fact;
            x = double.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            precos = 1;
            slg = q+1;
            b = 2;
            c = 2;


            for (int t=1;slg>q;t++)
            {
                fact = b;
                for (int i = 1; i < b; i++)
                {
                    fact *= i;
                }
                b += 2;
                slg = (Math.Pow(x, c))/fact;
                c += 2;
                if (t%2==0)
                {
                    precos += slg;
                }
                else
                {
                    precos -= slg;
                }
                
            }
            Console.WriteLine("cos(x)= " + precos);
        }
    }
}
