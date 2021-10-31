using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введие число от 0 до 100: ");
            int a;
            a = int.Parse(Console.ReadLine());
            if ((a >= 0)&(a<=100))
            {
                if ((a >= 0) & (a < 15))
                {
                    if (a % 100 == 1)
                        Console.WriteLine(a + " год");
                    
                    else
                        Console.WriteLine(a + " лет");
                }


                    if (a >= 15)
                    {


                        if (a % 10 == 1)
                            Console.WriteLine(a + " год");
                        if ((a % 10 > 1) & (a % 10 < 5))
                            Console.WriteLine(a + " года");
                        if ((a%10==0)&(a%10>=5))
                            Console.WriteLine(a + " лет");
                    }
                
            }
            else
                Console.WriteLine("меньше 0 тебе не может быть");
        }
    }
}
