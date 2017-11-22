using System;
using TDDCursusLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningTest
    {
        private Rekening rekening;
        [TestInitialize]
        public void Initialyse()
        {
            rekening = new Rekening();
        }
        [TestMethod]
        public void HetSaldoVanEenNieuweRekeningIsNul()
        {
            
            Assert.AreEqual(decimal.Zero, rekening.Saldo);
        }
        [TestMethod]
        public void HetSaldoNaEenEersteStortingIsGelijkAanHetBedrag()
        {
            
            var bedrag = 2.5m;
            rekening.storten(bedrag);
            Assert.AreEqual(bedrag, rekening.Saldo);
        }
        [TestMethod]
        public void HetSaldoNaTweeStortingenIsDeSomVanDeBedragenVanDieStortingen()
        {
            
            var bedrag1 = 2.5m;
            var bedrag2 = 1.5m;
            rekening.storten(bedrag1);
            rekening.storten(bedrag2);
            Assert.AreEqual(bedrag1 + bedrag2, rekening.Saldo);
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void HetBedragVanEenStoringMagNietNulZijn()
        {
            rekening.storten(decimal.Zero);
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void HetBedragVanEenStortingMagNietNegatiefZijn()
        {
            rekening.storten(-1m);
        }
    }
}
