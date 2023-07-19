using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Введите число B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        
        double result = Power(A, B);
        
        Console.WriteLine($"Результат: {result}");
    }

    static double Power(double a, int b)
    {
        double result = 1;

        for (int i = 0; i < b; i++)
        {
            result *= a;
        }

        return result;
    }
}