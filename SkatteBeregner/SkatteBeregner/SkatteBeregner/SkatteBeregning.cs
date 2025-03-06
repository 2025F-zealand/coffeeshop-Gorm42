using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkatteBeregner.Borger;

namespace SkatteBeregner
{
    public class SkatteBeregning
    {

        public double BeregnSkat(TypeAfBorger typeBorger, double indkomst)
        {
            double skat = 0;

            if (indkomst == 0)
            {
                return skat;
            }
            else if (indkomst <= 20000 && typeBorger != TypeAfBorger.Pensionist)
            {
               skat = BeregnLavSkat(indkomst);
               return skat;
            }
            else if (indkomst > 20000 && typeBorger != TypeAfBorger.Pensionist)
            {
                skat = BeregnHøjSkat(indkomst);
                return skat;
            }
            else 
            {
                skat = BeregnSpecialSkat(indkomst);
                return skat;
            }
        }

        public double BeregnLavSkat(double indkomst)
        {
            double skat;
            skat = 0.10 * indkomst;
            return skat;
        }

        public double BeregnHøjSkat(double indkomst)
        {
            double skat;
            skat = 0.20 * indkomst;
            return skat;
        }

        public double BeregnSpecialSkat(double indkomst)
        {
            double skat;
            skat = 0.05 * indkomst;
            return skat;
        }


    }        
}
