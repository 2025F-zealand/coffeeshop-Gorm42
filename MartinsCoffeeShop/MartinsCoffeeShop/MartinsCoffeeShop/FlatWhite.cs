using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinsCoffeeShop
{
    public class FlatWhite : Coffee
    {
        public FlatWhite(int discount, string blend) : base(discount, blend)
        {
            
        }

        public override string Strength()
        {
            return "Medium";
        }

        public override int Price()
        {
            return 30;
        }
    }
}
