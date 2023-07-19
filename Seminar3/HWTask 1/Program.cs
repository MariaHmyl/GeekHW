using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadLine();

        if (IsPalindrome(number))
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }

    static bool IsPalindrome(string number)
    {
        // Проверка, что число пятизначное
        if (number.Length != 5)
        {
            return false;
        }

        for (int i = 0; i < number.Length / 2; i++)
        {
            if (number[i] != number[number.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}