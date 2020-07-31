namespace Lesson.One.Introduction
{
    public static class IfElse
    {
        /// <summary>
        /// Determines whether the specified numer is odd.
        /// </summary>
        /// <param name="a">The input number.</param>
        /// <returns>Returns "Is odd" if the input is odd else returns "Is not odd".</returns>
        public static string IsOdd(int a)
        {
            // string result = string.Empty;
            // string result = "";
            var result = string.Empty;

            if (a % 2 != 0)
            {
                result = "Is odd";
            }
            else
            {
                result = "Is not odd";
            }

            return result;
        }

        /// <summary>
        /// Determines the maximum between two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Returns the maximum between <paramref name="a"/> and <paramref name="b"/></returns>
        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        /// <summary>
        /// Determines whether the specified number to test is positive.
        /// </summary>
        /// <param name="numberToTest">The number to test.</param>
        /// <returns>
        ///   <c>true</c> if the specified number to test is positive; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPositive(int numberToTest)
        {
            if (numberToTest >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified letter is vowel.
        /// </summary>
        /// <param name="letter">The letter.</param>
        /// <returns>
        ///   <c>true</c> if the specified letter is vowel; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'
                || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines if the given sides could describe a valid triangle.
        /// In a triangle, the sum of any to sides must be greater than the third side.
        /// </summary>
        /// <param name="firstSide">The first side.</param>
        /// <param name="secondSide">The second side.</param>
        /// <param name="thirdSide">The third side.</param>
        /// <returns>
        ///   <c>true</c> if the sides describe a valid triangle; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidTriangle(int firstSide, int secondSide, int thirdSide)
        {
            //if (firstSide + secondSide > thirdSide)
            //{
            //    if (secondSide + thirdSide > firstSide)
            //    {
            //        if (firstSide + thirdSide > secondSide)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
            //}

            if (firstSide + secondSide <= thirdSide
                || firstSide + thirdSide <= secondSide
                || secondSide + thirdSide <= firstSide)
            {
                return false;
            }

            return true;
        }
    }
}
