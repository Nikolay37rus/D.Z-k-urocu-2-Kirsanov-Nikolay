using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З_к_уроку_2_Кирсанов_Николай_задание_4 //  Реализовать метод проверки логина и пароля.
{
    
    

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Для входа введите логин и пароль");
            string login = "root";                                            
            string passwd = "GeekBrains";  
            
            int s = 3;                                                                       
            login = Console.ReadLine();          
            passwd = Console.ReadLine();          
           
            do
            {
                Console.WriteLine("Введите Ваш логин:");
                login = Console.ReadLine();
                Console.WriteLine("Введите Ваш пароль:");
                passwd = Console.ReadLine();
                if (login == "root")
                {
                    if ("GeekBrains" == passwd)
                    {
                        s = 0;
                        Console.WriteLine("Вход выполнен");
                    }
                    else
                    {
                        Console.WriteLine("Пароль введен не верно");
                    }
                }
                else Console.WriteLine("Логин введен не верно");
                --s;
            }
            while (s > 0);
            if (s < 0) Console.WriteLine("Вы превысили доступное количество попыток");


            Console.ReadKey();

        }
    }
}
