using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Banner
{
    class Program
    {
        static Timer tmr = new Timer();
        static int x = 10;
        static void Main(string[] args)
        {
            Console.Clear();
            tmr.Interval = 20;
            tmr.Start();
            tmr.Elapsed += Tmr_Elapsed;
            Console.ReadKey(false);
        }

        private static void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            x += 1;
            if (x > 100)
            {
                x = 10;
            }
            Console.SetCursorPosition(x, 10);
            Console.WriteLine("Goeiemiddag!");
        }
    }
}
