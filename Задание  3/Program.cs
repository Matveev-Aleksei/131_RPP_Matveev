﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание__3
{
    class Program
    {
        static bool fun(int a, int b)
        {
            return (a * b >= 0);
        }
        static void Main(string[] args)
        {
           

            ////Задание 1 и 2
            //int[] sample;
            //sample = new int[100];

            //for (int i = 0; i < sample.Length; i++)
            //{
            //    sample[i] = i;
            //}
            //for (int i = 0; i < sample.Length; i++)
            //{
            //    Console.WriteLine(sample[i]);
            //}

            ////Задание 3
            //int[] sample1;
            //sample1 = new int[200];

            //for (int i = 100; i < sample1.Length; i++)
            //{
            //    sample1[i] = i;
            //}
            //for (int i = 100; i < sample1.Length; i++)
            //{
            //    Console.WriteLine(sample1[i]);
            //}

            ////Задание 4
            //int[] sample2;
            //sample2 = new int[5];

            //for (int i = -5; i < sample2.Length; i++)
            //{
            //    sample2[i] = i;
            //}
            //for (int i = -5; i < sample2.Length; i++)
            //{
            //    Console.WriteLine(sample2[i]);
            //}

            ////Задание 5
            //int[] sample5;
            //sample5 = new int[200];

            //for (int i = 0; i < sample5.Length; i++)
            //{
            //    sample5[i] = i;
            //}
            //for (int i = 0; i < sample5.Length; i++)
            //{
            //    if (sample5[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sample5[i]);
            //    }
            //}

            ////Задание 6
            //int[] sample6;
            //sample6 = new int[402];

            //for (int i = 100; i < sample6.Length; i++)
            //{
            //    sample6[i] = i;
            //}
            //for (int i = 100; i < sample6.Length; i++)
            //{
            //    if (sample6[i] % 2 == 1)
            //    {
            //        Console.WriteLine(sample6[i]);
            //    }
            //}


            ////Задание 7
            //double[] sample7;
            //sample7 = new double[100];

            //for (int i = 0; i < sample7.Length; i++)
            //{
            //    sample7[i] = i;
            //}
            //for (int i = 0; i < sample7.Length; i++)
            //{
            //    Console.WriteLine(sample7[i]);
            //}

            ////Задание 8
            //int[] sample8;
            //sample8 = new int[100];

            //for (int i = 0; i < sample8.Length; i++)
            //{
            //    sample8[i] = i;
            //    Console.WriteLine("0");
            //    Console.WriteLine("1");
            //}

            ////Задание 9
            //int[] sample9;
            //sample9 = new int[100];

            //for (int i = 0; i < sample9.Length; i++)
            //{
            //    sample9[i] = i;
            //    Console.WriteLine("1");
            //    Console.WriteLine("0");
            //}

            ////Задание 6
            //int[] sample10;
            //sample10 = new int[200];

            //for (int i = 100; i < sample10.Length; i--)
            //{
            //    if (i > 0)
            //    {
            //        sample10[i] = i;

            //        if (sample10[i] % 3 == 0)
            //        {
            //            Console.WriteLine(sample10[i]);
            //        }

            //    }
            //}


            ////Задание 26
            //int max = 50;
            //Random rnd = new Random();
            //int[] m = new int[10];
            //int s = 0;
            //for (int i = 0; i < m.Length; i++)
            //{
            //    m[i] = rnd.Next(max);

            //    if (m[i] % 2 == 0)
            //    {
            //        s = s + m[i];
            //    }
            //}
            //for (int i = 0; i < m.Length; i++)
            //{
            //    Console.WriteLine(m[i]);
            //}

            //Console.WriteLine("s = " + s);
            //Console.ReadKey();

            ////Задание 46
            //int max = 10;
            //Random rnd = new Random();
            //int s = 0;
            //int[] m = new int[10];
            //for (int i = 1; i < m.Length; i++)
            //{
            //    m[i] = rnd.Next(-max, max);
            //}
            //for (int i = 1; i < m.Length; i++)
            //{
            //    Console.WriteLine(m[i]);
            //}


            //for (int i = 1; i < m.Length; i++)
            //{

            //    if (m[i] *  m[i - 1] <0)    
            //     //   (fun(m[i], m[i - 1]) == false)
            //    {
            //        s++;
            //    }

            //}

            //Console.WriteLine("Сумма равна " + s);

            //Console.ReadKey();

            //int a = 11;
            //int b = 22;
            //int c = 33;
            //int g = 44;
            //int max = 50;
            //Random rnd = new Random();

            //int[] m = new int [50];
           

            //for (int i = 0; i < m.Length; i++)
            //{
            
            //m[i] = rnd.Next(max);
                
            //}
            //for (int i = 0; i < m.Length; i++)
            //{
            //    bool result = m[i] != a;
            //    result = result & m[i] != b;
            //    result = result & m[i] != c;
            //    result = result & m[i] != g;
            //    if (result)
            //    {
            //        Console.WriteLine(m[i]);
            //    }
            //}

            //Console.ReadKey();

            int max = 10;
            Random rnd = new Random();
            int[] m = new int[5];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = rnd.Next(max);
            }
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(m[i]);
                Console.Write("\t");
            }

            int[] n = new int[5];
            for (int i = 0; i < m.Length; i++)
            {
                n[i] = m[i];
                Console.Write(n[i]);
                Console.Write("\t");
            }
            
           
            Console.ReadKey();
            
    
        }
    }
}
