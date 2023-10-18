using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment11
    {
        static void ConvertDays(int days)
        {
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int remainingDays = (days % 365) % 7;
            Console.WriteLine($"Years = {years}");
            Console.WriteLine($"Weeks = {weeks}");
            Console.WriteLine($"Days = {remainingDays}");
        }
        static void Main(string[] args)
        {
            int totaldays;
            Console.WriteLine("enter the number of days");
            totaldays=Convert.ToInt32(Console.ReadLine());
            ConvertDays(totaldays);
            Console.ReadLine();
           
        }
    }
}
