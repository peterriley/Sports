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
                HomeTeamList = new List<Player>()
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
                AwayTeamList = new List<Player>()
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
                Assert.AreEqual(expected.HomeTeamList[i].FirstName, actual.HomeTeamList[i].FirstName);
                Assert.AreEqual(expected.HomeTeamList[i].MiddleName, actual.HomeTeamList[i].MiddleName);
                Assert.AreEqual(expected.HomeTeamList[i].LastName, actual.HomeTeamList[i].LastName);
                Assert.AreEqual(expected.HomeTeamList[i].Position, actual.HomeTeamList[i].Position);
                Assert.AreEqual(expected.AwayTeamList[i].FirstName, actual.AwayTeamList[i].FirstName);
                Assert.AreEqual(expected.AwayTeamList[i].MiddleName, actual.AwayTeamList[i].MiddleName);
                Assert.AreEqual(expected.AwayTeamList[i].LastName, actual.AwayTeamList[i].LastName);
                Assert.AreEqual(expected.AwayTeamList[i].Position, actual.AwayTeamList[i].Position);
            }


        }
    }
}
