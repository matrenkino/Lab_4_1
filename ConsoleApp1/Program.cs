using System;

class Program
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
