using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Division
    {
        /// <summary>
        /// Empty Ctor for now, to allow for easier Unittesting.
        /// </summary>
        public Division() { }
        /// <summary>
        /// Basic method to calculate the division of two numbers with each other.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>int with the result of the calculations</returns>
        public int Divide(int number1, int number2)
        {
            int result;
            result = (number1 / number2);
            return result;

        }

    }
}
