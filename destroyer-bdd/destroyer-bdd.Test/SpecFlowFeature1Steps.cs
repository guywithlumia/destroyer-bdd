using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        [When(@"I add new file path ""(.*)""")]
        public void WhenIAddNewFilePath(string p0)
        {
            dest.AddFile(p0);
        }
        
        [Then(@"File count is (.*)")]
        public void ThenFileCountIs(int p0)
        {
            Assert.AreEqual(p0, dest.FileCount());
        }

        [When(@"I delete new file")]
        public void WhenIDeleteNewFile()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"File exists is false")]
        public void ThenFileExistsIsFalse()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
