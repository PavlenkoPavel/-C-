using System;


    class Program
{
    static int MinNum()
    //Написать метод, возвращающий минимальное из трех чисел. Павленко
    {
        Console.WriteLine("Введите три целых числа: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        return min;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Наименьшее из трех введенных чисел равно {MinNum()}");
        Console.ReadLine();
    }
}
