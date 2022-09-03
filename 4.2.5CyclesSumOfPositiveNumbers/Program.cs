using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._5CyclesSumOfPositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Для выхода из программы введите 0");

            while(true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                sum += number;
            }
            Console.WriteLine("Итоговая сумма всех положительных чисел: {0}", sum);

            Console.ReadKey();
        }
    }
}
