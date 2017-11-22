using System;
using Moq;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private Mock<ILandDAO> mockFactory;
        private ILandDAO landDAO;
        private LandService landservice;
        [TestInitialize]
        public void initialise()
        {
            mockFactory = new Mock<ILandDAO>();
            landDAO = mockFactory.Object;
            mockFactory.Setup(eenLandDao => eenLandDao.OppervlakteAllelanden()).Returns(20);
            mockFactory.Setup(eenLandDao => eenLandDao.Read("B")).Returns(new Land { Landcode = "B", Oppervlakte = 5 });
            //mockFactory.Setup(eenLandDao => eenLandDao.Read("NL")).Returns(new Land { Landcode = "NL", Oppervlakte = 6 });
            //mockFactory.Setup(eenLandDao => eenLandDao.Read(string.Empty)).Throws(new ArgumentException());            
            landservice = new LandService(landDAO);
        }
        [TestMethod]
        public void VerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landservice.VerhoudingOppervlakteLandToOppervlakteAlleLanden("B"));
            mockFactory.Verify(eenLandDao => eenLandDao.OppervlakteAllelanden());
            mockFactory.Verify(eenLandDao => eenLandDao.Read("B"));
        }
    }
}
