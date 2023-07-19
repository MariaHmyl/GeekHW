using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до {0}:", N);
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("Число: {0}, Куб: {1}", i, i * i * i);
        }
    }
}