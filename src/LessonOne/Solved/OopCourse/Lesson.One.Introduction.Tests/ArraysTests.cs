using System;
using System.Linq;
using Xunit;

namespace Lesson.One.Introduction.Tests
{
    public class ArraysTests
    {
        [Fact]
        public void CopyArrayTest()
        {
            var arr = new int[] { 1, 2, 3, 4 };

            var actual = Arrays.CopyArray(arr);

            Assert.False(ReferenceEquals(arr, actual));
            Assert.Equal(arr, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 3)]
        [InlineData(new int[] { 35, 567, 23, 56, 123, 324 }, 567)]
        [InlineData(new int[] { 35, -567, -23, 23456, 12253, 324 }, 23456)]
        public void MaxTest(int[] input, int expected)
        {
            var actual = Arrays.Max(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 35, 567, 23, 56, 123, 324 }, 324)]
        [InlineData(new int[] { 35, -567, -23, 23456, 12253, 324 }, 12253)]
        public void SecondMaxTest(int[] input, int expected)
        {
            var actual = Arrays.SecondMax(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 35, 567, 23, 56, 123, 324 })]
        [InlineData(new int[] { 35, -567, -23, 23456, 12253, 324 })]
        public void OrderTest(int[] input)
        {
            var expected = input.OrderBy(i => i);
            var actual = Arrays.Order(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 35, 567, 23, 56, 123, 324 })]
        [InlineData(new int[] { 35, -567, -23, 23456, 12253, 324 })]
        public void ReverseTest(int[] input)
        {
            var expected = input.Reverse();
            var actual = Arrays.Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2, 1)]
        [InlineData(new int[] { 35, 567, 23, 56, 123, 324 }, 56, 3)]
        [InlineData(new int[] { 35, -567, -23, 23456, 12253, 324 }, -23, 2)]
        [InlineData(new int[] { 35, -567, -23, 23456, 12253, 324 }, 1994, -1)]
        public void FindIndexTest(int[] input, int element, int expected)
        {
            var actual = Arrays.FindIndex(input, element);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SumOfElementsAboveMainDiagonalTest()
        {
            var matrix = new int[,] { { 94, 63, 32 }, { 54, 12, 3 }, { 76, 12, 54 } };
            const int expectedResult = 98;

            var actual = Arrays.SumOfElementsAboveMainDiagonal(matrix);

            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        public void SumOfElementsBellowMainDiagonalTest()
        {
            var matrix = new int[,] { { 94, 63, 32 }, { 54, 12, 3 }, { 76, 12, 54 } };
            const int expectedResult = 142;

            var actual = Arrays.SumOfElementsBellowMainDiagonal(matrix);

            Assert.Equal(expectedResult, actual);
        }
    }
}
