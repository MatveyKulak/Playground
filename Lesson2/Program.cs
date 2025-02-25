class Programm
{
    static void Main()
    {
        int a = 22;
        int b = 9;
        var sum = a + b;
        var dif = a - b;
        var mul = a * b;
        var div = a / b;
        Console.WriteLine("Summa: " + sum);
        Console.WriteLine("Raznost: " + dif);
        Console.WriteLine("Umnozenie: " + mul);
        Console.WriteLine("Delenie: " + div);

        var name = Console.ReadLine();

        Console.WriteLine("Hello, " + name);

        string str1 = "Hello";
        string str2 = str1;
        str1 = str1 + "World";

        System.Console.WriteLine(str1);

        string name1 = Console.ReadLine();
        if (name1 == "Matvey")
        {
            Console.WriteLine("Hello " + name1);
        }
        else
        {
            Console.WriteLine("Hello");
        }
    }
}