using System;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Введите число A:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите натуральное число B:");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < b; i++) 
        {
            result *= a;
        }

        Console.WriteLine("{0} в степени {1} равно {2}", a, b, result);
    }
}