using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [TestMethod]
        public void Wuerfel_wuerfeltZahlZwischenEinsUndSechs(int moeglicheSumme)
        {
            // Arrange
            Wuerfel wuerfel = new Wuerfel(6);

            // Act
            int summe = wuerfel.Wuerfeln();

            // Assert
            Assert.AreEqual(moeglicheSumme, summe);
        }
    }
}
