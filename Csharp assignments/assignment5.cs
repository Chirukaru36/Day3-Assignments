using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment5
    {
        static void displaynumberFourTimes(int num)
        {
            Console.WriteLine($"{num} {num} {num} {num}");
            Console.WriteLine($"{num}{num}{num}{num}");
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the digit");
            num =Convert.ToInt32( Console.ReadLine() );
            displaynumberFourTimes(num);
            displaynumberFourTimes(num);
            Console.ReadLine();
        }
    }
}
