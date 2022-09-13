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
            //Intro
            Console.WriteLine("Please enter the first number: ");
            double iPut1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double iPut2 = Convert.ToDouble(Console.ReadLine());
            
            
            //Addition
            Console.WriteLine("The sum of all of the numbers is...");
            double total = Methods.Add(iPut1, iPut2);
            Console.WriteLine(total);
            
            //Subtraction
            Console.WriteLine("The subtraction of all of the numbers is...");
            double total1 = Methods.Subtract(iPut1, iPut2);
            Console.WriteLine(total1);
            
            //Multiplication
            Console.WriteLine("The product of all of the numbers is...");
            double total2 = Methods.Multiply(iPut1, iPut2);
            Console.WriteLine(total2);
           
            //Division
            Console.WriteLine("The quotient of all of the numbers is...");
            double total3 = Methods.Divide(iPut1, iPut2);
            Console.WriteLine(total3);
        }
        public static double Subtract(double num1, double num2)
        {

            return num1 - num2;





        }
        public static double Multiply(double num1, double num2)
        {

            return num1 * num2;





        }
        public static double Divide(double num1, double num2)
        {

           
            if (num2 == 0)
            {
                return 0;
            }
            else
                return num1 / num2;





        }


    }
}
