using System.Text;

namespace Lesson23
{
    public static class MethodRas
    {
        public static string RebuildString(this string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    string word;

                    switch (digit)
                    {
                        case 0:
                            word = "ноль";
                            break;
                        case 1:
                            word = "один";
                            break;
                        case 2:
                            word = "два";
                            break;
                        case 3:
                            word = "три";
                            break;
                        case 4:
                            word = "четыре";
                            break;
                        case 5:
                            word = "пять";
                            break;
                        case 6:
                            word = "шесть";
                            break;
                        case 7:
                            word = "семь";
                            break;
                        case 8:
                            word = "восемь";
                            break;
                        case 9:
                            word = "девять";
                            break;
                        default:
                            word = c.ToString();
                            break;
                    }
                    result.Append(" " + word + " ");
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
