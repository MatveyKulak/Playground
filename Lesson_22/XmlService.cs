using Lesson_22.Models;
using System.Xml.Serialization;

namespace Lesson_22
{
    internal class XmlService
    {
        public static async Task Load ()
        {
            string url = "http://www.thomas-bayer.com/sqlrest/CUSTOMER/3/";
            using HttpClient client = new();

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string xml = await response.Content.ReadAsStringAsync();

                var serializer = new XmlSerializer(typeof(Customer));
                using var reader = new StringReader(xml);
                var customer = (Customer?)serializer.Deserialize(reader);

                if (customer != null)
                {
                    Console.WriteLine($"ID: {customer.Id}");
                    Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
                    Console.WriteLine($"Address: {customer.Street}, {customer.City}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
