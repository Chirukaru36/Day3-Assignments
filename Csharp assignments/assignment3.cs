using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment3
    {
        static int threenos(int x, int y, int z)
        {
            return (x + y) * z;
        }
        static int addthreenos(int x, int y, int z)
        {
            return (x*y) + (y*z);   
        }
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            Console.WriteLine("enter the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            z = Convert.ToInt32(Console.ReadLine());
            int result1 = threenos(x, y, z);
            int result2 = addthreenos(x, y, z);
            Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y).z is {result1} and xy + y.z is {result2}");
            Console.Read();
        }
    }
}
