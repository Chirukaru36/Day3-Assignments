using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class Multiplication_of_threenos
    {
        static int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("enter the first number");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            c = Convert.ToInt32(Console.ReadLine());
            int result= Multiplication(a, b, c);
            Console.WriteLine($"{a}* {b}* {c}= {result}");
            Console.Read();

        }
    }
}
