using System;
using CalendarServices;
using Helpers;
using ProgramUtilities;

class Program
{
    static void Main()
    {
        Console.WriteLine(Literals.welcome_message);

        Console.WriteLine(Literals.separator);
        Console.WriteLine(Literals.input_command);

        CommandProcessor processor = new CommandProcessor();
        
        while (processor.ProcessCommand())
        {
            Console.WriteLine(Literals.separator);
            Console.WriteLine(Literals.input_command);
        }
    }
}
