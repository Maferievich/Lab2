using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введие число от 0 до 100: ");
            int i;
            i = int.Parse(Console.ReadLine());
            
            
                if ((i >= 0) & (i <= 100))
                {
                    if ((i >= 5) & (i < 15))
                    {
                        if (i % 100 == 1)
                            Console.WriteLine(i + " год");

                        else
                            Console.WriteLine(i + " лет");
                    }


                    if ((i >= 15) | (i < 5))
                    {


                        if (i % 10 == 1)
                            Console.WriteLine(i + " год");
                        if ((i % 10 > 1) & (i % 10 < 5))
                            Console.WriteLine(i + " года");
                        if ((i % 10 == 0) | (i % 10 >= 5))
                            Console.WriteLine(i + " лет");
                    }

                }
            
        }
    }
}
