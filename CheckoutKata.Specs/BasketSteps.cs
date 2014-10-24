using System;
using System.Net;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CheckoutKata.Specs
{
    [Binding]
    public class BasketSteps
    {
        private HttpWebResponse _webResponse;

        [Given(@"I have an empty basket")]
        public void GivenIHaveAnEmptyBasket()
        {
            var url = new Uri("http://mia-checkout-kata.local/baskets");

            _webResponse = Browser.Post(url);

            Assert.That(_webResponse.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [When(@"I request my basket")]
        public void WhenIRequestMyBasket()
        {
            var basketUrl = _webResponse.GetResponseHeader("Location");
            _webResponse = Browser.Get(basketUrl);
            Assert.That(_webResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Then(@"the basket price should be (.*)")]
        public void ThenTheBasketPriceShouldBe(int price)
        {
            var body = Browser.ReadResponseStream(_webResponse);

            Assert.That(body, Is.EqualTo(price.ToString()));
        }
    }
}
