using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

class Driver
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter time 1 in 24hr format as follows (HH:MM:SS)");
            string timeOne = Console.ReadLine();
            int timeOneSeconds = convertToSeconds(timeOne);
            Console.WriteLine("Enter time 2 in 24hr format as follows (HH:MM:SS)");
            string timeTwo = Console.ReadLine();
            int timeTwoSeconds = convertToSeconds(timeTwo);
            Console.WriteLine("Difference in times: " + Math.Abs(timeOneSeconds - timeTwoSeconds));
        }
        catch (InvalidTimeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Enter a valid time");
        }
    }

    public static int convertToSeconds(string time)
    {
        string[] values = time.Split(':');
        int timeSeconds = 0;

        int hours = int.Parse(values[0]);

        if (hours >= 0 && hours < 24)
        {
            timeSeconds += hours * 60 * 60;
        }
        else
        {
            if (hours >= 24)
            {
                throw new InvalidTimeException("Hours must be below 24");
            }
            throw new InvalidTimeException("wrong hours");
        }

        int minutes = int.Parse(values[1]);

        if (minutes >= 0 && minutes < 60)
        {
            timeSeconds += minutes * 60;
        }
        else
        {
            if (minutes >= 60)
            {
                throw new InvalidTimeException("Minutes must be below 60");
            }
            throw new InvalidTimeException("wrong minutes");
        }

        int seconds = int.Parse(values[2]);

        if (seconds >= 0 && seconds < 60)
        {
            timeSeconds += seconds;
        }
        else
        {
            if (seconds >= 60)
            {
                throw new InvalidTimeException("Seconds must be below 60");
            }
            throw new InvalidTimeException("wrong seconds");
        }

        return timeSeconds;
    }
}
