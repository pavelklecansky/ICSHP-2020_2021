using System;
using System.Runtime.CompilerServices;

namespace UtilsLibrary
{
    /// <summary>
    /// Random number generator in range <-10,10>.
    /// </summary>
    public class RandomNumberGenerator
    {
        const int minValue = -10;
        const int maxValue = 10;
        private static readonly Random random = new Random();

        /// <summary>
        /// Get class name without namespace.
        /// </summary>
        /// <returns>Name of class</returns>
        public static string GetClassName()
        {
            return nameof(RandomNumberGenerator);
        }

        /// <summary>
        /// Get next random number between <-10,10>.
        /// </summary>
        /// <returns>Random number between <-10,10>.</returns>
        public static int Next()
        {
            return random.Next(minValue, maxValue);
        }
    }
}