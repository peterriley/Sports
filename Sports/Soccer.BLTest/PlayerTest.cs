using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soccer.BL;

namespace Soccer.BLTest
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Player player = new Player
            {
                FirstName = "Billy",
                MiddleName = "The",
                LastName = "Fish"
            };
            string expected = "Fish, Billy The";

            //-- Act
            string actual = player.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstAndMiddleNameEmpty()
        {
            //-- Arrange
            Player player = new Player
            {
                LastName = "Fish"
            };
            string expected = "Fish";

            //-- Act
            string actual = player.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Player player = new Player
            {
                FirstName = "Billy",
                MiddleName = "The"
            };
            string expected = "Billy The";

            //-- Act
            string actual = player.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Player();
            c1.FirstName = "Billy";
            Player.InstanceCount += 1;

            var c2 = new Player();
            c1.FirstName = "Roger";
            Player.InstanceCount += 1;

            var c3 = new Player();
            c1.FirstName = "Bob";
            Player.InstanceCount += 1;

            //-- Act


            //-- Assert
            Assert.AreEqual(3, Player.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var player = new Player
            {
                LastName = "Fish",
                Position = "Goalkeeper"
            };

            var expected = true;

            //-- Act
            var actual = player.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(player.Validate());
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var player = new Player
            {
                Position = "Goalkeeper"
            };

            var expected = false;

            //-- Act
            var actual = player.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(player.Validate());
        }
    }
}
