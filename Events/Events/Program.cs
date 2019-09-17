using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            // attaches an event handler
            point.PointChanged += HandlePointChanged;

            // The event handler will be raised now
            point.X = 3;

            // detaches an event handler
            point.PointChanged -= HandlePointChanged;

            // the event handler will not be raised
            point.Y = 5;

            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void HandlePointChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("The event has been raised");
        }
    }
}
