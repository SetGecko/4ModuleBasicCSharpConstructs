using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Цикл {0}", i);
                Console.WriteLine("Введите любимый цвет на английском с маленькой буквы: ");
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
            }
            
            Console.ReadKey();
        }
    }
}
