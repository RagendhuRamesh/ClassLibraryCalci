using ClassLibCalci;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectCalculator.StepDefinitions
{
    [Binding]
    public class Calculator1StepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calci calci;
        private int result;
        public Calculator1StepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calci = new Calci();
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            calci.num1 = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            calci.num2 = p0;
        }

        [When(@"the two numbers are Multi")]
        public void WhenTheTwoNumbersAreMulti()
        {
            result = calci.Multi();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(p0);
        }

        [When(@"the two numbers are sub")]
        public void WhenTheTwoNumbersAreSub()
        {
            result = calci.Sub();
        }

        [When(@"the two numbers are div")]
        public void WhenTheTwoNumbersAreDiv()
        {
            result = calci.Div();
        }
    }
}
