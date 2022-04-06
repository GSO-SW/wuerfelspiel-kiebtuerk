using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void DummyTest()
        {
            // Dieser Test ist hier, um eine GitHub-Funktion zu testen. 
            // Einfach löschen :)
            Assert.IsTrue(true);// is tatsächlich true :O
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Wuerfel_KonstructurAnzahlSeitenNichtNull()
        {
            // Arrange
            Wuerfel w;
            int anzahlSeiten = -1;

            // Act 
            w = new Wuerfel(anzahlSeiten);

        }

        [TestMethod]
        public void AnzahlSeiten_RueckgabewertStimmt()
        {
            // Arrange
            Wuerfel w;

            // Act 
            w = new Wuerfel(6);

            // Assert
            Assert.AreEqual(6, w.AnzahlSeiten);
        }


        [TestMethod]
        public void Wuerfeln_GibtWertZuruek()
        {
            //Arrange
            Wuerfel w = new Wuerfel();

            //Act
            int randomzahl = w.Wuerfeln();

            //Assert
            Assert.IsTrue(randomzahl < 7 && randomzahl > 0);
        }

        [TestMethod]
        public void SicherungUmschalten_VonTrueAufFalse()
        {
            //Arrange
            Wuerfel w = new Wuerfel();
            w.Gesichert = true;

            //Act
            w.SicherungUmschalten();
            
            //Assert
            Assert.AreEqual(false, w.Gesichert);
        }

        [TestMethod]
        public void Gesichert_SetUndGet()
        {
            //Arrange
            Wuerfel w = new Wuerfel();


            //Act
            w.Gesichert = true;

            //Assert
            Assert.AreEqual(true, w.Gesichert);
        }



    }
}
