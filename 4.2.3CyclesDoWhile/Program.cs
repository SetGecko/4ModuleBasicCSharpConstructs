using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._3CyclesDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здесь могла быть ваша реклама :)");
            Console.WriteLine("Цикл Do While");
            int i = 0;

            do
            {
                Console.WriteLine("Проход {0}", i);
                Console.WriteLine("Введите ваш любимый цвет английскими строковыми буквами: ");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет Красный!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет Зелёный!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет Бирюзовый!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет Жёлтый!");
                        break;
                }
                i++;
            } while (i < 5);

            Console.ReadKey();
        }
    }
}
