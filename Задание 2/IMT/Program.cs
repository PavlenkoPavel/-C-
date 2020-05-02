using System;
using System.Runtime.InteropServices;

class Program
    {
        static void Main()
        {
        Console.WriteLine("Введите ваш вес");
        double m = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите ваш рост");
        double h = Convert.ToDouble(Console.ReadLine());

        double IMT =  m / (h * h);

        Console.WriteLine($"Ваш индекс массы тела:  {IMT:f2} " );
        Console.ReadKey();

    }
    }
