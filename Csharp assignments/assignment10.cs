using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment10
    {
        static int differenceOfTwoNUmbers(int a, int b)
        {
            int difference = a - b;
            if (a > b)
            {
                return 2 * difference;

            }
            else
            {
                return difference;
            }
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter the first number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b=Convert.ToInt32(Console.ReadLine());
            int result=differenceOfTwoNUmbers((int)a, (int)b);
            Console.WriteLine($"Result = {result}");
            Console.ReadLine();

        }
    }
}
