using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        public int Wuerfel_wuerfeltZahlZwischenEinsUndSechs
        {
            // Arrange
            Wuerfel wuerfel = new Wuerfel(6);

            // Act
            int summe = wuerfel.Wuefeln();

            // Assert
            Assert.AreEqual(moeglicheSumme, summe);
        }
    }
}
