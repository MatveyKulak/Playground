using Lesson_22.Models;
using System.Text.Json;

namespace Lesson_22
{
    public class JsonService
    {
        public static async Task Parse ()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            using HttpClient client = new();

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var users = JsonSerializer.Deserialize<List<User>>(json, options);

                if (users != null)
                {
                    foreach (var user in users)
                    {
                        Console.WriteLine($"{user.Id}: {user.Name} ({user.Email})");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении данных: " + ex.Message);
            }
        }

        public static async Task WriteJsonToFileAsync<T> (string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync(filePath, json);
        }

        public static async Task<T?> ReadJsonFromFileAsync<T> (string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не найден.");
                return default;
            }

            string json = await File.ReadAllTextAsync(filePath);

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
