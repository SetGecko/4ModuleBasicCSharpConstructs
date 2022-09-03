using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._4CyclesWhileTrue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Введите ваш любимый цвет английскими строковыми буквами: ");
                Console.WriteLine("Проход {0}", i);

                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен :(");
                    break;
                }
                switch (text)
                { }
                i++;
            }
                Console.ReadKey();
        }
    }
}
