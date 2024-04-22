using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть розмірність матриці:");
        Console.Write("Кількість рядків (n): ");
        int n = ReadIntegerInput();
        Console.Write("Кількість стовпців (m): ");
        int m = ReadIntegerInput();

        // Створення матриці та заповнення її даними
        int[,] matrix = new int[n, m];
        Random rnd = new Random();
        Console.WriteLine("Матриця A:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rnd.Next(-100, 101); // Генеруємо випадкові значення з відрізка [-100; 100]
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Введіть координати першого елемента:");
        Console.Write("Рядок: ");
        int x1 = ReadIntegerInput();
        Console.Write("Стовпець: ");
        int y1 = ReadIntegerInput();

        Console.WriteLine("Введіть координати другого елемента:");
        Console.Write("Рядок: ");
        int x2 = ReadIntegerInput();
        Console.Write("Стовпець: ");
        int y2 = ReadIntegerInput();

        // Перевірка чи введені координати не виходять за межі матриці
        if (x1 < 0 || x1 >= n || y1 < 0 || y1 >= m ||
            x2 < 0 || x2 >= n || y2 < 0 || y2 >= m)
        {
            Console.WriteLine("Некоректні координати елементів матриці.");
            return;
        }

        // Знаходження максимального значення з вказаних елементів
        int maxValue = Math.Max(matrix[x1, y1], matrix[x2, y2]);
        Console.WriteLine($"Максимальне значення з вказаних елементів: {maxValue}");
    }

    // Метод для безпечного зчитування цілих чисел з консолі
    static int ReadIntegerInput()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Введіть коректне ціле число.");
        }
        return number;
    }
}
