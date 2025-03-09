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

        public string Vehicle()
        {
            return "MC";
        }

    }
}
