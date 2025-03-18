namespace StartMenu
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Playground main menu");
            Console.WriteLine("1.Lesson1");
            Console.WriteLine("2.Lesson2");
            Console.WriteLine("3.Lesson3");
            Console.WriteLine("4.Lesson4");
            Console.WriteLine("5.Lesson5");
            Console.WriteLine("6.Lesson6");
            Console.WriteLine("7.Lesson7");
            Console.WriteLine("8.Lesson8");
            Console.WriteLine("9.Lesson9");
            Console.WriteLine("10.Lesson10");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Lesson1.Program.Main();
                    break;
                case "2":
                    Lesson2.Program.Main();
                    break;
                case "3":
                    Lesson3.Program.Main();
                    break;
                case "4":
                    Lesson4.Program.Main();
                    break;
                case "5":
                    Lesson5.Program.Main();
                    break;
                case "6":
                    Lesson6.Program.Main();
                    break;
                case "7":
                    Lesson7.Program.Main();
                    break;
                case "8":
                    Lesson8.Program.Main();
                    break;
                case "9":
                    Lesson9.Program.Main();
                    break;
                case "10":
                    Lesson10.Program.Main();
                    break;
                default:
                    break;
            }
        }
    }
}
