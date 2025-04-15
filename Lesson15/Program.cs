using Lesson15.AIManager;

namespace Lesson15
{
    public class Program
    {
        public static void Main()
        {

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Выберите тему для отображения информации:");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var modelLibrary = new ModelLibrary();

                        var model = new ModelLibrary.Model
                        {
                            Name = "Neural Network 1",
                            Type = ModelType.NeuralNetwork,
                            DateCreated = DateTime.Now.AddMonths(-2),
                            Accuracy = 0.95
                        };

                        modelLibrary.AddModel(model);

                        var allModels = modelLibrary.GetModels();

                        foreach (var model in allModels)
                        {
                            Console.WriteLine(model);
                        }

                        var result = allModels.GetModelsAbove(0.90);
                        break;
                    case "10":
                        exit = true;
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }
    }
}
