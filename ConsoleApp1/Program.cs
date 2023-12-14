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
            Console.WriteLine("3. Сложить A и B");
            Console.WriteLine("7. Выйти из программы");

            Console.Write("Введите номер операции: ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '3':
                    Console.WriteLine($"Сумма A и B = {a + b}");
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
