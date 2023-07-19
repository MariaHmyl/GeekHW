using System;

class Program
{
    static void Main()
    {
        int[] array = new int[100];  // размер массива может быть любым
        Random random = new Random();
        int evenCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);  // генерация случайного трехзначного числа

            if (array[i] % 2 == 0)
            {
                evenCount++;  // подсчет четных чисел
            }
        }

        Console.WriteLine("Массив заполнен случайными трехзначными числами.");
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }
}
