using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinsCoffeeShop
{
    public class Espresso : Coffee
    {
        public Espresso(int discount, string blend) : base(discount, blend)
        {
            
        }
        public override int Price()
        {
            return 38;
        }

        public override string Strength()
        {
            return "Extra Strong";
        }
    }
}
