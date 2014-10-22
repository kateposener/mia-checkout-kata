using System;
using System.IO;
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

            var responseStream = _webResponse.GetResponseStream();
            Assert.IsNotNull(responseStream);
            var streamReader = new StreamReader(responseStream);
            var response = streamReader.ReadToEnd();

            Assert.That(_webResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response, Is.EqualTo("Welcome"));
        }
    }
}
