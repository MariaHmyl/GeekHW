using System;

class Program
{
    static void Main()
    {
        // Инициализируем новый массив
        int[] array = new int[10];

        // Создаем объект класса Random для генерации случайных чисел
        Random random = new Random();

        // Заполняем массив случайными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100); // Генерация случайного числа от 1 до 100
            Console.Write(array[i] + " "); // Выводим элементы массива для наглядности
        }

        Console.WriteLine();

        // Находим сумму чисел на нечетных позициях
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0) // Проверка на нечетность позиции
            {
                sum += array[i];
            }
        }

        Console.WriteLine("Сумма чисел на нечетных позициях: " + sum);
    }
}