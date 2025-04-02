using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson13
{
    class PlainClass
    {
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }
        public bool BoolProperty { get; set; }
        public double DoubleProperty { get; set; }

        public PlainClass() : this(1)
        {
            Display();
        }

        public PlainClass(int number) : this("a", true)
        {
            IntProperty = number;
            DoubleProperty = double.MinValue;
        }

        public PlainClass(string text, bool flag) : this(text, flag, 0)
        {
            StringProperty = text;
            BoolProperty = flag;
        }

        public PlainClass(string text, bool flag, double input)
        {
            StringProperty = text;
            BoolProperty = flag;
            DoubleProperty = input;
        }
        private void Display()
        {
            Console.WriteLine($"{IntProperty}");
        }
    }
}
