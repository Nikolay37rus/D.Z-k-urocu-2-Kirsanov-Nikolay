using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З_к_уроку_2_Кирсанов_Николай_задание_2 // Задание 2 Написать метод подсчета количества цифр числа.
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);

            Console.ReadKey();

            
        }

        
               
    }
}
