using System.ComponentModel.DataAnnotations;

namespace Reflection
{
    public class Contact
    {

        [EmailAddress]
        public string Email { get; set; }

        public int Age { get; set; }

        public Contact(string email, int age)
        {
            Email = email;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Email: {Email}, Возраст: {Age}");
        }
    }
}
