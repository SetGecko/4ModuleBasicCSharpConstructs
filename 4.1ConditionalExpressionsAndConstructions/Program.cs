using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1ConditionalExpressionsAndConstructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Булево сравнение
            Console.WriteLine("Переменная мои яблоки = 5, его яблоки = 6, его персики = 5");
            Console.WriteLine("Будет отображено булево решение по условию:");
            Console.WriteLine("(Мои яблоки не равно его персикам) и (Мои яблоки меньше его яблок)");
            var myApples = 5;
            var hisApples = 6;
            var hisPearers = 5;
            var result = (myApples != hisPearers) & (myApples < hisApples);
            Console.WriteLine("Условие выше имеет результат: " + result);

            // Булево выяснение зима ли сейчас
            int currentDayInYear = 293;
            bool isLeapYear = false;

            bool isWinter =
                (!isLeapYear & (currentDayInYear >= 335 | currentDayInYear <= 59))
                |
                (isLeapYear & (currentDayInYear >= 336 | currentDayInYear <= 60));
            Console.WriteLine("Текущее время зима? " + isWinter);

            // Запишите код, который проверяет следующее выражение:
            // переменная A типа string не равна переменной B типа string
            // string A;
            // string B;
            // bool C = (A != B);

            // Булево сравнение
            var a = 5 + 6; // 11
            var b = 7 + 8; // 15
            Console.WriteLine("a = {0}, b = {1}",a,b);
            Console.WriteLine("Сравним, С по условию: (b не равно а) и (b > (а + 1))");
            var c = (b != a) & (b > a + 1);
            Console.WriteLine(c);
            Console.WriteLine("Сравним, D по условию: (b не равно а) или (b > (а + 1))");
            var d = (b != a) && (b > a + 1);
            Console.WriteLine(d);
            Console.WriteLine();

            Console.WriteLine("Теперь немного другое условие.");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Сравним, E по условию: (b = а) и (b > (а + 1))");
            var e = (b == a) & (b > a + 1);
            Console.WriteLine(e);
            Console.WriteLine("Сравним, F по условию: (b = а) или (b > (а + 1))");
            var f = (b != a) && (b > a + 1);
            Console.WriteLine(d);
            Console.WriteLine();

            // Отрицание
            var inv = true;
            var result2 = !inv;
            Console.WriteLine(result2);
            Console.WriteLine();

            Console.WriteLine("Условия");
            // Условия
            var A = 6;
            var B = 7;

            if (A == B)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");

                if (B < 10)
                {
                    Console.WriteLine("Значение B = {0}", B);
                }
            }

            // Условия + расцветка текста
            Console.WriteLine("Введите ваш любимый цвет на английском маленькими буквами: ");
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш любимый цвет красный!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш любимый цвет зелёный!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш любимый цвет не бирюзовый, но пусть будет так :)))");
            }

            // Условия со Switch case с теми же цветами
            Console.WriteLine("Введите ваш любимый цвет на английском маленькими буквами: ");
            var color2 = Console.ReadLine();

            switch(color2)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет красный!");
                break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ваш любимый цвет зелёный!");
                break;
                    default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ваш любимый цвет не бирюзовый, но пусть будет так :)))");
                break;
            }

            Console.ReadKey();
        }
    }
}
