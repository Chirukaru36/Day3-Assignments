using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment8
    {
        static double ConvertCelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;

        }
        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            double celsius;
            Console.WriteLine("enter the amount of Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            double kelvin = ConvertCelsiusToKelvin(celsius);
            double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
            Console.WriteLine($"kelvin = {kelvin}");
            Console.WriteLine($"fahrenheit = { fahrenheit}");
            Console.Read();
        }
    }
}
