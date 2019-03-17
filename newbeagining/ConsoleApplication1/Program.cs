using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();


            //var z = QuadEq();

            /* int[] numbers = new int[] { 1, 2, 3, 4, 5  };
             for (int i = 0; i < numbers.Length; i++)
             { Console.WriteLine(numbers[i]); }
             Console.ReadKey();*/
        }

        public static void MainMenu()
        {
            Console.WriteLine("\n\n\n\t\tДобрый день!\n\n\tДобро пожаловать в программу расчёта корней квадратного уравнения!\n\nВведите одну из опции:\n");
            Console.WriteLine("1. Расчитать квадратные корни уравнеия");
            Console.WriteLine("2. Посмотреть информацию о программе");
            Console.WriteLine("3. Куда можно заданатить");
            Console.WriteLine("4. Запустить тесты");
            Console.WriteLine("5. Выйти");
            String MenuOption = Console.ReadLine();

            switch (MenuOption)
            {
                case "1":
                    QuadEq();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("\n\n\nПрограмма для расчёта квадратного уравнения\n\n\n");
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "3":
                    Console.WriteLine("\n\n\nПока никуда :(\n\n\n");
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "4":
                    Console.WriteLine("\n\n\nПока нереализованно\n\n\n");
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "5":
                    Console.WriteLine("\n\n\nЖелаю вам удачи!\n\n\n");
                    break;
            }
        }

        public static List<double> QuadEq()
        {

            double a, b, c, D, x1, x2 = 0;
            Console.WriteLine("\n\n\nВведите знгачение переменной a= ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите знгачение переменной b= ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите знгачение переменной c= ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Квадратное уравнение:\n {a}*x^2 + {b}*x + {c} = 0");
            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Дискриминант D = {D}");

            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D) / 2 * a);
                x2 = (-b - Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"Корни уравнения равны\n x1 = {x1}\n x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Увы, но действительных корней, у данного уравнения нет...\n \n\n\n\t\t...Сожалею..."); Console.ReadKey();
            }
            var z = (double)(a == 0 ? 1 : 2);
            Console.ReadKey();
            MainMenu();
            return null;
        }
    }
}