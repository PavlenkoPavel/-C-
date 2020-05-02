using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Введите кординату x1");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите кординату x2");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите кординату y1");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите кординату y2");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Расстояние между точками координат: {r} ");

        Console.ReadKey();
    }
    }
