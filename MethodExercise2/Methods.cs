using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    internal class Methods
    {
        public static double Add(double num1, double num2)
        {

            return num1 + num2;





        }
        public static void NUMS()
        {
            Console.WriteLine("Please enter the first number: ");
            double iPut1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double iPut2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of all of the numbers is...");
            double total = Methods.Add(iPut1, iPut2);
            Console.WriteLine(total);
        }
    }
}
