using System;

namespace Lesson.One.Introduction
{
    public static class Loops
    {
        /// <summary>
        /// Gets the first n natural numbers using do while loop.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>An array containing the first n natural numbers or <c>null</c>.</returns>
        public static int[] GetFirstNNaturalNumbers_DoWhile(int n)
        {
            if (n <= 0)
            {
                return null;
            }

            var result = new int[n];
            var i = 0;

            if (i == n)
            {
                return result;
            }

            do
            {
                result[i] = i;
                i++;
            } while (i < n);

            return result;
        }

        /// <summary>
        /// Gets the first n natural numbers using while loop.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>An array containing the first n natural numbers or <c>null</c>.</returns>
        public static int[] GetFirstNNaturalNumbers_While(int n)
        {
            if (n <= 0)
            {
                return null;
            }

            var result = new int[n];
            var i = 0;
            while (i < n)
            {
                result[i] = i;
                i++;
            }
            return result;
        }

        /// <summary>
        /// Gets the first n natural numbers using for loops.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>An array containing the first n natural numbers or <c>null</c>.</returns>
        public static int[] GetFirstNNaturalNumbers_For(int n)
        {
            if (n <= 0)
            {
                return null;
            }

            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                result[i] = i;
            }
            return result;
        }

        /// <summary>
        /// Sums the digits of the given number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The sum of the digits of the <paramref name="number"/></returns>
        public static int SumOfTheDigits(int number)
        {
            var sum = 0;

            while (number / (double)10 != 0)
            {
                //sum = sum + number % 10;
                // number = number / 10;

                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        /// <summary>
        /// Reverses the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The reverse of the number.</returns>
        public static int Reverse(int number)
        {
            var reverse = 0;

            while (number / (double)10 != 0)
            {
                reverse = (reverse * 10) + (number % 10);
                number /= 10;
            }

            return reverse;
        }

        /// <summary>
        /// Determines whether the specified number is palindrome. (e.g. 324423, 11, 101)
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumberPalindrome(int number)
        {
            var reverse = 0;
            var numberCopy = number;

            while (numberCopy / (double)10 != 0)
            {
                reverse = (reverse * 10) + (numberCopy % 10);
                numberCopy /= 10;
            }

            return reverse == number;
        }

        /// <summary>
        /// Determines whether the specified text is palindrome. (e.g. abba, ana, 101)
        /// </summary>
        /// <param name="text">The input text.</param>
        /// <returns>
        ///   <c>true</c> if the specified text is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsStringPalindrome(string text)
        {
            if (text == null)
            {
                return false;
            }

            var begin = 0;
            var end = text.Length - 1;
            var isPalindrome = true;

            while (begin < end && isPalindrome)
            {
                if (text[begin] != text[end])
                {
                    isPalindrome = false;
                }

                begin++;
                end--;
            }

            return isPalindrome;
        }

        /// <summary>
        /// Computes the digit frequency of a number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>An array </returns>
        /// <exception cref="System.NotImplementedException">Implement me 🥺</exception>
        public static int[] DigitFrequency(int number)
        {
            var frequencyMap = new int[10];

            while (number / (double)10 != 0)
            {
                var currentDigit = number % 10;
                frequencyMap[currentDigit]++;
                number /= 10;
            }

            return frequencyMap;
        }
    }
}
