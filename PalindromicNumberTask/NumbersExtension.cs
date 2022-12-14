using System;
using System.Globalization;

#pragma warning disable CA1062

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{number}");
            }

            var c = number.ToString(CultureInfo.InvariantCulture);
            if (IsPalinrom(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalinrom(string name, int i = 0)
        {
            if (name[i] != name[name.Length - i - 1])
            {
                return false;
            }

            if (i == name.Length - 1)
            {
                return true;
            }

            if (i < name.Length - 1)
            {
                i++;
            }

            return IsPalinrom(name, i);
        }
    }
}
