using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using TryParse to convert string to integer
            string str1 = "123";
            int num1;
            if (int.TryParse(str1, out num1))
            {
                Console.WriteLine("TryParse successfully converted the string to an integer: " + num1);
            }
            else
            {
                Console.WriteLine("TryParse failed to convert the string to an integer.");
            }

            // Using Convert to convert string to double
            string str2 = "3.14";
            try
            {
                double num2 = Convert.ToDouble(str2);
                Console.WriteLine("Convert successfully converted the string to a double: " + num2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed to convert the string to a double.");
            }

            // Using Parse to convert string to decimal
            string str3 = "99.99";
            try
            {
                decimal num3 = decimal.Parse(str3);
                Console.WriteLine("Parse successfully converted the string to a decimal: " + num3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed to convert the string to a decimal.");
            }

            Console.ReadLine();
        }
    }
}

