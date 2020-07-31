using System;
using Xunit;

namespace Lesson.One.Introduction.Tests
{
    public class SwitchTests
    {
        [Theory]
        [InlineData(1, "Monday")]
        [InlineData(2, "Tuesday")]
        [InlineData(3, "Wednesday")]
        [InlineData(4, "Thursday")]
        [InlineData(5, "Friday")]
        [InlineData(6, "Saturday")]
        [InlineData(7, "Sunday")]
        [InlineData(8, "Invalid")]
        public void GetDayOfWeekTest(int dayOfWeek, string expected)
        {
            var actual = Switch.GetDayOfWeek(dayOfWeek);
            Assert.True(expected.Equals(actual, StringComparison.InvariantCultureIgnoreCase));
        }

        [Theory]
        [InlineData(1, 2, '+', 3)]
        [InlineData(5, 4, '-', 1)]
        [InlineData(3, 2, '*', 6)]
        [InlineData(34, 2, '/', 17)]
        public void CalculateTest(double firstOperand, double secondOperand, char @operator, double expected)
        {
            var actual = Switch.Calculate(firstOperand, secondOperand, @operator);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateExceptionTest() =>
            Assert.Throws<ArgumentOutOfRangeException>(() => Switch.Calculate(1, 2, '^'));
    }
}
