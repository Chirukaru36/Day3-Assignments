using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class addition
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static int sub(int a,int b) 
        { 
            return a - b; 
        }
        static int mul(int a, int b)
        {
            return (a * b);
        }
        static int div(int a, int b)
        {
            return a / b;
        }
        static int mod(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter the first number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b=Convert.ToInt32(Console.ReadLine());
            int additionresult=add(a,b);
            Console.WriteLine($"{a} + {b} = {additionresult}");
            int subtractionresult=sub(a,b);
            Console.WriteLine($"{a} - {b} = {subtractionresult}");
            int multiplicationresult=mul(a,b);
            Console.WriteLine($"{a} * {b} = {multiplicationresult}");
            int divisionresult=div(a,b);
            Console.WriteLine($"{a} / {b} = {divisionresult}");
            int modresult=mod(a,b);
            Console.WriteLine($"{ a} mod { b} = {modresult}");
            Console.Read();


        }
    }
}
