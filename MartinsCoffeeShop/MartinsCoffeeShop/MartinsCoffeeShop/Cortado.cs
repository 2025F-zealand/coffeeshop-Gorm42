using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinsCoffeeShop
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(int discount, string blend) : base(discount, blend)
        {
            
        }
        public override int Price()
        {
            return 25;
        }
        public override string Strength()
        {
            return "Medium";
        }
        public int MlMilk()
        {
            return 40;
        }
    }
}
