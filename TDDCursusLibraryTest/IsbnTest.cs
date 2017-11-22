using System;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class IsbnTest
    {
        [TestMethod]
        public void NummerbestaatUit13CijferscorrectecontroleIsOK()
        {
            new ISBN(9789027439642);
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void NummerbestaatUit13CijfersfouteControleIsFout()
        {
            new ISBN(9789027439641);
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void NummerBestaatUit12CijfersIsFout()
        {
            new ISBN(978902743964);
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void nummerBestaatUit14CijfersIsFout()
        {
            new ISBN(97890274396412);
        }
        [TestMethod]
        public void ToStringMoetHetNummerTerugGeven()
        {
            var nummer = 9789027439642;
            var isbn = new ISBN(nummer);
            Assert.AreEqual(nummer.ToString(), isbn.ToString());
        }
    }
}
