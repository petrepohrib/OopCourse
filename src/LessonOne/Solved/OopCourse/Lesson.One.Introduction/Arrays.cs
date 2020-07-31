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
            for (var i = 0; i< source.Length; i++)
            {
                if (source[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

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
            /*
             [0,0] [0,1] [0,2] [0, 3]
             [1,0] [1,1] [1,2] [1, 3]
             [2,0] [2,1] [2,2] [2, 3]
             [3,0] [3,1] [3,2] [3, 3]
             */

            for (var i = 1; i < size; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }
    }
}
