using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть розмірність масиву n:");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Некоректне значення. Будь ласка, введіть ціле додатнє число для розмірності масиву:");
        }

        int[] array = new int[n];
        Console.WriteLine("Введіть {0} цілих чисел:", n);
        for (int i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть ціле число:");
            }
        }

        // Знайдемо мінімальний елемент масиву
        int min = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("Мінімальний елемент масиву: " + min);

        // Знайдемо суму елементів між першим і другим від'ємними елементами
        int sum = 0;
        bool foundFirstNegative = false;
        for (int i = 0; i < n; i++)
        {
            if (array[i] < 0)
            {
                if (foundFirstNegative)
                {
                    break;
                }
                foundFirstNegative = true;
                continue;
            }

            if (foundFirstNegative)
            {
                sum += array[i];
            }
        }
        Console.WriteLine("Сума елементів масиву, розташованих між першим і другим від'ємними елементами: " + sum);
    }
}

