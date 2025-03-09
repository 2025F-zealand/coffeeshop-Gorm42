using System;
namespace Bridge
{
    public class Car : Vehicle
    {


        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;            
        }



        public double Price(bool haveBroBizz)
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

        //public double WeekEndPrice()
        //{
        //    bool isItWeekend = dayOfTheWeekRepo.DayOfTheWeekMethod();
        //    double priceCounter = 0;
        //    double weekendDiscount = 0.85;
        //
        //    if (isItWeekend == true)
        //    {
        //        priceCounter = 230 * weekendDiscount;
        //    }
        //    return priceCounter;
        //}

        public string VehicleType()
        {
            return "Car";
        }
    }
}
