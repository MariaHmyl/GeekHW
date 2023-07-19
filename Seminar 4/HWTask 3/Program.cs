using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание массива на восемь элементов
        int[] array = new int[8] {1, 2, 3, 4, 5, 6, 7, 8};

        // Вывод элементов массива на экран
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element at index {0}: {1}", i, array[i]);
        }
    }
}
