using System;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Extra helper methods for math.
        /// </summary>
        public class ExtraMath
        {
            /// <summary>
            /// Calculates roots of quadratic equation and return roots in parameters.
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <param name="c"></param>
            /// <param name="x1">First root</param>
            /// <param name="x2">Second root</param>
            /// <returns>Return true if equation exists and false if doesn't.</returns>
            public static bool RootsOfQuadraticEquation(double a, double b, double c, out double x1, out double x2)
            {
                x1 = 0;
                x2 = 0;
                var d = b * b - 4 * a * c;
                if (d == 0)
                {
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    return true;
                }

                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    return true;
                }

                return false;
            }


            /// <summary>
            /// Method for generating random double in range [min..max)
            /// </summary>
            /// <param name="random"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static double RandomDouble(Random random, double min, double max)
            {
                return random.NextDouble() * (max - min) + min;
            }
        }
    }
}