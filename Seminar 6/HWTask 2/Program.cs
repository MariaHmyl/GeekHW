using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        if (k1 == k2)
        {
            if (b1 == b2)
            {
                Console.WriteLine("Уравнения совпадают, пересечения бесконечно много");
            }
            else
            {
                Console.WriteLine("Уравнения параллельны, пересечений нет");
            }
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения: ({x}, {y})");
        }
    }
}