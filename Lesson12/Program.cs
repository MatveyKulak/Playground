namespace Lesson12
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
                Console.WriteLine("1.Лекция вывод:");
                Console.WriteLine("2.Резюме:");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Lecture lection = new Lecture();
                        break;
                    case "2":
                        CurriculumVitae cv = new CurriculumVitae();
                        InputCurriculumVitae(cv);
                        cv.PrintResume();
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
        public static void InputCurriculumVitae(CurriculumVitae cv)
        {
            Console.Write("Введите ФИО: ");
            cv.FullName = Console.ReadLine();

            Console.Write("Введите контактную информацию: ");
            cv.ContactInfo = Console.ReadLine();

            Console.Write("Введите краткое описание (максимум 1000 символов): ");
            string summary = Console.ReadLine();
            cv.FillResume(summary);

            Console.Write("Введите с какого года опыт работы: ");
            if (int.TryParse(Console.ReadLine(), out int startYear))
            {
                cv.CalculateExperience(startYear);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }

            Console.WriteLine("Введите навыки (введите 'end' для завершения):");
            while (true)
            {
                string skill = Console.ReadLine();

                if (skill == "end")
                {
                    break;
                }

                cv.AddSkill(skill);
            }

            Console.WriteLine("Введите опыт работы (введите 'end' для завершения):");
            while (true)
            {
                string job = Console.ReadLine();

                if (job.ToLower() == "end") {
                    break; 
                }

                cv.AddWorkExperience(job);
            }
        }
    }
}