using System;
using TDDCursusLibrary;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class PersoonTest
    {
        [TestMethod]
        public void EenPersoonIsJuistIgegeven()
        { 
            new Persoon(new List<string> { "davy","andre","hendrik" });
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMoetMinstens1VoornaamHebben()
        {
            new Persoon(new List<string> { });
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void EenPersoonKanNiet2MaalDezelfdeVoornaamHebben()
        {
            new Persoon(new List<string> { "davy", "andre", "davy" });
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void ElkeVoornaamVanPersoonMoetMinstens1TekenBevatten()
        {
            new Persoon(new List<string> { "davy", "" });
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void VoornamenMogenNietNullZijn()
        {
            new Persoon(new List<string> { null });
        }
        [TestMethod]
        public void ToStringMoetDeVoornamenTerugGevenGescheidenDoorEenSpatie()
        {
            var persoon = new Persoon(new List<string> { "davy", "andre", "hendrik" });
            Assert.AreEqual("davy andre hendrik", persoon.ToString());
        }
    }
}
