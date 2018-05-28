using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
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
            dest.ClearFiles();
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
            dest.DeleteFirstFile();
        }

        [Then(@"File ""(.*)"" non exists")]
        public void ThenFileNonExists(string p0)
        {
            Assert.AreEqual(false, File.Exists(p0));
        }

        [When(@"I delete new files")]
        public void WhenIDeleteNewFiles()
        {
            dest.DeleteFiles();
        }

        [When(@"I make copy file ""(.*)""")]
        public void WhenIMakeCopyFile(string p0)
        {
            File.Copy(p0, p0 + ".orig",true);
        }

        [When(@"I trash new file")]
        public void WhenITrashNewFile()
        {
            dest.TrashFile();
        }

        [Then(@"File ""(.*)"" not equal original")]
        public void ThenFileNotEqualOriginal(string p0)
        {
            var orig = File.ReadAllBytes(p0+".orig");
            var trash = File.ReadAllBytes(p0);
            Assert.AreNotEqual(orig, trash);
        }

    }
}
