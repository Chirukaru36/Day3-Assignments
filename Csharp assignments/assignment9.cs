using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment9
    {
        static int sumandTripleSum(int a, int b)
        {
            int sum = a + b;
            if (a==b)
            {
                return 3 * sum;
            }
            else
            {
                return sum;
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
            int result= sumandTripleSum(a,b);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }
}
