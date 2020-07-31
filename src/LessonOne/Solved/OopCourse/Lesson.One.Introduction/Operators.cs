using System;

namespace Lesson.One.Introduction
{
    public static class Operators
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Test function for OR (||) operator.
        /// </summary>
        /// <param name="a">An integer number.</param>
        /// <returns>Returns <c>true</c> if <paramref name="a"/> is smaller than <c>10</c>
        /// or if <paramref name="a"/> is even, otherwise return <c>false</c>.</returns>
        public static bool Or(int a)
        {
            /*return true if a is smaller than 10 or if a is even*/
            bool result = a < 10 || a % 2 == 0;
            return result;
        }

        /// <summary>
        /// Test function for OR (||) operator.
        /// </summary>
        /// <param name="a">An integer number.</param>
        /// <returns>Returns <c>true</c> if <paramref name="a"/> is smaller than <c>10</c>
        /// and greater than <c>5</c>, otherwise return <c>false</c>.</returns>
        public static bool And(int a)
        {
            return a < 10 && a > 5;
        }
    }
}
