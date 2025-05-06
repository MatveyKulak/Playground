using Lesson18.PersonManagment;

namespace Lesson18
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
                        var employeeManager = new EmployeeManager();
                        var studentManager = new StudentManager();

                        var emp1 = new Employee(1, "Employee Bla bla", 30, "Team Lead", 100000000000);
                        var emp2 = new Employee(2, "Employee Bla bla Jr.", 30, "Junior", 1);

                        employeeManager.Add(emp1);
                        employeeManager.Add(emp2);

                        var std1 = new Student(1, "Student Bla bla", 30, 1, 10);
                        var std2 = new Student(2, "Student Bla bla Jr.", 30, 5, 2);

                        studentManager.Add(std1);
                        studentManager.Add(std2);

                        employeeManager.DisplayAll();
                        studentManager.DisplayAll();

                        employeeManager.Remove(1);
                        studentManager.Remove(3);

                        employeeManager.DisplayAll();
                        studentManager.DisplayAll();
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
