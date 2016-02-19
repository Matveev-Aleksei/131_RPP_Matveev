using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_лаб_работа__1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных (1)
            int x;
            int y;
            int i;
            int max = 8;
            Random rnd1 = new Random();
            int number = rnd1.Next(max);


            int b = 0;

            // Присваивание значений (2)
            x = 7;
            y = 9;

            // Объявление и инициализация переменной z (3)
            int z = y + x;

            // Вывод на экран z (4)
            Console.WriteLine(z);

            // Проверка и выполнение условий (5)
            if (z > 0)
                {
                    Console.WriteLine("z положительное ");
                }
                else
                {
                    Console.WriteLine("z отрицательнлое ");
                }

            if (z % 2 == 0)
                {
                    Console.WriteLine("z четное");
                }
                else 
                {
                    Console.WriteLine("z не четное");
                }
            if (z % 5 == 0)
                {
                    Console.WriteLine("Кратно 5 ");
                }
                else
                {
                    Console.WriteLine("Не кратно 5 ");

                }
            
            // Использование оператора goto (7)
            point:
                if (z > 0)
                {
                    z--;
                    Console.WriteLine(z);
                    goto point;
                }

            // Использование оператора goto (7)
            point1:
            {
                z--;
                Console.WriteLine(z);
            }
            if (z > 0)
            goto point1;
            

            // Использование оператора while (9)
            while (z > 0)
            {
                z--;
                Console.WriteLine(z);
            }
            // Использование оператора do while (9)
            do
            {
                  z--;
                Console.WriteLine(z);
            }
            while(z > 0);

            // Использование оператора for (10)
            for (i = z; z > 0; z--)
            {
                Console.WriteLine(z);
            }

            // Угадай число 
            do
            {
                Console.WriteLine("Введите ваше число от 0 до 8");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a > number)
                {
                    Console.WriteLine(a + " - Больше загаданного числа ");
                }
                else
                {
                    if (a < number)
                    {
                        Console.WriteLine("Загаданное число больше " + a);
                    }
                    else
                    {
                        Console.WriteLine("Поздравляем... Вы угадали " + " Загаданное число  " + number);
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                b++;
            }
            while (b < 3);
            Console.WriteLine("Не угадал, попробуй еще раз. " + "Загаданное число " + number);
            Console.ReadKey();
            

             Console.ReadKey();
        }
    }
}
