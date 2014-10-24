using System.Collections.Generic;
using System.Net;
using System.Web;

namespace CheckoutKata.Web
{
    public class CreateBasketHandler : IHttpHandler

    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.StatusCode = (int) HttpStatusCode.Created;
            context.Response.RedirectLocation = "http://mia-checkout-kata.local/baskets/1";
            var Basket = new Basket {Items = "", Price = 0};
        }

        public bool IsReusable { get; private set; }
    }
}