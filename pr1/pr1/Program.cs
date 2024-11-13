using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Меню выбора:");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию \"+\"");
                Console.WriteLine("4. Выполнить операцию \"-\"");
                Console.WriteLine("5. Выполнить операцию \"*\"");
                Console.WriteLine("6. Выполнить операцию \"/\"");
                Console.WriteLine("7. Выход");

                Console.Write("Выберите пункт меню: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите значение A: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Введите значение B: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine($"A + B = {a + b}");
                        break;
                    case "4":
                        Console.WriteLine($"A - B = {a - b}");
                        break;
                    case "5":
                        Console.WriteLine($"A * B = {a * b}");
                        break;
                    case "6":
                        if (b != 0)
                        {
                            Console.WriteLine($"A / B = {a / b}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль.");
                        }
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
