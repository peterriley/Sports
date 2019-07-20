using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soccer.BL;
using Soccer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer.BLTest
{
    [TestClass]
    public class PlayerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var playerRepository = new PlayerRepository();
            var expected = new Player(1)
            {
                FirstName = "Bernd",
                MiddleName = "",
                LastName = "Leno",
                Position = "Goalkeeper"
            };

            //-- Act
            var actual = playerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.PlayerId, actual.PlayerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.MiddleName, actual.MiddleName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Position, actual.Position);

        }
    }
}
