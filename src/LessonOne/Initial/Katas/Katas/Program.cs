using System;

namespace Katas
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello OOP apprentices!");
        }

        /*
         HINT: Use https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netcore-3.1 to learn more 
         on how to read and write to the console.
         */

        /// <summary>
        /// Write a C# program to demonstrate input and output of all primitive value types.
        /// Use the methods from <see cref="Console"/> like <see cref="Console.Read"/>,
        /// <see cref="Console.ReadKey"/> and <see cref="Console.ReadLine"/> to read the data from the console.
        /// To display the values use <see cref="Console.WriteLine(string)"/>
        /// </summary>
        /// <remarks>Prmitive value types are char, short, int, long, float, double, decimal</remarks>
        static void PrimitiveDataTypesIO()
        {
        }

        /// <summary>
        /// Write a C# program that reads two natural numbers from the console
        /// and then perform all arithmetic opeartions between them and display the results.
        /// </summary>
        /// <remarks>The arithmetic operations are sum, difference, product, division and modulus.</remarks>
        static void ArithmeticOperationsOfTwoNumbers()
        {
        }

        /// <summary>
        /// Write a C# program to input temperature in degree Fahrenheit and converts it to degree Centigrade.
        /// </summary>
        /// <remarks>The formula for convertion is: <c>C° = (F° - 32) * 5/9</c></remarks>
        static void FahrenheitToCelsiusConvert()
        {
        }

        /// <summary>
        /// Write a C# program to find and display the maximum between two numbers read from the console.
        /// </summary>
        static void MaximumBetweenTwoNumbers()
        {
        }

        /// <summary>
        /// Write a C# program to find and display the maximum between three numbers read from the console.
        /// </summary>
        static void MaximumBetweenThreeNumbers()
        {
        }

        /// <summary>
        /// Write a C# program that allows the user to input an ammount of money and compute the minimum number of
        /// notes required for the respective ammount. For this exercise we will use the Romanian currency.
        /// Example: for 575 RON we have: 1 * 500 RON, 1 * 50 RON, 2 * 10 RON, 1 * 5 RON
        /// </summary>
        /// <remarks>The Romanian notes are: 500, 200, 100, 50, 10, 5, 1 RON</remarks>
        static void NumberOfNotes()
        {
        }

        /// <summary>
        /// Write a C# program that read a year from the console and checks if that year is a leap year.
        /// </summary>
        /// <remarks>A year is said to be leap year, if the year is exactly divisible by 4 but and not divisible by 100.
        /// Year is also a leap year if it is exactly divisible by 400.</remarks>
        static void LeapYear()
        {
        }

        /// <summary>
        /// Write a C# Sharp program to read temperature in centigrade and display suitable message according to temperature.
        /// Temp< 0 then Freezing weather
        /// Temp 0-10 then Very Cold weather
        /// Temp 10-20 then Cold weather
        /// Temp 20-30 then Normal in Temp
        /// Temp 30-40 then Its Hot
        /// Temp >=40 then Its Very Hot
        /// </summary>
        static void DisplayMessageForTemperature()
        {

        }

        ///<summary>
        /// Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
        ///</summary>
        static void CategorizePersonByHeigth()
        { 
        
        }

        /// <summary>
        /// Write a C# program to find all roots of a quadratic equation (ax² + bx + c = 0). The program will read from
        /// the console the values for a, b and c and will calculate and display the roots found.
        /// For square root use <see cref="Math.Sqrt(double)"/> and for raising to a power use <see cref="Math.Pow(double, double)"/>.
        /// </summary>
        static void RootsOfAQuadraticEquation()
        {
            /*
             * Solving the quadratic equation:
             * 1. Compute Δ = b² - 4 * a * c
             * 2. if Δ > 0 then the roots are r1 = (-b + √Δ) / 2 * a and r2 = (-b - √Δ) / 2 * a
             *    if Δ = 0 then the roots are r1 = r2 = -b / 2 * a
             *    if Δ < 0 then the roots are r1 = (-b / 2 * a) + i * (√-Δ /2 * a)
             *                                r2 = (-b / 2 * a) - i * (√-Δ /2 * a)
             */
        }

        /// <summary>
        /// Write a C# program to input month number and print total number of days in month.
        /// </summary>
        static void NumberOfDays()
        {
        }

        /// <summary>
        /// Write a C# program to input an alphabet letter and check whether it is vowel or consonant.
        /// </summary>
        /// <remarks>English alphabets 'a', 'e', 'i', 'o', 'u' both lowercase and uppercase are known as vowels.</remarks>
        static void VowelOrConsonant()
        {
        }

        /// <summary>
        /// Write a C# program that reads from the console a natural number n and after that reads and display an array
        /// with size n.
        /// </summary>
        static void ReadArrayFromKeyboard()
        {
        }

        /// <summary>
        /// Write a C# program to input a number from user and print multiplication table of the given number.
        /// </summary>
        static void MultiplicationTable()
        {
        }

        /// <summary>
        /// Write a C# program to print all odd numbers from 1 to n
        /// </summary>
        static void PrintAllOddnaturalNumberTo100()
        {
        }

        /// <summary>
        /// Write a C# program to find all Perfect numbers between 1 to n, where n is read from the console.
        /// </summary>
        /// <remarks>
        /// A Perfect number is a positive integer which is equal to the sum of its proper positive divisors.
        /// Example: 6 is a perfect number becase 6 = 1 + 2 + 3
        /// </remarks>
        static void PerfectNumbers()
        {
        }

        /// <summary>
        /// Write a C# program to input number from user and check whether number is a Strong number or not.
        /// </summary>
        /// <remarks>
        /// Strong number is a special number whose sum of factorial of digits is equal to the original number.
        /// For example: 145 is a strong number since, 1! + 4! + 5! = 145
        /// </remarks>
        static void StrongNumber()
        {
        }
    }
}
