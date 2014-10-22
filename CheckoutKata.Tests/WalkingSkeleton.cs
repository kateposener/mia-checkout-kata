using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Policy;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    [TestFixture]
    public class WalkingSkeleton
    {
        [Test]
        public void Should_return_a_web_response()
        {
            var url = "http://mia-checkout-kata.local/";
            var webRequest = WebRequest.Create(url);
            var webResponse = (HttpWebResponse) webRequest.GetResponse();

            var responseStream = webResponse.GetResponseStream();
            Assert.IsNotNull(responseStream);
            var streamReader = new StreamReader(responseStream);
            var response = streamReader.ReadToEnd();

            Assert.That(webResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response, Is.EqualTo("Welcome"));
            
        }
    }
}
