namespace Lesson13.Practice
{
    class TestCase
    {
        private const string Passed = "Пройден";
        private const string Failed = "Не пройден";
        public string Name { get; set; }
        public string Descriptoin { get; set; }
        public string status;

        public string Status
        {
            get => status;
            set
            {
                if (value != Passed && value != Failed)
                {
                    throw new ArgumentException("Неверный статус (должен быть Пройден или Не пройден).");
                }
                status = value;
            }
        }
        public DateTime LastRun { get; private set; }

        public string TimeSinceLastRun
        {
            get
            {
                if (LastRun == DateTime.MinValue)
                {
                    return "Тест ещё не был запущен";
                }

                var diff = DateTime.Now - LastRun;
                return $"С момента выполнения теста прошло: {diff.TotalHours:F2} часов";
            }
        }

        public TestCase(string name, string descriptoin)
        {
            Name = name;
            Descriptoin = descriptoin;
            Status = Failed;
            LastRun = DateTime.MinValue;
        }

        public void RunTest()
        {
            Status = Passed;
            LastRun = DateTime.Now;

            Console.WriteLine($"Тест {Name} выполнен успешно!");
        }

        public void FailedTest()
        {
            Status = Failed;
            LastRun = DateTime.Now;

            Console.WriteLine($"Тест {Name} не пройден");
        }

        public void InfoTest()
        {
            Console.WriteLine($"Тест: {Name}, cтатус: {Status}, последний запуск: {LastRun}, время с последнего запуска: {TimeSinceLastRun}");
        }
    }
}
