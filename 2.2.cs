using System;

class Program
{
    static void Main()
    {
        double a = 3; // Початок інтервалу
        double b = 6; // Кінець інтервалу
        double dx = 0.05; // Крок зміни значень аргументу x

        // Виведення заголовків таблиці
        Console.WriteLine("x\t|\ty");
        Console.WriteLine("-----------------------");

        // Цикл для обчислення значень функції та їх виведення
        for (double x = a; x <= b; x += dx)
        {
            double y = CalculateFunction(x);
            Console.WriteLine($"{x}\t|\t{y}");
        }

        Console.ReadLine();
    }

    // Метод для обчислення значення функції
    static double CalculateFunction(double x)
    {
        // Перевірка на виняткові ситуації
        if (x < 0)
        {
            // Якщо x менше за нуль, викинути виключення
            throw new ArgumentException("Аргумент x має бути не менше нуля.");
        }

        // Обчислення значення функції
        double y = Math.Exp(Math.Sqrt(2 * x)) * Math.Pow(x, 2);
        return y;
    }
}
