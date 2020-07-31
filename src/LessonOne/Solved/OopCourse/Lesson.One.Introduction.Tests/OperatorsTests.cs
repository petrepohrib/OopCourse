using Xunit;

namespace Lesson.One.Introduction.Tests
{
    public class OperatorsTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        public void AddTest(int a, int b, int expected)
        {
            var actual = Operators.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(20, 10, 10)]
        [InlineData(-1, -2, 1)]
        public void SubtractTest(int a, int b, int expected)
        {
            var actual = Operators.Substract(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(-1, -2, 2)]
        [InlineData(2, 4, 8)]
        [InlineData(12, 10, 120)]
        public void MultiplyTest(int a, int b, int expected)
        {
            var actual = Operators.Multiply(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(12, 4, 3)]
        [InlineData(1, 2, 0.5)]
        public void DivideTest(double a, double b, double expected)
        {
            var actual = Operators.Divide(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(13, false)]
        [InlineData(9, true)]
        public void OrTest(int number, bool expected)
        {
            var actual = Operators.Or(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, false)]
        [InlineData(14, false)]
        [InlineData(9, true)]
        public void AndTest(int number, bool expected)
        {
            var actual = Operators.And(number);
            Assert.Equal(expected, actual);
        }
    }
}
