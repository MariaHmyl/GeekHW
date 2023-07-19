using System;

class Program
{
    static void Main(string[] args)
    {
        // Определение массива вещественных чисел
        double[] numbers = new double[] {1.2, 3.5, 6.7, 2.8, 5.0, 0.9, 7.6};

        // Находим максимальное значение в массиве
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Находим минимальное значение в массиве
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // Вычисляем разницу между максимальным и минимальным значением
        double difference = max - min;

        // Выводим разницу на экран
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);
    }
}