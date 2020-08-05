using System;

namespace Lesson.One.Introduction
{
    public static class Arrays
    {
        public static int[] CopyArray(int[] source)
        {
            if (source == null)
            {
                return default;
            }

            var copy = new int[source.Length];
            for (var i = 0; i < source.Length; i++)
            {
                copy[i] = source[i];
            }
            return copy;
        }

        public static int Max(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var max = source[0];

            for (var i = 1; i < source.Length; i++)
            {
                if (source[i] > max)
                {
                    max = source[i];
                }
            }

            return max;
        }

        public static int SecondMax(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var currentMax = source[0];
            var previousMax = int.MinValue;

            for (var i = 1; i < source.Length; i++)
            {
                if (source[i] > currentMax)
                {
                    previousMax = currentMax;
                    currentMax = source[i];
                }

                if (source[i] > previousMax && source[i] < currentMax)
                {
                    previousMax = source[i];
                }
            }

            return previousMax;
        }

        public static int[] Order(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (var i = 0; i < source.Length - 1; i++)
            {
                for (var j = i + 1; j < source.Length; j++)
                {
                    if (source[i] > source[j])
                    {
                        var temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                    }
                }
            }

            return source;
        }

        public static int[] Reverse(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var reverse = new int[source.Length];

            for (var i = source.Length - 1; i >= 0; i--)
            {
                reverse[source.Length - i - 1] = source[i];
            }

            return reverse;
        }

        public static int FindIndex(int[] source, int element)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (source[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

        /*
            [0,0] [0,1] [0,2] [0, 3]
            [1,0] [1,1] [1,2] [1, 3]
            [2,0] [2,1] [2,2] [2, 3]
            [3,0] [3,1] [3,2] [3, 3]
        */

        public static int SumOfElementsAboveMainDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new FormatException("In order to have a main diagonal the matrix has to be square");
            }

            var sum = 0;
            var size = matrix.GetLength(0);

            for (var i = 0; i < size - 1; i++)
            {
                for (var j = i + 1; j < size; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        public static int SumOfElementsBellowMainDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new FormatException("In order to have a main diagonal the matrix has to be square");
            }

            var sum = 0;
            var size = matrix.GetLength(0);

            for (var i = 1; i < size; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        /// <summary>
        /// In an alien language, surprisingly they also use english lowercase letters, but possibly in a different <c>order</c>.
        /// The <c>order</c> of the alphabet is some permutation of the lowercase letters.
        /// </summary>
        /// <param name="alienWords">A sequence of words written in an alien language. At least 1 word, max 100 words, each word length between 1 and 20.</param>
        /// <param name="order">The order of the alphabet (length 26).</param>
        /// <returns>
        /// Given <paramref name="alienWords"/> and <paramref name="order"/>, return <c>true</c> if and only if the given <paramref name="alienWords"/>
        /// are sorted lexicographicaly in this alien language.
        /// </returns>
        public static bool IsAlienSorted(string[] alienWords, string order)
        {
            var alphabetOrder = new int[26];

            for (var i = 0; i < order.Length; i++)
            {
                alphabetOrder[order[i] - 'a'] = i;
            }

            for (var i = 0; i < alienWords.Length - 1; i++)
            {
                for (var j = i + 1; j < alienWords.Length; j++)
                {
                    var minLength = Math.Min(alienWords[i].Length, alienWords[j].Length);
                    for (var k = 0; k < minLength; k++)
                    {
                        var iChar = alienWords[i][k];
                        var jChar = alienWords[j][k];

                        if (alphabetOrder[iChar - 'a'] < alphabetOrder[jChar - 'a'])
                        {
                            break;
                        }

                        if (alphabetOrder[iChar - 'a'] > alphabetOrder[jChar - 'a'])
                        {
                            return false;
                        }

                        if (k == minLength - 1 && alienWords[i].Length > alienWords[j].Length)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
