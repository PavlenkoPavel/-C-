using System;


    class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваше имя");
        string name = Console.ReadLine();

        Console.WriteLine("Введите вашу фамилию");
        string lastname = Console.ReadLine();

        Console.WriteLine("Введите ваше возраст");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите ваш рост");
        int Height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите ваш вес");
        int Weight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Привет " + name + lastname + " я знаю тебе " + age + " лет" + " твой рост " + Height + " твой вес " + Weight);

        Console.WriteLine(String.Format("Привет {0} {1} я знаю тебе {2} лет, твой рост {3} твой вес {4} ", name,lastname,age,Height,Weight));

        Console.WriteLine($"Привет {name} {lastname} я знаю тебе {age} лет, твой рост {Height} твой вес {Weight}");
        Console.ReadKey();
    }
           
            
}
