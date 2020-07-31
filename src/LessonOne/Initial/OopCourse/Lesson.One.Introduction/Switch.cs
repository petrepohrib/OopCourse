using System;

namespace Lesson.One.Introduction
{
    public static class Switch
    {
        /// <summary>
        /// Gets the day of week as a string (e.g. "Monday") for the given day as a number.
        /// If the day of week is not between <c>1</c> and <c>7</c> return "Invalid";
        /// </summary>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns>A string representing the day of week (e.g. "Monday") or "Invalid" if <paramref name="dayOfWeek"/>
        /// is not in the interval [1, 7]</returns>
        public static string GetDayOfWeek(int dayOfWeek)
        {
            throw new NotImplementedException("Implement me 🥺");
        }

        /// <summary>
        /// Calculates the result of applying the operator (+, -, *, /) to the given operands.
        /// Basically a simple calculator. 
        /// </summary>
        /// <param name="firstOperand">The first operand.</param>
        /// <param name="secondOperand">The second operand.</param>
        /// <param name="operator">The operator.</param>
        /// <returns>The result of the operation.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws if <paramref name="operator"/> is out of range.</exception>
        /// <exception cref="DivideByZeroException">Throws if <paramref name="secondOperand"/> is 0 and
        /// <paramref name="operator"/> is /.</exception>
        public static double Calculate(double firstOperand, double secondOperand, char @operator)
        {
            throw new NotImplementedException("Implement me 🥺");
        }
    }
}
