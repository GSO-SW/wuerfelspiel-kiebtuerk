﻿using System;
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
        [ExceptionException(typeof(Exception))]
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

        

    }
}
