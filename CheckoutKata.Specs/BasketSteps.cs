using System;
using TechTalk.SpecFlow;

namespace CheckoutKata.Specs
{
    [Binding]
    public class BasketSteps
    {
        [Given(@"I have an empty basket")]
        public void GivenIHaveAnEmptyBasket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I request my basket")]
        public void WhenIRequestMyBasket()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the basket price should be (.*)")]
        public void ThenTheBasketPriceShouldBe(int price)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
