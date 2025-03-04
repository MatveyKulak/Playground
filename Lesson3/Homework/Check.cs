public class Check
{
    public void Run1()
    {
        Console.Write("Введите целое число: ");
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 || n >= 0 ? "True" : "No");
    }
}
