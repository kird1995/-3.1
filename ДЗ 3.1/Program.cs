﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method_1();
            Method_2();
            Method_3();
            int min = 1;
            int max = 2;
            Method_4(min, max);
        }
        public static void Menhod_4(int min, int max)
        {
            Console.WriteLine("\nВывод целых чисел по заданному диапазону.");
            Console.Write("Введите целое значение диапазона от: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Введите целое значение диапазона до: ");
            max = int.Parse(Console.ReadLine());
            Random random = new Random();
            int myInt = 1;
            if (min > max)
            {
                double pi = Math.PI;
                Console.WriteLine(pi);
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.Write("Выполнение условия: ");
                    Console.Write(random.Next(min, max));
                    break;
                }
                while (myInt == min || myInt < max);   
                Console.Write(" ");                     
                Console.Write(random.Next(min, max));
            }
            Console.ReadKey();
        }
        private static void Method_3()
        {
            int k;
            Console.WriteLine("Вывод целых положительных чисел кратных 3-м и 5-и до числа, которое укажет пользователь.");
            Console.Write("Введите целое положительное исло: ");
            k = int.Parse(Console.ReadLine());
            if (k > 0)
            {
                Console.Write("Выполнение условия: ");
                for (int i = 0; i < k; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write(" " + i);
                        Thread.Sleep(20);
                    }
                    continue;
                }
            }
            Console.WriteLine("\n Операция завершена!");
            return;
        }
        private static void Method_2()
        {
            Console.WriteLine("Вывести на консоль числа от 10 до 1:");
            int j = 11;
            while (j > 1)
            {
                j--;
                Console.Write(" " + j);
                Thread.Sleep(120);
            }
            Console.WriteLine("\n");
            return;
        }
        private static void Method_1()
        {
            Console.WriteLine("Вывести на консоль числа от 0 до 9:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + i);
                Thread.Sleep(120);
            }
            Console.WriteLine("\n");
            return;
        }


    }

}
