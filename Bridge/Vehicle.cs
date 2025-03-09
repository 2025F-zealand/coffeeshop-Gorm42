using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        public readonly double broBizzDiscount = 0.90;

        private string _licensePlate;

        /// <summary>
        /// Property for the license plate of the vehicle, have a constraint where the license plate must be 7 characters long.
        /// </summary>
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
        public Vehicle()
        {
            
        }

    }
}
