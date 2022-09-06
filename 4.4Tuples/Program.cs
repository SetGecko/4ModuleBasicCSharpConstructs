using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4._4Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Просто кошачий кортеж
            var catAnketa = (name: "Жужа", Age: 3);
            Console.WriteLine("Мою кошку зовут {0}", catAnketa.name);
            Console.WriteLine("Ей {0} года", catAnketa.Age);
            Console.WriteLine("-----");
            //Кортеж для анкеты с объявлением имён кортежа без значений
            (string name2, int age2) anketa;
            Console.WriteLine("Введите ваш имя: ");
            anketa.name2 = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            anketa.age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0}, вам {1} лет", anketa.name2, anketa.age2);
            Console.WriteLine("-----");
            //Объявление кортежа без имени, но только если мы сразу вводим значения
            //дальше ими оперируем как обычными переменными
            var (name, age) = ("Алексей", 35);
            Console.WriteLine("Меня зовут {0}, мне {1} лет", name, age);
            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0} и вам {1} лет.", name, age);
            Console.WriteLine("-----");
            Console.WriteLine("-----");
            Console.WriteLine("-----");
            // Задача 4.5
            Console.WriteLine("Задание 4.4.5");
            //Дан следующий кортеж:
            //(string Name, string Type, double Age, int NameCount) Pet;
            //Name — имя питомца;
            //Type — тип питомца: собака, рыбка, хомячок;
            //Age — возраст питомца;
            //NameCount — длина имени питомца.
            //Заполните данный кортеж значениями аналогично примерам, разобранным в модуле выше.
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Введите имя вашего питомца:");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Укажите вид вашего питомца");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Сколько вашему питомцу лет?");
            Pet.Age = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Вашего питомца зовут {0}", Pet.Name);
            Console.WriteLine("Его вид {0}", Pet.Type);
            Console.WriteLine("Питомцу {0} год/а(лет)", Pet.Age);
            Console.WriteLine("В имени вашего питомца {0} символ(а)ов", Pet.NameCount);

            Console.ReadKey();
        }
    }
}
