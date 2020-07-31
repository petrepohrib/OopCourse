using System.Linq;
using Xunit;

namespace Lesson.One.Introduction.Tests
{
    public class LoopsTests
    {
        [Fact]
        public void GetFirstNNaturalNumbers_DoWhileTest()
        {
            const int n = 20;
            var expected = Enumerable.Range(0, n);
            var actual = Loops.GetFirstNNaturalNumbers_DoWhile(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFirstNNaturalNumbers_DoWhileInvalidInputTest()
        {
            const int n = -3;
            var expected = default(int[]);
            var actual = Loops.GetFirstNNaturalNumbers_DoWhile(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFirstNNaturalNumbers_WhileTest()
        {
            const int n = 20;
            var expected = Enumerable.Range(0, n);
            var actual = Loops.GetFirstNNaturalNumbers_While(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFirstNNaturalNumbers_WhileInvalidInputTest()
        {
            const int n = -3;
            var expected = default(int[]);
            var actual = Loops.GetFirstNNaturalNumbers_While(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFirstNNaturalNumbers_ForTest()
        {
            const int n = 20;
            var expected = Enumerable.Range(0, n);
            var actual = Loops.GetFirstNNaturalNumbers_For(n);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFirstNNaturalNumbers_ForInvalidInputTest()
        {
            const int n = -3;
            var expected = default(int[]);
            var actual = Loops.GetFirstNNaturalNumbers_For(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(12, 3)]
        [InlineData(123, 6)]
        [InlineData(97971, 33)]
        public void SumOfTheDigitsTest(int number, int expected)
        {
            var actual = Loops.SumOfTheDigits(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(12, 21)]
        [InlineData(123, 321)]
        [InlineData(97971, 17979)]
        public void ReverseTest(int number, int expected)
        {
            var actual = Loops.Reverse(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(22, true)]
        [InlineData(23, false)]
        [InlineData(123, false)]
        [InlineData(121, true)]
        public void IsNumberPalindromeTest(int number, bool expected)
        {
            var actual = Loops.IsNumberPalindrome(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", true)]
        [InlineData("mananam", true)]
        [InlineData("petrut", false)]
        [InlineData(null, false)]
        [InlineData("oop", false)]
        [InlineData("racecar", true)]
        public void IsStringPalindromeTest(string text, bool expected)
        {
            var actual = Loops.IsStringPalindrome(text);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0})]
        [InlineData(23, new int[] { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0})]
        [InlineData(2233, new int[] { 0, 0, 2, 2, 0, 0, 0, 0, 0, 0})]
        [InlineData(998899, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 2, 4})]
        public void DigitFrequencyTest(int number, int[] expectedFrequency)
        {
            var actual = Loops.DigitFrequency(number);
            Assert.Equal(expectedFrequency, actual);
        }
    }
}
