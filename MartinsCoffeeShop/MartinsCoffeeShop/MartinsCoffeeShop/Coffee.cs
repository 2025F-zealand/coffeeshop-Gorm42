using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinsCoffeeShop
{
    public abstract class Coffee
    {
        public string Blend { get; set; }
        public int Discount { get; set; }
        protected Coffee(int discount, string blend)
        {
            if (discount > 5)
            {
                throw new ArgumentException("You cannot give more than 5kr in discount.");
            }

            if (discount < 0)
            {
                throw new ArgumentException("You cannot give a negative discount, much as we would like to.");
            }

            this.Discount = discount;
            this.Blend = blend;
        }
        public abstract int Price();

        public abstract string Strength();

        public override string ToString()
        {
            return $"This coffee costs {this.Price()}, and is of {this.Strength()} strength, using {this.Blend} blend.";
        }
    }
}
