using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public double Tax { get; set; }
        Product Product;
        public OrderDetail(Product Product, int Quantity)
        {
            Tax = Product.Tax;
            this.Quantity = Quantity;
            this.Product = Product;
            calcSubTotal();
            calcWeight();
        }
        public double calcSubTotal()
        {
            double subTotal = Product.Price * Quantity;
            return subTotal;
        }
        public double calcWeight()
        {
            double weightTotal = Product.Weight * Quantity;
            return weightTotal;
        }
    }
}
