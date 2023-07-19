using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел (M): ");
        int M = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел больше нуля: " + count);
    }
}