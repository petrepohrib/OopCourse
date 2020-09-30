using System;
using System.Diagnostics.CodeAnalysis;

namespace Katas
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello OOP apprentices!");

            // int year = 2020;
            // A year is said to be leap year, if the year is exactly divisible by 4 but and not divisible by 100.
            /// Year is also a leap year if it is exactly divisible by 400.
            //bool condition1 = year % 4 == 0;

            //bool condition2 = year % 100 != 0; // !(year % 100 == 0)

            //bool condition3 = year % 400 == 0;

            ////bool result = condition1 && condition2 || condition3;

            //bool result = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0; // true

            //// bool condition ? true branch : false branch;
            //int leapYearResult = result ? 1 : 2;
            //Console.WriteLine(leapYearResult);

            // int addResult = Adunare(3, 6);
            //MyLeapYear(year);
            //MyLeapYear(2050);
            //MyLeapYear(20320);
            //MyLeapYear(3);

            // PrimitiveDataTypesIO();
            // MaximumBetweenTwoNumbers();
            //MaximumBetweenThreeNumbers();

            //DisplayMessageForTemperature();
            // CategorizePersonByHeigth();
            //NumberOfDays();
            // MultiplicationTable();
            // ReadArrayFromKeyboard();
            PrintAllOddnaturalNumberTo100();
        }


        static int Adunare(int a, int b)
        {
            return a + b;
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
            string consoleInput;
            Console.WriteLine("Please enter a number");
            consoleInput = Console.ReadLine();
            double number = double.Parse(consoleInput);
            Console.WriteLine("Numarul tau este " + number);
        }

        static int GetIntFromConsole(string message)
        {
            Console.WriteLine(message);
            string consoleInput = Console.ReadLine();
            return int.Parse(consoleInput);
        }

        static byte GetByteFromConsole(string message)
        {
            Console.WriteLine(message);
            string consoleInput = Console.ReadLine();
            return byte.Parse(consoleInput);
        }
        /// <summary>
        /// Write a C# program that reads two natural numbers from the console
        /// and then perform all arithmetic opeartions between them and display the results.
        /// </summary>
        /// <remarks>The arithmetic operations are sum, difference, product, division and modulus.</remarks>
        static void ArithmeticOperationsOfTwoNumbers()
        {
            // uint a, b; //
            int a, b;
            a = 23;
            b = -67;
            if (a > 0 && b > 0)
            {
                // sum(a, b)
            }
            else
            {
                Console.WriteLine("Numerele tale nu sunt invalide");
            }
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
            int a = GetIntFromConsole("Introduceti numarul a");
            int b = GetIntFromConsole("Introduceti numarul b");

            if (a > b)
            {
                Console.WriteLine(a + " este mai mare ca " + b);
            }
            else
            {
                if (a == b)
                {
                    Console.WriteLine(a + " este egal cu " + b);
                }
                else
                {
                    Console.WriteLine(b + " este mai mare ca " + a);
                }
            }
        }

        /// <summary>
        /// Write a C# program to find and display the maximum between three numbers read from the console.
        /// </summary>
        static void MaximumBetweenThreeNumbers()
        {
            //a,b,c
            int a = GetIntFromConsole("Introduceti numarul a");
            int b = GetIntFromConsole("Introduceti numarul b");
            int c = GetIntFromConsole("Introduceti numarul c");

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " este mai mare decat  " + b + " si " + c);
                }
                else
                {
                    if (a < c)
                    {
                        Console.WriteLine(c + " este mai mare decat  " + a + " si " + b);
                    }
                    else
                    {
                        Console.WriteLine(a + " este egal cu" + c);
                    }
                }
            }
            else
            {
                if (a == b)
                {
                    // Console.WriteLine(a + " este egal cu " + b);
                    if (b > c)
                    { Console.WriteLine(b + " este mai mare decat  " + c + " si " + a); }
                    else if (b < c)
                    { Console.WriteLine(c + " mai mare " + b + " si " + a); }
                    else
                    { Console.WriteLine(b + " si " + c + " si " + a + " sunt egale"); }
                }
                else if (a < b)
                {
                    if (b > c)
                    { Console.WriteLine(b + " este mai mare decat  " + c + " si " + a); }
                    else if (b < c)
                    { Console.WriteLine(c + " mai mare " + b + " si " + a); }
                    else
                    { Console.WriteLine(b + " si " + c + " si " + a + " sunt egale"); }
                }
            }
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

        static void MyLeapYear(int year)

        {
            bool result = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            string leapYearResult = result ? "This is a leap year" : "This is not a leap year";
            Console.WriteLine(leapYearResult);
        }

        static bool IsALeapYear(int year)

        {
            bool result = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            return result;
        }

        /// <summary>
        /// Write a C# program that read a year from the console and checks if that year is a leap year.
        /// </summary>
        /// <remarks>A year is said to be leap year, if the year is exactly divisible by 4 but and not divisible by 100.
        /// Year is also a leap year if it is exactly divisible by 400.</remarks>
        static void LeapYear()
        {
            int year = GetIntFromConsole("Introduceti anul");
            bool result = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

            if (result)
            {
                Console.WriteLine(year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }

        }

        /// <summary>
        /// Write a C# program that read temperature in Celsius degrees and display suitable message according to temperature.
        /// Temp < 0 then Freezing weather.
        /// Temp 0-10 then Very Cold weather.
        /// Temp 10-20 then Cold weather.
        /// Temp 20-30 then Normal in Temp.
        /// Temp 30-40 then Its Hot.
        /// Temp >=40 then Its Very Hot.
        /// </summary>
        static void DisplayMessageForTemperature()
        {
            int temp = GetIntFromConsole("Introduceti temperatura");

            if (temp <= 0)
            {
                Console.WriteLine($"The temparature is {temp} -> Freezing weather");
            }
            else if (temp <= 10)
            {
                Console.WriteLine($"The temparature is {temp} -> Very Cold weather");
            }
            else if (temp <= 20)
            {
                Console.WriteLine($"The temparature is {temp} -> Cold weather");
            }
            else if (temp <= 30)
            {
                Console.WriteLine($"The temparature is {temp} -> Normal in Temp");
            }
            else if (temp <= 40)
            {
                Console.WriteLine($"The temparature is {temp} -> Its Hot");
            }
            else
            {
                Console.WriteLine($"The temparature is {temp} -> Its Very Hot");
            }

        }

        ///<summary>
        /// Write a C# program to accept the height of a person in centimeters and categorize the person according to their height.
        /// Height is less then 150 then display 'The person is Dwarf'.
        /// Height greater or equal 150 and height less or equal 165 then display 'The person is  average heighted'.
        /// Height greater 165 and height less or equal 195 then display 'The person is taller.'.
        /// Height greater than 195 then display 'Abnormal height.'.
        ///</summary>
        static void CategorizePersonByHeigth()
        {
            int inaltimea = GetIntFromConsole("Introduceti inaltimea in centimetri");

            if (inaltimea < 150)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else if (inaltimea >= 150 && inaltimea <= 165)
            {
                Console.WriteLine("The person is average heighted");
            }
            else if (inaltimea > 165 && inaltimea <= 195)
            {
                Console.WriteLine("'The person is taller.");
            }
            else
            {
                Console.WriteLine("Abnormal height");
            }

            // switch
            switch (inaltimea)
            {

            }

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
            //byte = 255 (numarul maxim) pe care il poate avea
            // int = [-2miliarde, 2miliared] intervalul de valori pe care le poate avea
            byte luna = GetByteFromConsole("Scrie luna:");
            int an = GetIntFromConsole("Scrie anul:");

            //if (luna == 2)
            //{
            //    Console.WriteLine($"Luna {luna} are 28 sau 29 de zile");
            //}
            switch (luna)
            {
                case 2 when IsALeapYear(an) == true:
                    Console.WriteLine($"Luna {luna} are 29 de zile");
                    break;
                case 2 when IsALeapYear(an) == false:
                    Console.WriteLine($"Luna {luna} are 28 de zile");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Luna {luna} are 31 de zile");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Luna {luna} are 30 de zile");
                    break;
                default:
                    Console.WriteLine("Luna pe care ai introdus-o este invalida");
                    break;
            }
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
            //// [1, 2, 3, 4, 5, 6 ...]
            int n, i = 0;

            n = GetIntFromConsole("Introduceti valoarea lui n:");

            int[] array;
            array = new int[n]; // 5 elemente

            while (i < n)
            {
                array[i] = GetIntFromConsole("Introduceti valoarea lui array[" + i + "]:");
                // Console.WriteLine("Valoare lui array[" + i + "] este " + array[i]);
                i++;
            }
            int j;

            for (j = 0; j < n; j++)
            {
                Console.Write(array[j] + " ");
            }
            //while (j < n)
            //{
            //    // Console.WriteLine("Valoare lui array[" + j + "] este " + array[j]);
            //    Console.Write(array[j] + " ");
            //    j++;
            //}

            //int n, i = 0;

            //n = GetIntFromConsole("Introduceti valoarea lui n:");

            //DateTime[] array;
            //array = new DateTime[n]; // 5 elemente

            //while (i < n)
            //{
            //    //array[i] = Console.ReadLine();
            //    Console.WriteLine("Valoare lui array[" + i + "] este " + array[i]);
            //    i++;
            //}
        }

        /// <summary>
        /// Write a C# program to input a number from user and print multiplication table of the given number.
        /// </summary>
        static void MultiplicationTable()
        {
            int n = 10;
            int myNumber = GetIntFromConsole("Get integer number");

            //do
            //{
            //    int result = myNumber * n;
            //    Console.WriteLine(result);
            //    n++;
            //}  while  (n < 9);

            while (n <= 9)
            {
                int result = myNumber * n;
                Console.WriteLine(result);
                n++;
            }
        }

        /// <summary>
        /// Write a C# program to print all odd numbers from 1 to n
        /// </summary>
        static void PrintAllOddnaturalNumberTo100()
        {
            int n = GetIntFromConsole("dati nr:");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Numar impar:{i}");
                }
            }
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
