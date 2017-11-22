using System;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]
        public void initialyse()
        {
            veiling = new Veiling();
        }
        [TestMethod]
        public void AlsErNogNietGebodenWerdIsHetHoogsteBodNul()
        {            
            Assert.AreEqual(decimal.Zero, veiling.Hoogstebod);
        }
        [TestMethod]
        public void NaHetEersteBodIsHetEersteBodHetHoogsteBod()
        {            
            var bedrag = 10.6m;
            veiling.DoeBod(bedrag);
            Assert.AreEqual(bedrag, veiling.Hoogstebod);
        }
        [TestMethod]
        public void NaMeerdereBodenIsHetHoogsteBodHetHoogsteBod()
        { 
            veiling.DoeBod(10.6m);
            veiling.DoeBod(21.2m);
            veiling.DoeBod(31.8m);
            Assert.AreEqual(31.8m, veiling.Hoogstebod);
        }
    }
}
