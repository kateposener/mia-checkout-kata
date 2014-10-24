using System.Net;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CheckoutKata.Specs
{
    [Binding]
    public class WalkingSkeletonSteps
    {
        private HttpWebResponse _webResponse;

        [When(@"I send a request to the API")]
        public void WhenISendARequestToTheAPI()
        {
            var url = "http://mia-checkout-kata.local/";
            var webRequest = WebRequest.Create(url);
            _webResponse = (HttpWebResponse)webRequest.GetResponse();
        }
        
        [Then(@"I get a response")]
        public void ThenIGetAResponse()
        {
            var response = Browser.ReadResponseStream(_webResponse);

            Assert.That(_webResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response, Is.EqualTo("Welcome"));
        }
    }
}
