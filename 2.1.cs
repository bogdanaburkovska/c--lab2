using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть прізвище одногрупника:");
        string прізвище = Console.ReadLine();

        switch (прізвище)
        {
            case "Соколовський":
                Console.WriteLine("Ім'я: Степан");
                break;
            case "Костенюк":
                Console.WriteLine("Ім'я: Любомир");
                break;
            case "Дирда":
                Console.WriteLine("Ім'я: Михайло");
                break;
            case "Лабік":
                Console.WriteLine("Ім'я: Валентин");
                break;
            case "Мігалуш":
                Console.WriteLine("Ім'я: Ігор");
                break;
            case "Франк":
                Console.WriteLine("Ім'я: Діана");
                break;
            case "Мельницький":
                Console.WriteLine("Ім'я: Майк");
                break;
            case "Ігнатюк":
                Console.WriteLine("Ім'я: Іван");
                break;
            default:
                Console.WriteLine("Такого прізвища немає в списку.");
                break;
        }
    }
}
