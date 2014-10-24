using System.Net;
using System.Web;

namespace CheckoutKata.Web
{
    public class GetBasketHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.StatusCode = (int) HttpStatusCode.OK;
            var basket = new Basket { Items = "", Price = 0 };
            context.Response.Write(basket.Price);
        }

        public bool IsReusable { get; private set; }
    }
}