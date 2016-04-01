using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] Arr = new int[7, 5];

            //Random ran = new Random();

            //for (int i = 0; i < 7; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Arr[i, j] = ran.Next(1, 15);
            //            Console.Write("{0}\t", Arr[i, j]);
            //        }

            //    }
            //    Console.WriteLine();
            //}

            int[,] Arr1 = new int[5, 5];

            Random ran1 = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr1[i, j] = ran1.Next(1, 15);
                    Console.Write("{0}\t", Arr1[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            int zn = 4;
            for (int i = 0; i < 5; i++)
            {
                bool f = true;
                for (int j = 0; j < 5; j++)
                {
                    if (Arr1[i, j] == 0)
                    {
                        zn = i;
                        f = false;
                        break;
                    }
                }
                if (!f)
                {
                    break;
                }
            }

     
            Console.WriteLine("Меняем местами 0 строку и {0} строку", zn);

            int b = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int zm = Arr1[0, i];
                    b = Arr1[0, i];
                    Arr1[0, i] = Arr1[zn, i];
                    Arr1[zn, i] = b;
                }
            }

          
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", Arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}