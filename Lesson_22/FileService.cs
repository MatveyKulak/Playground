namespace Lesson_22
{
    public class FileService
    {
        public static void Create (string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static async Task CreateAsync (string path, string content)
        {
            await File.WriteAllTextAsync(path, content);
        }

        public static string Read (string path) => File.ReadAllText(path);

        public static void Write (string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static void Append (string path, string content)
        {
            File.AppendAllText(path, content);
        }

        public static void Update (string path, string oldText, string newText)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден"); //Обязательно обработать исключение выше
            }

            var content = File.ReadAllText(path).Replace(oldText, newText);
            File.WriteAllText(path, content);
        }

        public static void Delete (string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
        }
    }
}