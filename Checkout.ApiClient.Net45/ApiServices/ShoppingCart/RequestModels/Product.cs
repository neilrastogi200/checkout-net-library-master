using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.ShoppingCart.RequestModels
{
    public class Product
    {
        public int ProductId { set; get; }

        public string Name { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }
    }
}
