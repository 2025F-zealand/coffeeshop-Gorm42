using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        public readonly double discount = 0.90;

        private string _licensePlate;
        public string LicensePlate 
        {
            get { return _licensePlate; }
            set 
            {   
                if(value.Length < 7)
                {
                    throw new ArgumentException("License plate must be 7 characters long");
                }
                else
                {
                    value = _licensePlate;
                }
            } 
        }

        private DateTime _date;
        public DateTime Date 
        {
            get {return _date; }

            set { value = _date; }
        
        }

        //public abstract double Price();
        //
        //// https://stackoverflow.com/questions/22001952/calculate-discount-price
        //public Vehicle Brobizz(Vehicle vehicle)
        //{
        //    Vehicle reducedPrice = Price() * discount;
        //    return reducedPrice;
        //}
    }
}
