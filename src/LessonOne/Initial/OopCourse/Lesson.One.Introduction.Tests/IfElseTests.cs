using Xunit;

namespace Lesson.One.Introduction.Tests
{
    public class IfElseTests
    {
        [Theory]
        [InlineData(1, "Is odd")]
        [InlineData(2, "Is not odd")]
        [InlineData(3454, "Is not odd")]
        [InlineData(12345, "Is odd")]
        public void IsOddTest(int value, string expected)
        {
            var actual = IfElse.IsOdd(value);
            Assert.True(expected.Equals(actual, System.StringComparison.InvariantCultureIgnoreCase));
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(-3, -2, -2)]
        [InlineData(23456, 2345, 23456)]
        public void MaxTest(int a, int b, int expected)
        {
            var actual = IfElse.Max(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, true)]
        [InlineData(23, true)]
        public void IsPositiveTest(int value, bool expected)
        {
            var actual = IfElse.IsPositive(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('a', true)]
        [InlineData('e', true)]
        [InlineData('i', true)]
        [InlineData('o', true)]
        [InlineData('u', true)]
        [InlineData('b', false)]
        [InlineData('c', false)]
        public void IsVowelTest(char letter, bool expected)
        {
            var actual = IfElse.IsVowel(letter);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 10, 5, true)]
        [InlineData(1, 10, 12, false)]
        public void IsValidTriangleTest(int a, int b, int c, bool expected)
        {
            var actual = IfElse.IsValidTriangle(a, b, c);
            Assert.Equal(expected, actual);
        }
    }
}