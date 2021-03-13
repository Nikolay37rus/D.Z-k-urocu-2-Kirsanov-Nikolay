using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З_к_уроку_2_Кирсанов_Николай_задание_3 // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            while (true)
            {
                int a = Convert.ToInt16(Console.ReadLine());

                if (a != 0)
                {
                    if (a % 2 == 0)
                    { }
                    else
                        b += a;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(b);


            Console.ReadKey();
        }
    }
}
