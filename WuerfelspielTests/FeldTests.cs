using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WuerfelspielTests
{
    [TestClass]
    public class FeldTests
    {
        [TestMethod]

        public void Feld_()
        {
            // Arrange
            Feld f;

            // Act
            int akzeptierteAugenanzahl = -1;
            f = new Feld(akzeptierteAugenanzahl);
        }
    }
}
