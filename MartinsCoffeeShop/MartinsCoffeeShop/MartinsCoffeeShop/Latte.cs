using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinsCoffeeShop
{
    public class Latte : Coffee, IMilk
    {
        public Latte(int discount, string blend) : base(discount, blend)
        {
            
        }
        public override int Price()
        {
            return 40;
        }
        public override string Strength()
        {
            return "Weak";
        }
        public int MlMilk()
        {
            return 200;
        }
    }
}
