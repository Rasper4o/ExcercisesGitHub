using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadianstoDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--This program turns radians to degrees!--");
            //User input
            Console.WriteLine("Enter Radians: ");
            double rad = double.Parse(Console.ReadLine());
            //Transform
            double deg = rad * 150 / Math.PI;
            //Output to screen
            Console.WriteLine("Result: "+Math.Round(deg, 0));
        }
    }
}
