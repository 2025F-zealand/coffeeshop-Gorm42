using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Multiplication
    {
        public Multiplication()
        {
            
        }

        /// <summary>
        /// Basic method to calculate the result of multiplying two numbers with each other.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>int with the result of the calculations</returns>
        public int Multiple(int number1, int number2)
        {
            int result;
            result = number1 * number2;
            return result;
        }

    }
}
