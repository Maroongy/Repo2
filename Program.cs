using System;

class Program
{
    static void Main()
    {
        IsLeapYear(2024);  // Вывод: 2024 год високосный
        IsLeapYear(1900);  // Вывод: 1900 год не високосный
        IsLeapYear(2000);  // Вывод: 2000 год високосный
    }

    static void IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} год високосный");
        }
        else
        {
            Console.WriteLine($"{year} год не високосный");
        }
    }
}

