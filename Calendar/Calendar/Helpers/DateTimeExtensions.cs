using System;
using System.Collections.Generic;

namespace Helpers
{
    public static class DateTimeExtensions
    {
        public static DateTime ReadDateFromConsole(string datePrompt)
        {
            if (datePrompt != String.Empty) Console.WriteLine(datePrompt);

            int year, month, day;

            Console.Write(Literals.year_input);
            if (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine(Literals.year_input_wrong);
                return DateTime.MinValue;
            }

            Console.Write(Literals.month_input);
            if (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine(Literals.month_input_wrong);
                return DateTime.MinValue;
            }

            Console.Write(Literals.day_input);
            if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                Console.WriteLine(Literals.day_input_wrong);
                return DateTime.MinValue;
            }

            try
            {
                var date = new DateTime(year, month, day);
                return date;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(Literals.date_input_wrong);
                return DateTime.MinValue;
            }
        }
    }
}
