using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment7
    {
        static int FindMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        static int FindMin(int num1, int num2) 
        {  
            return Math.Min(num1, num2); 
        }
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("enter the first number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            num2=Convert.ToInt32(Console.ReadLine());
            int max=FindMax(num1, num2);
            Console.WriteLine($"maximum number is {max}");
            int min=FindMin(num1, num2);
            Console.WriteLine($"minimum number is {min}");
            Console.ReadLine();
        }
    }
}
