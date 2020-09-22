using System;

namespace Katas
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello OOP apprentices!");
            // PrimitiveDataTypesIO();
            // ArithmeticOperationsOfTwoNumbers();
            // FahrenheitToCelsiusConvert();
            // MaximumBetweenTwoNumbers();
            // MaximumBetweenThreeNumbers();
            // NumberOfNotes();
            // LeapYear();
            // RootsOfAQuadraticEquation();
            // NumberOfDays();
            // VowelOrConsonant();
            // ReadArrayFromKeyboard();
            // MultiplicationTable();
            // PrintAllOddnaturalNumberTo100();
            // PerfectNumbers();
            StrongNumber();
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
            char charVar;
            short shortVar;
            int intVar;
            long longVar;
            float floatVar;
            double doubleVar;
            decimal decimalVar;

            string consoleInput;

            Console.WriteLine("Enter value for char: ");
            consoleInput = Console.ReadLine();

            charVar = Convert.ToChar(consoleInput);
            Console.WriteLine($"The char entered is '{charVar}'");

            Console.WriteLine("Enter value for short [-32,768 to 32,767]: ");
            consoleInput = Console.ReadLine();
            shortVar = short.Parse(consoleInput);
            Console.WriteLine($"The short entered is '{shortVar}'");

            Console.WriteLine("Enter value for int [-2,147,483,648 to 2,147,483,647]: ");
            consoleInput = Console.ReadLine();
            intVar = int.Parse(consoleInput);
            Console.WriteLine($"The int entered is '{intVar}'");

            Console.WriteLine("Enter value for long [-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807]: ");
            consoleInput = Console.ReadLine();
            longVar = long.Parse(consoleInput);
            Console.WriteLine($"The long entered is '{longVar}'");

            Console.WriteLine("Enter value for float [±1.5 x 10^−45 to ±3.4 x 10^38]: ");
            consoleInput = Console.ReadLine();
            floatVar = float.Parse(consoleInput);
            Console.WriteLine($"The float entered is '{floatVar}'");

            Console.WriteLine("Enter value for double [±5.0 × 10^−324 to ±1.7 × 10^308]: ");
            consoleInput = Console.ReadLine();
            doubleVar = double.Parse(consoleInput);
            Console.WriteLine($"The double entered is '{doubleVar}'");

            Console.WriteLine("Enter value for decimal [±1.0 x 10^-28 to ±7.9228 x 10^28]: ");
            consoleInput = Console.ReadLine();
            decimalVar = decimal.Parse(consoleInput);
            Console.WriteLine($"The decimal entered is '{decimalVar}'");
        }

        /// <summary>
        /// Write a C# program that reads two natural numbers from the console
        /// and then perform all arithmetic opeartions between them and display the results.
        /// </summary>
        /// <remarks>The arithmetic operations are sum, difference, product, division and modulus.</remarks>
        static void ArithmeticOperationsOfTwoNumbers()
        {
            int a, b;
            int addResult, subtractResult, modulusResult;
            double productResult, divisionResult;
            string consoleInput;

            Console.WriteLine("Enter a value for a: ");
            consoleInput = Console.ReadLine();
            a = int.Parse(consoleInput);
            Console.WriteLine("Enter a value for b: ");
            consoleInput = Console.ReadLine();
            b = int.Parse(consoleInput);

            addResult = a + b;
            subtractResult = a - b;
            modulusResult = a % b;
            productResult = a * b;
            divisionResult = a / (double)b;

            Console.WriteLine($"Add result = {addResult}");
            Console.WriteLine($"Subtract result = {subtractResult}");
            Console.WriteLine($"Modulus result = {modulusResult}");
            Console.WriteLine($"Product result = {productResult}");
            Console.WriteLine($"Division result = {divisionResult}");
        }

        /// <summary>
        /// Write a C# program to input temperature in degree Fahrenheit and converts it to degree Centigrade.
        /// </summary>
        /// <remarks>The formula for convertion is: <c>C° = (F° - 32) * 5/9</c></remarks>
        static void FahrenheitToCelsiusConvert()
        {
            double fahrenheitDegrees, celsiusDegrees;
            Console.WriteLine("Enter the temparature in Fahrenheit: ");
            string consoleInput = Console.ReadLine();
            bool validTemperature = double.TryParse(consoleInput, out fahrenheitDegrees);

            if (!validTemperature)
            {
                Console.WriteLine("Invalid temperature entered.");
            }
            else
            {
                celsiusDegrees = (fahrenheitDegrees - 32) * 5 / 9;
                Console.WriteLine($"The converted temperature is {celsiusDegrees}° C");
            }
        }

        /// <summary>
        /// Write a C# program to find and display the maximum between two numbers read from the console.
        /// </summary>
        static void MaximumBetweenTwoNumbers()
        {
            int a, b;
            string consoleInput;

            Console.WriteLine("Enter a value for a: ");
            consoleInput = Console.ReadLine();
            a = int.Parse(consoleInput);
            Console.WriteLine("Enter a value for b: ");
            consoleInput = Console.ReadLine();
            b = int.Parse(consoleInput);

            if (a > b)
            {
                Console.WriteLine($"{a} is the maximum between {a} and {b}.");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine($"{b} is the maximum between {a} and {b}.");
                }
                else
                {
                    Console.WriteLine($"{a} and {b} are equal.");
                }
            }
        }

        /// <summary>
        /// Write a C# program to find and display the maximum between three numbers read from the console.
        /// </summary>
        static void MaximumBetweenThreeNumbers()
        {
            int a, b, c;
            string consoleInput;

            Console.WriteLine("Enter a value for a: ");
            consoleInput = Console.ReadLine();
            a = int.Parse(consoleInput);
            Console.WriteLine("Enter a value for b: ");
            consoleInput = Console.ReadLine();
            b = int.Parse(consoleInput);
            Console.WriteLine("Enter a value for c: ");
            consoleInput = Console.ReadLine();
            c = int.Parse(consoleInput);

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"{a} is the maximum between {a}, {b} and {c}.");
                }
                else
                {
                    if (a < c)
                    {
                        Console.WriteLine($"{c} is the maximum between {a}, {b} and {c}.");
                    }
                    else
                    {
                        Console.WriteLine($"{a} and {c} are equal and are the maximum between {a}, {b} and {c}.");
                    }
                }
            }
            else
            {
                if (a == b)
                {
                    if (b > c)
                    {
                        Console.WriteLine($"{a} and {b} are equal and are the maximum between {a}, {b} and {c}.");
                    }
                    else
                    {
                        if (b < c)
                        {
                            Console.WriteLine($"{c} is the maximum between {a}, {b} and {c}.");
                        }
                        else
                        {
                            Console.WriteLine($"{a}, {b} and {c} are equal");
                        }
                    }
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine($"{b} is the maximum between {a}, {b} and {c}.");
                    }
                    else
                    {
                        if (b < c)
                        {
                            Console.WriteLine($"{c} is the maximum between {a}, {b} and {c}.");
                        }
                        else
                        {
                            Console.WriteLine($"{b} and {c} are equal and are the maximum between {a}, {b} and {c}.");
                        }
                    }
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
            int ammount;
            int numberOf500Notes = 0, numberOf200Notes = 0, numberOf100Notes = 0, numberOf50Notes = 0, numberOf10Notes = 0, numberOf5Notes = 0, numberOf1Notes = 0;
            Console.WriteLine("Enter the ammount:");
            string consoleInput = Console.ReadLine();
            ammount = int.Parse(consoleInput);

            if (ammount >= 500)
            {
                numberOf500Notes = ammount / 500;
                ammount -= numberOf500Notes * 500;
            }

            if (ammount >= 200)
            {
                numberOf200Notes = ammount / 200;
                ammount -= numberOf200Notes * 200;
            }

            if (ammount >= 100)
            {
                numberOf100Notes = ammount / 100;
                ammount -= numberOf100Notes * 100;
            }

            if (ammount >= 50)
            {
                numberOf50Notes = ammount / 50;
                ammount -= numberOf50Notes * 50;
            }

            if (ammount >= 10)
            {
                numberOf10Notes = ammount / 10;
                ammount -= numberOf10Notes * 10;
            }

            if (ammount >= 5)
            {
                numberOf5Notes = ammount / 5;
                ammount -= numberOf5Notes * 5;
            }

            if (ammount >= 1)
            {
                numberOf1Notes = ammount / 100;
            }

            Console.WriteLine($"Number of 500 notes: {numberOf500Notes}");
            Console.WriteLine($"Number of 200 notes: {numberOf200Notes}");
            Console.WriteLine($"Number of 100 notes: {numberOf100Notes}");
            Console.WriteLine($"Number of 50 notes: {numberOf50Notes}");
            Console.WriteLine($"Number of 10 notes: {numberOf10Notes}");
            Console.WriteLine($"Number of 5 notes: {numberOf5Notes}");
            Console.WriteLine($"Number of 1 notes: {numberOf1Notes}");
        }

        /// <summary>
        /// Write a C# program that read a year from the console and checks if that year is a leap year.
        /// </summary>
        /// <remarks>A year is said to be leap year, if the year is exactly divisible by 4 but and not divisible by 100.
        /// Year is also a leap year if it is exactly divisible by 400.</remarks>
        static void LeapYear()
        {
            int year;
            Console.WriteLine("Enter the year:");
            string consoleInput = Console.ReadLine();
            year = int.Parse(consoleInput);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is a regular year");
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

            double a, b, c;
            double r1, r2;
            string consoleInput;

            Console.WriteLine("Enter a value for a: ");
            consoleInput = Console.ReadLine();
            a = int.Parse(consoleInput);
            Console.WriteLine("Enter a value for b: ");
            consoleInput = Console.ReadLine();
            b = int.Parse(consoleInput);
            Console.WriteLine("Enter a value for c: ");
            consoleInput = Console.ReadLine();
            c = int.Parse(consoleInput);

            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0)
            {
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"The roots of the equation are: {r1} and {r2}");
            }

            if (delta == 0)
            {
                r1 = r2 = -b / (2 * a);
                Console.WriteLine($"The roots of the equation are: {r1} and {r2}");
            }

            if (delta < 0)
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
                string imaginaryRoot1, imaginaryRoot2;
                imaginaryRoot1 = $"{realPart} + i * {imaginaryPart}";
                imaginaryRoot2 = $"{realPart} - i * {imaginaryPart}";
                Console.WriteLine($"The roots of the equation are: {imaginaryRoot1} and {imaginaryRoot2}");
            }
        }

        /// <summary>
        /// Write a C# program to input month number and print total number of days in month.
        /// </summary>
        static void NumberOfDays()
        {
            int month;
            Console.WriteLine("Enter the month:");
            string consoleInput = Console.ReadLine();
            month = int.Parse(consoleInput);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 2:
                    Console.WriteLine("28/29 days");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter month number between 1-12");
                    break;
            }
        }

        /// <summary>
        /// Write a C# program to input an alphabet letter and check whether it is vowel or consonant.
        /// </summary>
        /// <remarks>English alphabets 'a', 'e', 'i', 'o', 'u' both lowercase and uppercase are known as vowels.</remarks>
        static void VowelOrConsonant()
        {
            char letter;
            Console.WriteLine("Enter value for char: ");
            string consoleInput = Console.ReadLine();

            letter = char.Parse(consoleInput);

            switch (letter)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                case 'A':
                    Console.WriteLine("Vowel");
                    break;
                case 'E':
                    Console.WriteLine("Vowel");
                    break;
                case 'I':
                    Console.WriteLine("Vowel");
                    break;
                case 'O':
                    Console.WriteLine("Vowel");
                    break;
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }

        /// <summary>
        /// Write a C# program that reads from the console a natural number n and after that reads and display an array
        /// with size n.
        /// </summary>
        static void ReadArrayFromKeyboard()
        {
            int[] array;
            int n, i = 0;
            string consoleInput;

            Console.WriteLine("Enter a value for n");
            consoleInput = Console.ReadLine();
            n = int.Parse(consoleInput);

            array = new int[n];

            while (i < n)
            {
                Console.WriteLine($"Enter value for array[{i}]");
                consoleInput = Console.ReadLine();
                array[i] = int.Parse(consoleInput);
                i++;
            }

            for(i = 0; i < n; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }

        /// <summary>
        /// Write a C# program to input a number from user and print multiplication table of the given number.
        /// </summary>
        static void MultiplicationTable()
        {
            int number;
            short i = 1;
            Console.WriteLine("Enter the number:");
            string consoleInput = Console.ReadLine();
            number = int.Parse(consoleInput);

            Console.WriteLine("Multiplication table for " + number);
            do
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
                i++;
            } while (i <= 9);
        }

        /// <summary>
        /// Write a C# program to print all odd numbers from 1 to n
        /// </summary>
        static void PrintAllOddnaturalNumberTo100()
        {
            for (short i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
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
            int n, i = 1;
            string consoleInput;

            Console.WriteLine("Enter a value for n");
            consoleInput = Console.ReadLine();
            n = int.Parse(consoleInput);

            while (i <= n)
            {
                int divisorsSum = 0;
                for (short j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        divisorsSum += j;
                    }
                }

                if (divisorsSum == i)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
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
            int number, numberClone, digitFactorialSum = 0;
            string consoleInput;

            Console.WriteLine("Enter the number");
            consoleInput = Console.ReadLine();
            number = int.Parse(consoleInput);
            numberClone = number;


            while(numberClone != 0)
            {
                int digit = numberClone % 10;
                int factorial = 1;
                for(int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                digitFactorialSum += factorial;
                numberClone /= 10;
            }

            if (digitFactorialSum == number)
            {
                Console.WriteLine("Number is a strong number");
            }
            else
            {
                Console.WriteLine("Number is not a strong number");
            }
        }
    }
}
