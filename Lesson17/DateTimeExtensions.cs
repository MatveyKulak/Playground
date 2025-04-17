namespace Lesson17
{
    public static class DateTimeExtensions
    {
        public static string DayMonthYear(this DateTime dateTime)
        {
            int day = dateTime.Day;
            string monthName = dateTime.ToString("MMMM");
            int year = dateTime.Year + 5501;

            return $"День '{day}' месяца '{monthName}' года '{year}'.";
        }
    }
}
