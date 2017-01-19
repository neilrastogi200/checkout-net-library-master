using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.Cards.RequestModels;
using Checkout.ApiServices.Cards.ResponseModels;
using Checkout.ApiServices.SharedModels;
using Product = Checkout.ApiServices.ShoppingCart.RequestModels.Product;

namespace Checkout.ApiServices.ShoppingCart
{
    public class ShoppingCartService
    {
        public HttpResponse<Product> CreateProduct(Product requestModel)
        {
            var createShoppingCartUri = string.Format(ApiUrls.ShoppingCart);
            return new ApiHttpClient().PostRequest<Product>(createShoppingCartUri, AppSettings.SecretKey, requestModel);
        }
    }
}
