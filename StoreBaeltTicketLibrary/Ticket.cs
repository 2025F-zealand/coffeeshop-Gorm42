using Bridge;
namespace StoreBaeltTicketLibrary
{
    public class Ticket
    {
        public readonly double broBizzDiscount = 0.90;
        private readonly Car car;
        private readonly MC mC;

        private string _licensePlate;

        /// <summary>
        /// Property for the license plate of the vehicle, have a constraint where the license plate must be 7 characters long.
        /// </summary>
        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value.Length < 7)
                {
                    throw new ArgumentException("License plate must be 7 characters long");
                }
                else
                {
                    value = _licensePlate;
                }
            }
        }

        public Ticket(string licensePlate) 
        {
            LicensePlate = licensePlate;
        }

        /// <summary>
        /// Allright. So. This method for the cars checks a couple of things. First off, we send a bool with the method, to see if the car-ist, 
        /// have a brobizz or not. Then we have a bool variable in the arrange part of the method, where we give it the value of another method
        /// DayOfTheWeekMethod. See notes for that method to explain it. The if statement checks whether or not it is weekend, then if it is, 
        /// the first discount checks in. If the driver also has a brobizz, another discount will be added on and this result will be returned.
        /// If it is not weekend, the method will check if the driver has a brobizz, and if so, return the price with the brobizz discount. If not,
        /// the method will simply return the price without any discounts.
        /// </summary>
        /// <param name="haveBroBizz"></param>
        /// <returns> double. 230 without any discounts.</returns>
        public double PriceForCars(bool haveBroBizz)
        {
            bool isItWeekend = DayOfTheWeekMethod();
            double priceCounter = 0;
            double weekendDiscount = 0.85;


            if (isItWeekend == true)
            {
                priceCounter = 230 * weekendDiscount;

                if (haveBroBizz == true)
                {
                    priceCounter = priceCounter * broBizzDiscount;
                }
                return priceCounter;

            }
            else if (haveBroBizz == true)
            {
                return priceCounter = 230 * broBizzDiscount;
            }
            else
            {
                return 230;
            }
        }

        /// <summary>
        /// Method that checks if the motorcyclist have a broBizz or not and then gives them a discount if they do.
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns>price</returns>
        public double PriceForMotorCycles(bool broBizz)
        {
            if (broBizz == true)
            {
                return 120 * broBizzDiscount;
            }
            else
            {
                return 120;
            }

        }

        /// <summary>
        /// A method to be used in price to determine whether or not there should be a weekend discount. If it is Saturday or Sunday, the method
        /// will return true otherwise false.
        /// </summary>
        /// <returns></returns>
        public bool DayOfTheWeekMethod()
        {
            DayOfWeek whichDayIsIt = DateTime.Now.DayOfWeek;
            if (whichDayIsIt == DayOfWeek.Sunday || whichDayIsIt == DayOfWeek.Saturday)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //https://stackoverflow.com/questions/4139287/get-the-monday-and-sunday-for-a-certain-datetime-in-c-sharp

        /// <summary>
        /// Method to return the type of vehicle.
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
