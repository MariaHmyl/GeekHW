using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();
        
        int sum = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            int digit;
            if (int.TryParse(userInput[i].ToString(), out digit))
            {
                sum += digit;
            }
            else
            {
                Console.WriteLine("Введено некорректное число.");
                return;
            }
        }
        
        Console.WriteLine("Сумма цифр в числе: " + sum);
    }
}
