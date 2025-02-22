using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Task2
    {
        public void Main2()
        {
            Console.Write("Введите целое число: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 || n >= 0 ? "True" : "No");
        }
    }
}
