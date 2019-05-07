//Blake Jensen 30006830
//purpose
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52023rdMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //program explains to the user what it's purpose is
            //then asks the user to enter a parameter so that it can return the values
            Console.WriteLine("This program's purpose is to return a number: ");
            Console.WriteLine("- Representing the circumference of a circle.");
            Console.WriteLine("- Representing the area of a circle");

            Console.WriteLine("Please enter the radius of the circle: ");
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine("Radius selected: " + input);
            Console.WriteLine("Circumference: " + Math.Round(Circumference(input)));
            Console.WriteLine("Area: " + Math.Round(Area(input)));
            Console.ReadLine();
        }

        static double Circumference(double rad)
        //this method calculates the circumference of the circle
        //which uses Math.PI in order to use PI to do the calculation of the radius
        {
            return rad * 2 * Math.PI;
        }
        static double Area(double rad)
        //this method calculates the area of the circle
        //this multiples the radius twice before multiplying by PI
        {
            return (rad * rad) * Math.PI;
        }
    }
}
