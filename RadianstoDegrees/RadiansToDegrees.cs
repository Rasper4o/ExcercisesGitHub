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
            Console.WriteLine("This program turns radians to degrees!");
            //User input
            double rad = double.Parse(Console.ReadLine());
            //transform
            double deg = rad * 150 / Math.PI;
            //Output to screen
            Console.WriteLine(Math.Round(deg, 0));
        }
    }
}
