namespace CalculatorLibrary
{
    public class Addition
    {
        public Addition() { }
        /// <summary>
        /// Basic method to calculate the outcome of adding two numbers to each other
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>int with the result of the calculations</returns>
        public int Plus(int number1, int number2) 
        {
            int result = 0;
            result = number1 + number2;
            return result;
        }

    }
}
