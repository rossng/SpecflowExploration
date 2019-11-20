using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecflowExploration.Specs
{
    [Binding]
    public class AdderSteps
    {
        private readonly Adder _adder = new Adder();
        private readonly List<int> _operands = new List<int>();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _adder.Operands.Add(p0);
            _operands.Add(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _adder.Calculate();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, _operands.Sum());
        }
    }
}
