using System;
using Moq;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private Mock<IOpbrengstDAO> mockOpbrengst;
        private Mock<IkostDAO> mockKost;
        private IOpbrengstDAO opbrengstDAO;
        private IkostDAO KostDAO;
        private WinstService winstService;
        [TestInitialize]
        public void initialise()
        {
            mockOpbrengst = new Mock<IOpbrengstDAO>();
            mockKost = new Mock<IkostDAO>();
            opbrengstDAO = mockOpbrengst.Object;
            KostDAO = mockKost.Object;
            mockOpbrengst.Setup(opbrengstDoa => opbrengstDoa.TotaleOpbrengst()).Returns(10);
            mockKost.Setup(kostDAo => kostDAo.TotaleKost()).Returns(5);
            winstService = new WinstService(opbrengstDAO, KostDAO);
        }
        [TestMethod]
        public void BerekeningVanDeWinstKlopt()
        {
            Assert.AreEqual(5m, winstService.winst);
            mockOpbrengst.Verify();
            mockKost.Verify();
        }
    }
}
