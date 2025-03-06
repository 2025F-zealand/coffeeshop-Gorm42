using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkatteBeregner
{
    public class Borger
    {
        public enum TypeAfBorger
        {
            Studerende = 0,
            Underviser = 1,
            Pensionist = 2,
        }

        public TypeAfBorger _type;
        public TypeAfBorger TypeBorger
        {
            get
            {
                return _type;
            }

            set
            {
                if (!Enum.IsDefined(typeof(TypeAfBorger), value))
                {
                    throw new ArgumentException("Du skal skrive hvilken type borger vi har med at gøre. \n Skriv 0 for stuerende \n Skriv 1 for Underviser \n Skriv 2 for Pensionist");
                }
                _type = value;
            }
        }
        public double Indkomst { get; set; }
        public string Name { get; set; }

        public Borger(string name, TypeAfBorger typeBorger, double indkomst)
        {
            Name = name;
            TypeBorger = typeBorger;
            Indkomst = indkomst;
        }


        //SkatteBeregning nySkat = new SkatteBeregning(BeregnSkat(arne));

      


        /*
        public void BeregnSkat(TypeAfBorger typeBorger, double indkomst)
        {
            if (indkomst == 0)
            {
                Console.WriteLine("Du skal ikke betale skat.");
            }
            //Hvis indkomst er <= 20000
            else if (indkomst <= 20000)
            {

            }
            //Hvis indkomst er > 20000
            else if (indkomst > 20000)
            {

            }

        }

        public double BeregnLavSkat(double indkomst)
        {
            indkomst = 0.90 * indkomst;
            return indkomst;
        }

        public double BeregnHøjSkat(double indkomst)
        {
            indkomst = 0.80 * indkomst;
            return indkomst;
        }

        public double BeregnSpecialSkat(double indkomst)
        {
            indkomst = 0.95 * indkomst;
            return indkomst;
        }

         */

    }
}
