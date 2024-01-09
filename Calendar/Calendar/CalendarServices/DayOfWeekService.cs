using Helpers;

namespace CalendarServices
{
    public class DayOfWeekService
    {
        public void DisplayDayOfWeek()
        {
            DateTime date = DateTimeExtensions.ReadDateFromConsole("");
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
