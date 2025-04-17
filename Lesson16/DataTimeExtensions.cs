namespace Lesson16
{
    public static class DataTimeExtensions
    {
        public static AddBusinessDays(this DateTime startDate, int businessDays, List<DateTime> holidays)
        {
            DateTime currentDate = startDate;
            int addedDays = 0;

            while (addedDays < businessDays)
            {
                currentDate = currentDate.AddDays(1);

                if (IsBusinessDay(currentDate, holidays))
                {
                    addedDays++;
                }
            }
        }

        private static bool IsBusinessDay(DateTime date, List<DateTime> holidays)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            if (holidays.Contains(date))
            {
                return false;
            }

            return true;
        }
    }
}
