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

    }
}
