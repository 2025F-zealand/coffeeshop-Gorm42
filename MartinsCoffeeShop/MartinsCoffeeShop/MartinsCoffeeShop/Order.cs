using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinsCoffeeShop
{
    public class Order
    {
        public string BaristaName { get; set; }
        public string CustomerName { get; set; }
        public string ToGoOrStay {  get; set; }
        public string? OrderComment { get; set; }
        public List<Coffee> ListOfCoffeesInTheOrder { get; set; } = new List<Coffee>();

        
        /// <summary>
        ///Ctor that takes single coffe object
        /// </summary>
        /// <param name="baristaName"></param>
        /// <param name="customerName"></param>
        /// <param name="toGoOrStay"></param>
        /// <param name="orderComment"></param>
        /// <param name="coffee"></param>
        public Order(string baristaName, string customerName,
            string toGoOrStay, string orderComment, Coffee coffee)
        {
            BaristaName = baristaName;
            CustomerName = customerName;
            ToGoOrStay = toGoOrStay;
            OrderComment = orderComment;
            ListOfCoffeesInTheOrder.Add(coffee);
        }

        /// <summary>
        /// Takes multiple Coffe Orders
        /// </summary>
        /// <param name="baristaName"></param>
        /// <param name="customerName"></param>
        /// <param name="toGoOrStay"></param>
        /// <param name="orderComment"></param>
        /// <param name="coffeesOrdered"></param>
        public Order(string baristaName, string customerName, 
            string toGoOrStay, string orderComment, IEnumerable<Coffee> coffeesOrdered) 
        {
            BaristaName = baristaName;
            CustomerName = customerName;
            ToGoOrStay = toGoOrStay;
            OrderComment = orderComment;
            if (coffeesOrdered != null)
            {
                ListOfCoffeesInTheOrder.AddRange(coffeesOrdered);
            }
            
        }

        /// <summary>
        /// Takes all the coffee items and adds their price together.
        /// </summary>
        /// <param name="coffeeList"></param>
        /// <returns></returns>
        public int TotalPrice(List<Coffee> coffeeList)
        {
            int totalPrice = 0;
            foreach (Coffee c in coffeeList)
            {
                totalPrice = c.Price() + totalPrice;
            }
            return totalPrice;
        }

        public int TotalNumberOfCoffees(List<Coffee> coffeeList)
        {
            int totalNumberOfCoffees = 0;
            foreach(Coffee c in coffeeList)
            {
                totalNumberOfCoffees++;
            }
            return totalNumberOfCoffees;
        }

        public int TotalDiscount (List<Coffee> coffeeList)
        {
            int totalDiscount = 0;
            foreach(Coffee c in coffeeList)
            {
                totalDiscount = c.Discount + totalDiscount;
            }
            return totalDiscount;
        }

        public override string ToString()
        {
            return $"Your order The total price of the order is {}";
        }

    }
}
