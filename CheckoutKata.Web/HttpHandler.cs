using System.Web;

namespace CheckoutKata.Web
{
    public class HttpHandler :IHttpHandler 
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Welcome");
        }

        public bool IsReusable { get; private set; }
    }
}