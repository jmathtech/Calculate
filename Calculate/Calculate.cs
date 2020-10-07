using System;

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            /* 
             Name: Jamil Matheny & Bryce Moore
             Date: 10/07/2020
             Class: CIS214

             */

            int num1; // declares the first number 
            int num2; // declares the second number
            int sum;

            // Prompt the user to enter the first number
            Console.Write("Please enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Please enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");


            // Calculations
            sum = num1 + num2;
            Console.WriteLine($"Sum is: {sum}"); // Displays the sum (addition)

            sum = num1 * num2;
            Console.WriteLine($"Product is: {sum}"); // Displays the product (multiplication)

            sum = num1 - num2;
            Console.WriteLine($"Difference is: {sum}"); // Displays the difference (subtraction)

            sum = num1 / num2;
            Console.WriteLine($"Quotient is: {sum}"); // Displays the quotient (division)


        } // end Main
    } //end Class
}
