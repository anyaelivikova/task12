using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace практика_задача_12
{
    class Program
    {
        private static int size = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("«< задача 12 »>");

            int answer = 0;


            Console.Write("Введите количество элементов создаваемых массивов: ");
            size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Какой массив создавать?");
            Console.WriteLine(@"1. Упорядоченный по возрастанию 
2. Упорядоченный по убыванию 
3. Неупорядоченный");

            answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    array = CreateFirst();
                    Console.WriteLine("массив создан");
                    break;
                case 2:
                    array = CreateSecond();
                    Console.WriteLine("массив создан");
                    break;
                case 3:
                    array = CreateThird();
                    Console.WriteLine("массив создан");
                    break;
            }

            Console.WriteLine("Массив отсортирвоанный перемешиванием:");

            Stopwatch wat = new Stopwatch();


            SortArray.SortMix(array);
            Console.WriteLine("Массив отсортирвоанный методом простого выбора:");
            Console.ReadLine();
        }


        static int[] CreateFirst()
        {
            Random rand = new Random();

            int[] mas = new int[size];

            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(0, 100);
            }

            for (int j = 0; j < mas.Length - 1; j++)
            {
                for (int i = 0; i < size - 1; i++)
                {
                    if (mas[i] >= mas[i + 1])
                    {
                        int z = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = z;
                    }
                }
            }

            Console.WriteLine("Массив, упорядоченный по возрастанию:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(mas[i]);
            }

            return mas;
        }

        static int[] CreateSecond()
        {
            Random rand = new Random();
            int[] mas = new int[size];

            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(0, 100);
            }

            for (int j = 0; j < mas.Length - 1; j++)
            {
                for (int i = 0; i < size - 1; i++)
                {
                    if (mas[i] <= mas[i + 1])
                    {
                        int z = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = z;
                    }
                }
            }

            Console.WriteLine("Массив, упорядоченный по убыванию:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(mas[i]);
            }

            return mas;
        }

        static int[] CreateThird()
        {
            Random rand = new Random();
            int[] mas = new int[size];

            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next(0, 100);
            }
            Console.WriteLine("Массив никак не упорядоченный:");
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine(mas[i]);
            }

            return mas;
        }
    }
}
