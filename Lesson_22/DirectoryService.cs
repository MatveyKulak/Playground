namespace Lesson_22
{
    public class DirectoryService
    {
        public static void EnsureExists (string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Каталог создан: {path}");
            }
            else
            {
                Console.WriteLine($"Каталог уже существует: {path}");
            }
        }

        public static void Delete (string path, bool recursive = true)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, recursive);
                Console.WriteLine($"Каталог удалён: {path}");
            }
            else
            {
                Console.WriteLine("Каталог не найден.");
            }
        }

        public static void PrintInfo (string path)
        {
            var dir = new DirectoryInfo(path);

            Console.WriteLine("Информация о каталоге:");
            Console.WriteLine($"Полный путь:           {dir.FullName}");
            Console.WriteLine($"Имя:                   {dir.Name}");
            Console.WriteLine($"Дата создания:         {dir.CreationTime}");
            Console.WriteLine($"Дата доступа:          {dir.LastAccessTime}");
            Console.WriteLine($"Дата изменения:        {dir.LastWriteTime}");
            Console.WriteLine($"Родительская папка:    {dir.Parent?.FullName}");
            Console.WriteLine($"Атрибуты:              {dir.Attributes}");
            Console.WriteLine($"Корень:                {dir.Root.FullName}");

            ListContents(path);
        }

        public static void PrintPathInfo (string part1, string part2)
        {
            var fullPath = Path.Combine(part1, part2);

            Console.WriteLine("Информация о пути:");
            Console.WriteLine($"Комбинированный путь: {fullPath}");
            Console.WriteLine($"Имя файла:            {Path.GetFileName(fullPath)}");
            Console.WriteLine($"Расширение:           {Path.GetExtension(fullPath)}");
        }

        private static void ListContents (string path)
        {
            Console.WriteLine("Файлы:");

            foreach (var file in Directory.GetFiles(path))
            {
                PrintFileInfo(file);
            }

            Console.WriteLine("Подкаталоги:");

            foreach (var dir in Directory.GetDirectories(path))
            {
                Console.WriteLine("- " + Path.GetFileName(dir));
            }
        }

        private static void PrintFileInfo (string path)
        {
            var info = new FileInfo(path);

            Console.WriteLine("Информация о файле:");
            Console.WriteLine($"Полный путь:        {info.FullName}");
            Console.WriteLine($"Имя файла:          {info.Name}");
            Console.WriteLine($"Расширение:         {info.Extension}");
            Console.WriteLine($"Размер (байт):      {info.Length}");
            Console.WriteLine($"Дата создания:      {info.CreationTime}");
            Console.WriteLine($"Дата изменения:     {info.LastWriteTime}");
            Console.WriteLine($"Дата доступа:       {info.LastAccessTime}");
            Console.WriteLine($"Атрибуты:           {info.Attributes}");
            Console.WriteLine($"Только для чтения:  {info.IsReadOnly}");
            Console.WriteLine($"Каталог:            {info.DirectoryName}");
        }
    }
}