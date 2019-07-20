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
                HomeTeamName = "Arsenal",
                HomeTeamPlayerList = new List<Player>()
                {
                    new Player(1)
                    {
                    FirstName = "Bernd",
                    MiddleName = "",
                    LastName = "Leno",
                    Position = "Goalkeeper"
                    },
                    new Player(2)
                    {
                    FirstName = "Emiliano",
                    MiddleName = "",
                    LastName = "Martínez",
                    Position = "Goalkeeper"
                    },
                    new Player(3)
                    {
                    FirstName = "Matt",
                    MiddleName = "",
                    LastName = "Macey",
                    Position = "Goalkeeper"
                    },
                    new Player(4)
                    {
                    FirstName = "Héctor",
                    MiddleName = "",
                    LastName = "Bellerín",
                    Position = "Defender"
                    },
                    new Player(5)
                    {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "Sokratis",
                    Position = "Defender"
                    },
                    new Player(6)
                    {
                    FirstName = "Laurent",
                    MiddleName = "",
                    LastName = "Koscielny",
                    Position = "Defender"
                    },
                    new Player(7)
                    {
                    FirstName = "Rob",
                    MiddleName = "",
                    LastName = "Holding",
                    Position = "Defender"
                    },
                    new Player(8)
                    {
                    FirstName = "Nacho",
                    MiddleName = "",
                    LastName = "Monreal",
                    Position = "Defender"
                    },
                    new Player(9)
                    {
                    FirstName = "Shkodran",
                    MiddleName = "",
                    LastName = "Mustafi",
                    Position = "Defender"
                    },
                    new Player(10)
                    {
                    FirstName = "Carl",
                    MiddleName = "",
                    LastName = "Jenkinson",
                    Position = "Defender"
                    },
                    new Player(11)
                    {
                    FirstName = "Konstantinos",
                    MiddleName = "",
                    LastName = "Mavropanos",
                    Position = "Defender"
                    },
                    new Player(12)
                    {
                    FirstName = "Sead",
                    MiddleName = "",
                    LastName = "Kolasinac",
                    Position = "Defender"
                    },
                    new Player(13)
                    {
                    FirstName = "Zech",
                    MiddleName = "",
                    LastName = "Medley",
                    Position = "Defender"
                    },
                    new Player(14)
                    {
                    FirstName = "Calum",
                    MiddleName = "",
                    LastName = "Chambers",
                    Position = "Defender"
                    },
                    new Player(15)
                    {
                    FirstName = "Dominic",
                    MiddleName = "",
                    LastName = "Thompson",
                    Position = "Defender"
                    },
                    new Player(16)
                    {
                    FirstName = "Mohamed",
                    MiddleName = "",
                    LastName = "Elneny",
                    Position = "Midfielder"
                    },
                    new Player(17)
                    {
                    FirstName = "Henrikh",
                    MiddleName = "",
                    LastName = "Mkhitaryan",
                    Position = "Midfielder"
                    },
                    new Player(18)
                    {
                    FirstName = "Mesut",
                    MiddleName = "",
                    LastName = "Özil",
                    Position = "Midfielder"
                    },
                    new Player(19)
                    {
                    FirstName = "Lucas",
                    MiddleName = "",
                    LastName = "Torreira",
                    Position = "Midfielder"
                    },
                    new Player(20)
                    {
                    FirstName = "Ainsley",
                    MiddleName = "",
                    LastName = "Maitland-Niles",
                    Position = "Midfielder"
                    },
                    new Player(21)
                    {
                    FirstName = "Alex",
                    MiddleName = "",
                    LastName = "Iwobi",
                    Position = "Midfielder"
                    },
                    new Player(22)
                    {
                    FirstName = "Matteo",
                    MiddleName = "",
                    LastName = "Guendouzi",
                    Position = "Midfielder"
                    },
                    new Player(23)
                    {
                    FirstName = "Granit",
                    MiddleName = "",
                    LastName = "Xhaka",
                    Position = "Midfielder"
                    },
                    new Player(24)
                    {
                    FirstName = "Joe",
                    MiddleName = "",
                    LastName = "Willock",
                    Position = "Midfielder"
                    },
                    new Player(25)
                    {
                    FirstName = "Emile",
                    MiddleName = "",
                    LastName = "Smith Rowe",
                    Position = "Midfielder"
                    },
                    new Player(26)
                    {
                    FirstName = "Gabriel",
                    MiddleName = "",
                    LastName = "Martinelli",
                    Position = "Midfielder"
                    },
                    new Player(27)
                    {
                    FirstName = "James",
                    MiddleName = "",
                    LastName = "Olayinka",
                    Position = "Midfielder"
                    },
                    new Player(28)
                    {
                    FirstName = "Robbie",
                    MiddleName = "",
                    LastName = "Burton",
                    Position = "Midfielder"
                    },
                    new Player(29)
                    {
                    FirstName = "Alexandre",
                    MiddleName = "",
                    LastName = "Lacazette",
                    Position = "Forward"
                    },
                    new Player(30)
                    {
                    FirstName = "Pierre-Emerick",
                    MiddleName = "",
                    LastName = "Aubameyang",
                    Position = "Forward"
                    },
                    new Player(31)
                    {
                    FirstName = "Eddie",
                    MiddleName = "",
                    LastName = "Nketiah",
                    Position = "Forward"
                    },
                    new Player(32)
                    {
                    FirstName = "Tyreece",
                    MiddleName = "",
                    LastName = "John-Jules",
                    Position = "Forward"
                    },
                    new Player(33)
                    {
                    FirstName = "Bukayo",
                    MiddleName = "",
                    LastName = "Saka",
                    Position = "Forward"
                    },
                    new Player(34)
                    {
                    FirstName = "Reiss",
                    MiddleName = "",
                    LastName = "Nelson",
                    Position = "Forward"
                    }
                },
                AwayTeamName = "Aston Villa",
                AwayTeamPlayerList = new List<Player>()
                {
                    new Player(1)
                    {
                    FirstName = "Ørjan",
                    MiddleName = "",
                    LastName = "Nyland",
                    Position = "Goalkeeper"
                    },
                    new Player(2)
                    {
                    FirstName = "Jed",
                    MiddleName = "",
                    LastName = "Steer",
                    Position = "Goalkeeper"
                    },
                    new Player(3)
                    {
                    FirstName = "Lovre",
                    MiddleName = "",
                    LastName = "Kalinic",
                    Position = "Goalkeeper"
                    },
                    new Player(4)
                    {
                    FirstName = "Neil",
                    MiddleName = "",
                    LastName = "Taylor",
                    Position = "Defender"
                    },
                    new Player(5)
                    {
                    FirstName = "James",
                    MiddleName = "",
                    LastName = "Chester",
                    Position = "Defender"
                    },
                    new Player(6)
                    {
                    FirstName = "Ahmed",
                    MiddleName = "",
                    LastName = "El Mohamady",
                    Position = "Defender"
                    },
                    new Player(7)
                    {
                    FirstName = "Dominic",
                    MiddleName = "",
                    LastName = "Revan",
                    Position = "Defender"
                    },
                    new Player(8)
                    {
                    FirstName = "Frederic",
                    MiddleName = "",
                    LastName = "Guilbert",
                    Position = "Defender"
                    },
                    new Player(9)
                    {
                    FirstName = "James",
                    MiddleName = "",
                    LastName = "Bree",
                    Position = "Defender"
                    },
                    new Player(10)
                    {
                    FirstName = "Mitchell",
                    MiddleName = "",
                    LastName = "Clark",
                    Position = "Defender"
                    },
                    new Player(11)
                    {
                    FirstName = "Matt",
                    MiddleName = "",
                    LastName = "Targett",
                    Position = "Defender"
                    },
                    new Player(12)
                    {
                    FirstName = "Kortney",
                    MiddleName = "",
                    LastName = "Hause",
                    Position = "Defender"
                    },
                    new Player(13)
                    {
                    FirstName = "Tyrone",
                    MiddleName = "",
                    LastName = "Mings",
                    Position = "Defender"
                    },
                    new Player(14)
                    {
                    FirstName = "Ezri",
                    MiddleName = "Konsa",
                    LastName = "Ngoyo",
                    Position = "Defender"
                    },
                    new Player(15)
                    {
                    FirstName = "Björn",
                    MiddleName = "",
                    LastName = "Engels",
                    Position = "Defender"
                    },
                    new Player(16)
                    {
                    FirstName = "John",
                    MiddleName = "",
                    LastName = "McGinn",
                    Position = "Midfielder"
                    },
                    new Player(17)
                    {
                    FirstName = "Henri",
                    MiddleName = "",
                    LastName = "Lansbury",
                    Position = "Midfielder"
                    },
                    new Player(18)
                    {
                    FirstName = "Jack",
                    MiddleName = "",
                    LastName = "Grealish",
                    Position = "Midfielder"
                    },
                    new Player(19)
                    {
                    FirstName = "Conor",
                    MiddleName = "",
                    LastName = "Hourihane",
                    Position = "Midfielder"
                    },
                    new Player(20)
                    {
                    FirstName = "Keinan",
                    MiddleName = "",
                    LastName = "Davis",
                    Position = "Midfielder"
                    },
                    new Player(21)
                    {
                    FirstName = "Andre",
                    MiddleName = "",
                    LastName = "Green",
                    Position = "Midfielder"
                    },
                    new Player(22)
                    {
                    FirstName = "Birkir",
                    MiddleName = "",
                    LastName = "Bjarnason",
                    Position = "Midfielder"
                    },
                    new Player(23)
                    {
                    FirstName = "Jacob",
                    MiddleName = "",
                    LastName = "Ramsey",
                    Position = "Midfielder"
                    },
                    new Player(24)
                    {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "Jota",
                    Position = "Midfielder"
                    },
                    new Player(25)
                    {
                    FirstName = "Jake",
                    MiddleName = "",
                    LastName = "Doyle-Hayes",
                    Position = "Midfielder"
                    },
                    new Player(26)
                    {
                    FirstName = "Callum",
                    MiddleName = "",
                    LastName = "O'Hare",
                    Position = "Midfielder"
                    },
                    new Player(27)
                    {
                    FirstName = "Anwar",
                    MiddleName = "",
                    LastName = "El Ghazi",
                    Position = "Midfielder"
                    },
                    new Player(28)
                    {
                    FirstName = "Jonathan",
                    MiddleName = "",
                    LastName = "Kodjia",
                    Position = "Forward"
                    },
                    new Player(29)
                    {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "Wesley",
                    Position = "Forward"
                    },
                    new Player(30)
                    {
                    FirstName = "Scott",
                    MiddleName = "",
                    LastName = "Hogan",
                    Position = "Forward"
                    },
                    new Player(31)
                    {
                    FirstName = "Rushian",
                    MiddleName = "",
                    LastName = "Hepburn-Murphy",
                    Position = "Forward"
                    },
                    new Player(32)
                    {
                    FirstName = "Ross",
                    MiddleName = "",
                    LastName = "McCormack",
                    Position = "Forward"
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
