using System;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class StatistiekTest
    {
        [TestMethod]
        public void HetGemiddeldeVan10En15Is12punt5()
        {
            Assert.AreEqual(12.5m, Statistiek.Gemiddelde(new decimal[] { 10m, 15m }));
        }
        [TestMethod]
        public void HetGemiddeldeVanEengetalIsDatGetal()
        {
            Assert.AreEqual(1.23m, Statistiek.Gemiddelde(new decimal[] { 1.23m }));
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void HetGemiddeldeVanEenlegeVerzamelingKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(new decimal[] { });
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetGemiddeldeVanNullKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(null);
        }
    }
}
