using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace destroyer_bdd.Test
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        Destroyer dest = new Destroyer();

        [Given(@"I have my destroyer")]
        public void GivenIHaveMyDestroyer()
        {
            Assert.IsNotNull(dest);
        }
        
        [When(@"I add new file path")]
        public void WhenIAddNewFilePath()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"File count is (.*)")]
        public void ThenFileCountIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
