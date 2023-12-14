using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваше имя:");
        string userName = Console.ReadLine();

        Console.WriteLine($"Привет, {userName}!");
    }
}