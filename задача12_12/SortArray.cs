using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_задача_12
{
    class SortArray
    {
        public static void SortMix(int[] mas)
        {
            int b = 0;
            int left = 0;//Левая граница
            int right = mas.Length - 1;//Правая граница
            while (left < right)
            {
                for (int i = left; i < right; i++)//Слева направо...
                {
                    if (mas[i] > mas[i + 1])
                    {
                        b = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = b;
                        b = i;
                    }
                }
                right = b;//Сохраним последнюю перестановку как границу
                if (left >= right) break;//Если границы сошлись выходим
                for (int i = right; i > left; i--)//Справа налево...
                {
                    if (mas[i - 1] > mas[i])
                    {
                        b = mas[i];
                        mas[i] = mas[i - 1];
                        mas[i - 1] = b;
                        b = i;
                    }
                }
                left = b;//Сохраним последнюю перестановку как границу
            }
            printarray(mas);
        }
        public static void SimpleSort(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            printarray(mas);
        }
        public static void printarray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }
}
