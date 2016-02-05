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
            int x;
            int y;
            int i;
            x = 7;
            y = 9;
            int z = y + x;
            Console.WriteLine(z);

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

            //point:
            //    if (z > 0)
            //    {
            //        z--;
            //        Console.WriteLine(z);
            //        goto point;
            //    }

            //while (z > 0)
            //{
            //    z--;
            //    Console.WriteLine(z);
            //}

            for (i = z; z > 0; z--)
            {
                Console.WriteLine(z);
            }

             //   Console.ReadKey();
        }
    }
}
