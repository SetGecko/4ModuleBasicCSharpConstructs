using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
            int minValue = 100000,
            minIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Наименьший элемент массива имеет индекс {0}, значение этого элемента = {1}", minIndex, numbers[minIndex]);

            Console.WriteLine("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам: ");
            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length -1]);
            Console.WriteLine("Первая буква вашего имени: {0}", name[0]);

            Console.WriteLine("Введите ваше имя: ");
            var name2 = Console.ReadLine();
            for (int i = name2.Length - 1; i >= 0; i--)
            {
                Console.Write(name2[i] + " ");
            }

            Console.WriteLine("________");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("________");
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine("________");

            var arr2 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum2 = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                sum2 += arr2[i];
            }

            Console.WriteLine(sum2);

            Console.WriteLine("________");
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadKey();            
        }
    }
}