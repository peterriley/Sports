using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soccer.BL;
using Soccer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer.BLTest
{
    [TestClass]
    public class FixtureTeamsRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //-- Arrange
            var fixtureTeamsRepository = new FixtureTeamsRepository();
            var expected = new FixtureTeams(1)
            {
                HomeTeamName = "Fulchester United",
                HomeTeamPlayerList = new List<Player>()
                {
                    new Player(1)
                    {
                        FirstName = "Billy",
                        MiddleName = "The",
                        LastName = "Fish",
                        Position = "Goalkeeper"
                    },
                    new Player(2)
                    {
                        FirstName = "Thomas",
                        MiddleName = "The",
                        LastName = "Tank-Engine",
                        Position = "Defender"
                    },
                    new Player(3)
                    {
                        FirstName = "Bob",
                        MiddleName = "The",
                        LastName = "Builder",
                        Position = "Midfielder"
                    }
                },
                AwayTeamName = "Viz FC",
                AwayTeamPlayerList = new List<Player>()
                {
                    new Player(1)
                    {
                        FirstName = "Roger",
                        MiddleName = "",
                        LastName = "Mellie",
                        Position = "Goalkeeper"
                    },
                    new Player(2)
                    {
                        FirstName = "Biffa",
                        MiddleName = "",
                        LastName = "Bacon",
                        Position = "Defender"
                    },
                    new Player(3)
                    {
                        FirstName = "Mr",
                        MiddleName = "",
                        LastName = "Logic",
                        Position = "Midfielder"
                    }
                }
            };

            //-- Act
            var actual = fixtureTeamsRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.HomeTeamName, actual.HomeTeamName);
            Assert.AreEqual(expected.AwayTeamName, actual.AwayTeamName);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected.HomeTeamPlayerList[i].FirstName, actual.HomeTeamPlayerList[i].FirstName);
                Assert.AreEqual(expected.HomeTeamPlayerList[i].MiddleName, actual.HomeTeamPlayerList[i].MiddleName);
                Assert.AreEqual(expected.HomeTeamPlayerList[i].LastName, actual.HomeTeamPlayerList[i].LastName);
                Assert.AreEqual(expected.HomeTeamPlayerList[i].Position, actual.HomeTeamPlayerList[i].Position);
                Assert.AreEqual(expected.AwayTeamPlayerList[i].FirstName, actual.AwayTeamPlayerList[i].FirstName);
                Assert.AreEqual(expected.AwayTeamPlayerList[i].MiddleName, actual.AwayTeamPlayerList[i].MiddleName);
                Assert.AreEqual(expected.AwayTeamPlayerList[i].LastName, actual.AwayTeamPlayerList[i].LastName);
                Assert.AreEqual(expected.AwayTeamPlayerList[i].Position, actual.AwayTeamPlayerList[i].Position);
            }


        }

        [TestMethod]
        public void RetrieveTeamListsTest()
        {
            //-- Arrange
            var fixtureTeamsRepository = new FixtureTeamsRepository();

            //-- Act
            var actual = fixtureTeamsRepository.Retrieve();

            //-- Assert
            Assert.AreEqual(1, 1);
        }

    }
}
