namespace Lesson_22
{
    public class ImageService
    {
        public static void Load ()
        {
            Console.WriteLine("Введите полный путь к изображению (например, C:\\Users\\User\\Pictures\\photo.jpg):");
            string sourcePath = Console.ReadLine()?.Trim('"');

            if (string.IsNullOrWhiteSpace(sourcePath) || !File.Exists(sourcePath))
            {
                Console.WriteLine("Файл не найден. Проверьте путь и попробуйте снова.");
                return;
            }

            string fileName = Path.GetFileName(sourcePath);
            string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            Directory.CreateDirectory(targetDirectory);

            string targetPath = Path.Combine(targetDirectory, fileName);

            try
            {
                File.Copy(sourcePath, targetPath, overwrite: true);
                Console.WriteLine($"Файл успешно скопирован в: {targetPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при копировании: {ex.Message}");
            }
        }
    }
}
