using System;
using System.Linq.Expressions;

namespace _1.ClassBoxData_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
            try
            {
                Box box = new Box(l, w, h);
                Console.WriteLine($"Surface Area - {box.Area():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.Volume():F2}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
         }
    }
}
/*
 * 1.Class Box Data
You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters. Expose to the outside world only methods for its surface area, lateral surface area and its volume (formulas: http://www.mathwords.com/r/rectangular_parallelepiped.htm).
A box’s side should not be zero or a negative number. Аdd data validation for each parameter given to the constructor. Make a private setter that performs data validation internally. 
Input
On the first three lines you will get the length, width and height. 
Output
On the next three lines print the surface area, lateral surface area and the volume of the box:
Examples
Input	Output
2
3
4	

Output
Surface Area - 52.00
Lateral Surface Area - 40.00
Volume - 24.00

    Input
1.3
1
6	

Output
Surface Area - 30.20
Lateral Surface Area - 27.60
Volume - 7.80
2
-3
4	Width cannot be zero or negative.
*/