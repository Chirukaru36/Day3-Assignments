using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class Program
    {
        static void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(String[] args)
        {
            int firstNo, secondNo;

            Console.WriteLine("Input the First Number: ");
            firstNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second Number: ");
            secondNo = Convert.ToInt32(Console.ReadLine());
            SwapNumbers(ref firstNo, ref secondNo);

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + firstNo);
            Console.WriteLine("Second Number: " + secondNo);
            Console.ReadLine();
        }
    }
}

