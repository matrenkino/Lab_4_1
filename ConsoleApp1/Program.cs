using System;
using LAB1;
using LAB2;
using LAB3;
using LAB4;

namespace Calculator
{
    class ProgramCal
    {
        static void Main()
        {
            char choice;
            double a = 0;
            double b = 0;

            do
            {
                Console.WriteLine("Меню выбора:");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Сложить A и B");
                Console.WriteLine("4. Вычесть B из A");
                Console.WriteLine("5. Умножить A на B");
                Console.WriteLine("6. Разделить A на B");
                Console.WriteLine("7. Выйти из программы");

                Console.Write("Введите номер операции: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        Console.Write("Введите значение A: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine($"A = {a}");
                        break;
                    case '2':
                        Console.Write("Введите значение B: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"B = {b}");
                        break;
                    case '3':
                        Console.WriteLine($"Сумма A и B = {a + b}");
                        break;
                    case '4':
                        Console.WriteLine($"Разность A и B = {a - b}");
                        break;
                    case '5':
                        Console.WriteLine($"Произведение A и B = {a * b}");
                        break;
                    case '6':
                        if (b != 0)
                        {
                            Console.WriteLine($"Частное A и B = {a / b}");
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                        }
                        break;
                    case '7':
                        Console.WriteLine("Программа завершена.");
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор. Пожалуйста, выберите существующий пункт меню.");
                        break;
                }
                Console.WriteLine();
            } while (choice != '7');
        }
    }
}


