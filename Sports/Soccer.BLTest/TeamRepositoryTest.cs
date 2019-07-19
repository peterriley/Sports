using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soccer.BL;
using Soccer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer.BLTest
{
    [TestClass]
    public class TeamRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //-- Arrange
            var teamRepository = new TeamRepository();
            var expected = new Team(1)
            {
                Name = "Fulchester United"
            };

            //-- Act
            var actual = teamRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.TeamId, actual.TeamId);
            Assert.AreEqual(expected.Name, actual.Name);

        }

        [TestMethod]
        public void RetrieveExistingWithPlayers()
        {
            //-- Arrange
            var teamRepository = new TeamRepository();
            var expected = new Team(1)
            {
                Name = "Fulchester United",
                PlayerList = new List<Player>()
                {
                    new Player()
                    {
                        FirstName = "Billy",
                        MiddleName = "The",
                        LastName = "Fish",
                        Position = "Goalkeeper"
                    },
                    new Player()
                    {
                        FirstName = "Thomas",
                        MiddleName = "The",
                        LastName = "Tank-Engine",
                        Position = "Defender"
                    },
                    new Player()
                    {
                        FirstName = "Bob",
                        MiddleName = "The",
                        LastName = "Builder",
                        Position = "Midfielder"
                    }
                }
            };

            //-- Act
            var actual = teamRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.TeamId, actual.TeamId);
            Assert.AreEqual(expected.Name, actual.Name);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected.PlayerList[i].FirstName, actual.PlayerList[i].FirstName);
                Assert.AreEqual(expected.PlayerList[i].MiddleName, actual.PlayerList[i].MiddleName);
                Assert.AreEqual(expected.PlayerList[i].LastName, actual.PlayerList[i].LastName);
                Assert.AreEqual(expected.PlayerList[i].Position, actual.PlayerList[i].Position);
            }
        }
    }
}
