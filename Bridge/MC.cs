using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC : Vehicle
    {
        
        public MC(string licensePlate) 
        {
            LicensePlate = licensePlate;
        }


        /// <summary>
        /// Method that checks if the motorcyclist have a broBizz or not and then gives them a discount if they do.
        /// </summary>
        /// <param name="broBizz"></param>
        /// <returns>price</returns>
        public double Price(bool broBizz)
        {
            if(broBizz == true) 
            {
                return 120 * broBizzDiscount;
            }
            else
            {
                return 120;
            }
                
        }

        public string VehicleType()
        {
            return "MC";
        }

    }
}
