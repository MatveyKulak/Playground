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
                Console.WriteLine("1. Выбор нейросети:");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var modelLibrary = new ModelLibrary();

                        var model1 = new ModelLibrary.Model
                        {
                            Name = "Neural Network 1",
                            Type = ModelType.NeuralNetwork,
                            DateCreated = DateTime.Now.AddMonths(-2),
                            Accuracy = 0.95
                        };

                        var model2 = new ModelLibrary.Model
                        {
                            Name = "Decision Tree 1",
                            Type = ModelType.DecisionTree,
                            DateCreated = DateTime.Now.AddMonths(-1),
                            Accuracy = 0.85
                        };

                        var model3 = new ModelLibrary.Model
                        {
                            Name = "SVM 1",
                            Type = ModelType.SVM,
                            DateCreated = DateTime.Now.AddMonths(-3),
                            Accuracy = 0.92
                        };

                        modelLibrary.AddModel(model1);
                        modelLibrary.AddModel(model2);
                        modelLibrary.AddModel(model3);

                        var allModels = modelLibrary.GetModels();
                        Console.WriteLine("All Models:");

                        foreach (var model in allModels)
                        {
                            Console.WriteLine(model);
                        }

                        var highAccuracyModels = allModels.GetModelsAbove(0.90);
                        Console.WriteLine("\nModels with Accuracy > 90%:");

                        foreach (var model in highAccuracyModels)
                        {
                            Console.WriteLine(model);
                        }
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
