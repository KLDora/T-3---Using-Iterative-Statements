using System;

namespace T_3___Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] _)
        {
            // Asks the user for input.
            Console.WriteLine("Please enter a CAD increment value between 5 and 25.");
            // Stores user input to the variable input.
            string input = Console.ReadLine();
            // Checks if the input can be parsed to a valid decimal value.
            if (decimal.TryParse(input, out decimal increment))
            {
                // Checks if the input is in the valid range.
                if ((increment >= 5m) && (increment <= 25m))
                {
                    // The value in Canadian dollars.
                    decimal CAD = 0m;
                    // The value in United States dollars.
                    decimal USD = 0m;
                    // Prints the increment value.
                    Console.WriteLine("CAD Increment Value = " + increment);
                    // Prints the table header.
                    Console.WriteLine("CAD  US$");
                    // The maximum value of the table in CAD.
                    const decimal MAX = 200m;
                    // The conversion rate from CAD to USD.
                    const decimal CONVERSION_RATE = 0.792367m;
                    // Loop until CAD is greater than max.
                    while (CAD <= MAX)
                    {
                        // Calculates USD from CAD given the conversion rate.
                        USD = CAD * CONVERSION_RATE;
                        // Prints the rows in the table.
                        Console.WriteLine($"{CAD, -4} {USD, -6:0.00}");
                        // Adds the increment to CAD.
                        CAD += increment;
                    }
                    
                }
                // If the input value is outside of the range.
                else
                {
                    // Prints error message to user.
                    Console.WriteLine("Please enter a value between 5 and 25.");
                }
            }
            // If the input is not a valid decimal.
            else
            {
                // Prints an error message to the user.
                Console.WriteLine("Please input a valid decimal number.");
            }
            
        }
    }
}
