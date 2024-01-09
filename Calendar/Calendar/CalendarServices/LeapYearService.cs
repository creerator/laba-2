using System;
using Helpers;

namespace CalendarServices
{
    public class LeapYearService
    {
        public void CheckLeapYear()
        {
            Console.WriteLine(Literals.year_input);
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                bool isLeapYear = DateTime.IsLeapYear(year);
                Console.WriteLine(String.Format(Literals.is_year_leap, year, isLeapYear));
            }
            else
            {
                Console.WriteLine(Literals.year_input_wrong);
            }
        }
    }
}
