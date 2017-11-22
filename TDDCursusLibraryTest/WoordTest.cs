using System;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }
        [TestMethod]
        public void WoordIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("woord").IsPalindroom());
        }
    }
}
