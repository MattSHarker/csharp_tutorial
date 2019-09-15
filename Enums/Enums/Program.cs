using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enums
{
    // enums are declared outside of any classes
    public enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    // enums are automatically given integer values, which can be overwritten
    public enum DaysOfWeekModified { Sunday = 10, Monday = 20, Tuesday = 30, Wednesday = 40 };

    class Program
    {

        static void Main(string[] args)
        {
            // initializing an enum variable
            DaysOfWeek today = DaysOfWeek.Sunday;

            // using an enum type
            if(today == DaysOfWeek.Sunday)
            {
                Console.WriteLine("It is the day of Sun");
            }
            else if (today == DaysOfWeek.Monday)
            {
                Console.WriteLine("It is the day of Mon");
            }
            // and so on

            switch(today)
            {
                case DaysOfWeek.Sunday:
                    Console.WriteLine("It is the day of Sun");
                    break;
                case DaysOfWeek.Monday:
                    Console.WriteLine("It is the day of Mon");
                    break;
                // and so on
                default:
                    break;
            }

            // enums also have an inherent int value, and can be cast to it
            int todayAsInt = (int)today;

            Console.WriteLine("The numeric value of \"today\" (" + today + ") is " + todayAsInt);

            // exit prompt
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
