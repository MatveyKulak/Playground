namespace Lesson17
{
    public class MyString
    {
        private char[] mas = new char[2];

        public MyString()
        {
            mas = null;
        }

        public MyString(char c, char a)
        {
            mas[0] = c;
            mas[1] = a;
        }

        public void ReverseMas()
        {
            char[] reverse = new char[mas.Length];

            for (int i = 0; i < mas.Length; i++)
            {
                reverse[i] = mas[mas.Length - 1 - i];
            }

            foreach (var charr in reverse)
            {
                Console.WriteLine(charr);
            }
        }
    }
}
