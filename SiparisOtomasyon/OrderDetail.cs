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
    }
}
