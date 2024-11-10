using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. В одномерном массиве из 8 целых чисел с явной инициализацией обнулить значения трех элементов,
            //начиная с индекса, равного 1.

            //int[] ints = {1, 2, 3, 4, 5, 6, 7, 8 };

            //1 метод
            //for (int i = 1; i < 4; i++)
            //{
            //    ints[i] = 0;
            //}

            //2 метод
            //Array.Clear(ints, 1, 3);

            //вывод
            //foreach (int j in ints)
            //{
            //    Console.WriteLine(j);
            //}


            //Задача 2.Изменить размер одномерного массива.

            //int[] imas = new int[5];
            //Console.WriteLine("введите элементы массива:");
            //for (int i = 0; i < imas.Length; i++)
            //{
            //    Console.WriteLine($"введите {i+1} элемент массива");
            //    imas[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Resize(ref imas, 10);

            //Console.WriteLine("элементы массива:");
            //foreach (int j in imas)
            //{
            //    Console.WriteLine(j);
            //}


            //Задача 3. Найти индекс первого отрицательного элемента одномерного массива,
            //заполненного случайным образом в диапазоне от -5 до 5.

            Random rand = new Random();
            int[] randMas = new int[10];
            int x, i;
            for (i = 0; i < randMas.Length; i++)
            {
                x = rand.Next(-5,6);
                randMas[i] = x;
            }
            foreach (int element in randMas)
            {
                if (element < 0)
                {
                    Console.WriteLine(element);
                }
                
            }

        }
    }
}
