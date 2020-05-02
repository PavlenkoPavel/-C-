using System;


    class Program
    {
        static void Main()
        {
        int a = 5;     
        int b = 10;     
        int t = a;       
        a = b;          
        b = t;

        Console.WriteLine($"число а: {a} Число b: {b}");
        Console.ReadKey();

    }
}

