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

            // Использование оператора while (9)
            while (z > 0)
                {
                    z--;
                    Console.WriteLine(z);
                }

            // Использование оператора for (10)
            for (i = z; z > 0; z--)
                {
                    Console.WriteLine(z);
                }

                Console.ReadKey();
        }
    }
}
