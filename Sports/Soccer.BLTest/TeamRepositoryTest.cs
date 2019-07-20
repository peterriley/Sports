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
                Name = "Arsenal"
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
                Name = "Arsenal",
                PlayerList = new List<Player>()
                {
                    new Player()
                    {
                    FirstName = "Bernd",
                    MiddleName = "",
                    LastName = "Leno",
                    Position = "Goalkeeper"
                    },
                    new Player()
                    {
                    FirstName = "Emiliano",
                    MiddleName = "",
                    LastName = "Martínez",
                    Position = "Goalkeeper"
                    },
                    new Player()
                    {
                    FirstName = "Matt",
                    MiddleName = "",
                    LastName = "Macey",
                    Position = "Goalkeeper"
                    },
                    new Player()
                    {
                    FirstName = "Héctor",
                    MiddleName = "",
                    LastName = "Bellerín",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "Sokratis",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Laurent",
                    MiddleName = "",
                    LastName = "Koscielny",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Rob",
                    MiddleName = "",
                    LastName = "Holding",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Nacho",
                    MiddleName = "",
                    LastName = "Monreal",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Shkodran",
                    MiddleName = "",
                    LastName = "Mustafi",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Carl",
                    MiddleName = "",
                    LastName = "Jenkinson",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Konstantinos",
                    MiddleName = "",
                    LastName = "Mavropanos",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Sead",
                    MiddleName = "",
                    LastName = "Kolasinac",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Zech",
                    MiddleName = "",
                    LastName = "Medley",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Calum",
                    MiddleName = "",
                    LastName = "Chambers",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Dominic",
                    MiddleName = "",
                    LastName = "Thompson",
                    Position = "Defender"
                    },
                    new Player()
                    {
                    FirstName = "Mohamed",
                    MiddleName = "",
                    LastName = "Elneny",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Henrikh",
                    MiddleName = "",
                    LastName = "Mkhitaryan",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Mesut",
                    MiddleName = "",
                    LastName = "Özil",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Lucas",
                    MiddleName = "",
                    LastName = "Torreira",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Ainsley",
                    MiddleName = "",
                    LastName = "Maitland-Niles",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Alex",
                    MiddleName = "",
                    LastName = "Iwobi",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Matteo",
                    MiddleName = "",
                    LastName = "Guendouzi",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Granit",
                    MiddleName = "",
                    LastName = "Xhaka",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Joe",
                    MiddleName = "",
                    LastName = "Willock",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Emile",
                    MiddleName = "",
                    LastName = "Smith Rowe",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Gabriel",
                    MiddleName = "",
                    LastName = "Martinelli",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "James",
                    MiddleName = "",
                    LastName = "Olayinka",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Robbie",
                    MiddleName = "",
                    LastName = "Burton",
                    Position = "Midfielder"
                    },
                    new Player()
                    {
                    FirstName = "Alexandre",
                    MiddleName = "",
                    LastName = "Lacazette",
                    Position = "Forward"
                    },
                    new Player()
                    {
                    FirstName = "Pierre-Emerick",
                    MiddleName = "",
                    LastName = "Aubameyang",
                    Position = "Forward"
                    },
                    new Player()
                    {
                    FirstName = "Eddie",
                    MiddleName = "",
                    LastName = "Nketiah",
                    Position = "Forward"
                    },
                    new Player()
                    {
                    FirstName = "Tyreece",
                    MiddleName = "",
                    LastName = "John-Jules",
                    Position = "Forward"
                    },
                    new Player()
                    {
                    FirstName = "Bukayo",
                    MiddleName = "",
                    LastName = "Saka",
                    Position = "Forward"
                    },
                    new Player()
                    {
                    FirstName = "Reiss",
                    MiddleName = "",
                    LastName = "Nelson",
                    Position = "Forward"
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
