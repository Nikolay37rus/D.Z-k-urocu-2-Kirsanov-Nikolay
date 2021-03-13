using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З_к_уроку_2_Кирсанов_Николай_задание_1 // Задание 1 Написать метод, возвращающий минимальное из трех чисел.
{
    class Program
    {
        static int MinNum() 
        {
            Console.WriteLine("Введите три целых числа: ");
            Console.WriteLine("Введите первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число ");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Наименьшее из трех чисел равно {MinNum()}");

            Console.ReadKey();
        }
    }
}
