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
            Console.WriteLine("11.Lesson11");
            Console.WriteLine("12.Lesson12");
            Console.WriteLine("13.Lesson13");
            Console.WriteLine("14.Lesson14");
            Console.WriteLine("15.Lesson15");
            Console.WriteLine("16.Lesson16");
            Console.WriteLine("17.Lesson17");
            Console.WriteLine("18.Lesson18");

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
                case "11":
                    Lesson11.Program.Main();
                    break;
                case "12":
                    Lesson12.Program.Main();
                    break;
                case "13":
                    Lesson13.Program.Main();
                    break;
                case "14":
                    Lesson14.Program.Main();
                    break;
                case "15":
                    Lesson15.Program.Main();
                    break;
                case "16":
                    Lesson16.Program.Main();
                    break;
                case "17":
                    Lesson17.Program.Main();
                    break;
                case "18":
                    Lesson18.Program.Main();
                    break;
                default:
                    break;
            }
        }
    }
}
