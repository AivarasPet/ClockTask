using ClockTask;
using System;

namespace ClockTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Clock clock = InitUsersClock();
                Console.WriteLine("Degrees between arrows: " + clock.GetClockDegree().ToString("0.00"));
            }
            catch (InvalidUserInputException ex)
            {
                Console.WriteLine("User inputs were not proper integers");
            }
            catch (InvalidClockTimeException ex)
            {
                Console.WriteLine("Time was not set in proper range");
            } 
        }

        static Clock InitUsersClock()
        {
            Console.WriteLine("Please enter hours: ");
            string hoursStr = Console.ReadLine();
            Console.WriteLine("Please enter minutes: ");
            string minutesStr = Console.ReadLine();
            if(int.TryParse(hoursStr, out int hours) && int.TryParse(minutesStr, out int minutes)) {
                return new Clock { Minutes=minutes, Hours=hours };
            }
            throw new InvalidUserInputException();
        }

    }
    [Serializable]
    class InvalidUserInputException : Exception
    {
    }
}