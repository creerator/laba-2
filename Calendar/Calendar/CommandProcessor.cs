using Helpers;
using CalendarServices;

namespace ProgramUtilities
{
    public class CommandProcessor
    {
        private readonly LeapYearService _leapYearService;
        private readonly DateIntervalService _dateIntervalService;
        private readonly DayOfWeekService _dayOfWeekService;

        public CommandProcessor()
        {
            _leapYearService = new LeapYearService();
            _dateIntervalService = new DateIntervalService();
            _dayOfWeekService = new DayOfWeekService();
        }

        public bool ProcessCommand()
        {
            string command = Console.ReadLine().Trim().ToLower();

            switch (command)
            {
                case "check":
                    _leapYearService.CheckLeapYear();
                    break;
                case "calc":
                    _dateIntervalService.CalculateDateInterval();
                    break;
                case "day":
                    _dayOfWeekService.DisplayDayOfWeek();
                    break;
                case "quit":
                    return false;
                default:
                    Console.WriteLine(Literals.unknow_command);
                    break;
            }

            return true;
        }
    }
}