namespace Lesson23
{
    public class Math
    {
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториала не существует.");
            }
            if (n > 10)
            {
                throw new ArgumentOutOfRangeException("Факториал слишком большой.");
            }

            var result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int Power(int value, int power)
        {
            if (power < 0)
            {
                throw new ArgumentException("Пожалуйста, не надо отрицательных степеней.");
            }

            if (power > 10)
            {
                throw new ArgumentException("Слишком много, давай меньше.");
            }

            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= value;
            }
            return result;
        }
    }
}
