using System;

    class Program
//Написать метод подсчета количества цифр числа. Павленко
{
    static void Main()
    {
        Console.Write("Число: ");
        Console.WriteLine("Количество знаков: " + count(Console.ReadLine()));
        Console.ReadKey();
    }

    static int count(string s)
    {
        return s.Length;
    }
}
 

