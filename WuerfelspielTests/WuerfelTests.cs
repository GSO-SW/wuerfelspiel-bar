using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_wirdKorrektErstellt()
        {
            // Arrange
            Wuerfel w = new Wuerfel();

            // Act
            string name = w.ToString();

            // Assert
            Assert.AreEqual("Wuerfelspiel.Wuerfel", name);
        }

        [TestMethod]
        public void Wuerfel_wuerfeltZahlZwischenEinsUndSechs()
        {
            // Arrange
            Wuerfel w = new Wuerfel();

            // Act
            int summe = w.Wuerfeln();

            // Assert
            Assert.IsTrue(summe >= 1);
            Assert.IsTrue(summe <= 6);
        }

        [TestMethod]
        public void Wuerfel_wuerfeltZahlZwischenEinsUndAngegebenerZahl()
        {
            // Arrange
            int anzahlSeiten = 10;
            Wuerfel w = new Wuerfel(anzahlSeiten);

            // Act
            int summe = w.Wuerfeln();

            // Assert
            Assert.IsTrue(summe >= 1);
            Assert.IsTrue(summe <= 10);
        }
    }
}
