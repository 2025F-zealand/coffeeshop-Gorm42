using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Subtraction
    {
        /// <summary>
        /// Empty constructor for now due to Unit testing
        /// </summary>
        public Subtraction() { }
        /// <summary>
        /// Basic method to calculate Subtraction from only two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>int with the result of the calculations</returns>
        public int Minus(int number1, int number2)
        {
            int result = 0;
            result = number1 - number2;
            return result;
            
        }
        
    }
}
