using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinsCoffeeShop
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount, string blend) : base(discount, blend)
        {
            
        }
        public override int Price()
        {
            return 20;
        }
        public override string Strength()
        {
            return "Strong";
        }
    }
}
