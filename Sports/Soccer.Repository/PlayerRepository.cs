using Soccer.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.Repository
{
    public class PlayerRepository
    {
        /// <summary>
        /// Retrieve one player.
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns></returns>
        public Player Retrieve(int playerId)
        {
            // Create the instance of the Player class
            // Pass in the requested id
            Player player = new Player(playerId);

            // Code that retrieves the defined player

            // Temporary hard-coded values to return
            // a populated player
            if (playerId == 1)
            {
                player.FirstName = "Bernd";
                player.MiddleName = "";
                player.LastName = "Leno";
                player.Position = "Goalkeeper";
            }

            return player;
        }

        /// <summary>
        /// Retrieve all players.
        /// </summary>
        /// <returns></returns>
        public List<Player> Retrieve()
        {
            // Code that retrieves all of the players

            return new List<Player>();
        }

        /// <summary>
        /// Retrieve all players in a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public IEnumerable<Player> RetrieveByTeamId(int teamId)
        {
            // Code that retrieves all players in a team

            // Temporary hard-coded values to return
            // a set of players for the team
            var playerList = new List<Player>();

            if (teamId == 1)
            {
                Player player = new Player(1)
                {
                    FirstName = "Bernd",
                    MiddleName = "",
                    LastName = "Leno",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(2)
                {
                    FirstName = "Emiliano",
                    MiddleName = "",
                    LastName = "Martínez",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(3)
                {
                    FirstName = "Matt",
                    MiddleName = "",
                    LastName = "Macey",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(4)
                {
                    FirstName = "Héctor",
                    MiddleName = "",
                    LastName = "Bellerín",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(5)
                {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "Sokratis",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(6)
                {
                    FirstName = "Laurent",
                    MiddleName = "",
                    LastName = "Koscielny",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(7)
                {
                    FirstName = "Rob",
                    MiddleName = "",
                    LastName = "Holding",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(8)
                {
                    FirstName = "Nacho",
                    MiddleName = "",
                    LastName = "Monreal",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(9)
                {
                    FirstName = "Shkodran",
                    MiddleName = "",
                    LastName = "Mustafi",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(10)
                {
                    FirstName = "Carl",
                    MiddleName = "",
                    LastName = "Jenkinson",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(11)
                {
                    FirstName = "Konstantinos",
                    MiddleName = "",
                    LastName = "Mavropanos",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(12)
                {
                    FirstName = "Sead",
                    MiddleName = "",
                    LastName = "Kolasinac",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(13)
                {
                    FirstName = "Zech",
                    MiddleName = "",
                    LastName = "Medley",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(14)
                {
                    FirstName = "Calum",
                    MiddleName = "",
                    LastName = "Chambers",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(15)
                {
                    FirstName = "Dominic",
                    MiddleName = "",
                    LastName = "Thompson",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(16)
                {
                    FirstName = "Mohamed",
                    MiddleName = "",
                    LastName = "Elneny",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(17)
                {
                    FirstName = "Henrikh",
                    MiddleName = "",
                    LastName = "Mkhitaryan",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(18)
                {
                    FirstName = "Mesut",
                    MiddleName = "",
                    LastName = "Özil",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(19)
                {
                    FirstName = "Lucas",
                    MiddleName = "",
                    LastName = "Torreira",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(20)
                {
                    FirstName = "Ainsley",
                    MiddleName = "",
                    LastName = "Maitland-Niles",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(21)
                {
                    FirstName = "Alex",
                    MiddleName = "",
                    LastName = "Iwobi",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(22)
                {
                    FirstName = "Matteo",
                    MiddleName = "",
                    LastName = "Guendouzi",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(23)
                {
                    FirstName = "Granit",
                    MiddleName = "",
                    LastName = "Xhaka",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(24)
                {
                    FirstName = "Joe",
                    MiddleName = "",
                    LastName = "Willock",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(25)
                {
                    FirstName = "Emile",
                    MiddleName = "",
                    LastName = "Smith Rowe",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(26)
                {
                    FirstName = "Gabriel",
                    MiddleName = "",
                    LastName = "Martinelli",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(27)
                {
                    FirstName = "James",
                    MiddleName = "",
                    LastName = "Olayinka",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(28)
                {
                    FirstName = "Robbie",
                    MiddleName = "",
                    LastName = "Burton",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(29)
                {
                    FirstName = "Alexandre",
                    MiddleName = "",
                    LastName = "Lacazette",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(30)
                {
                    FirstName = "Pierre-Emerick",
                    MiddleName = "",
                    LastName = "Aubameyang",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(31)
                {
                    FirstName = "Eddie",
                    MiddleName = "",
                    LastName = "Nketiah",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(32)
                {
                    FirstName = "Tyreece",
                    MiddleName = "",
                    LastName = "John-Jules",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(33)
                {
                    FirstName = "Bukayo",
                    MiddleName = "",
                    LastName = "Saka",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(34)
                {
                    FirstName = "Reiss",
                    MiddleName = "",
                    LastName = "Nelson",
                    Position = "Forward"
                };
                playerList.Add(player);
            }

            if (teamId == 2)
            {
                Player player = new Player(1)
                {
                    FirstName = "Ørjan",
                    MiddleName = "",
                    LastName = "Nyland",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(2)
                {
                    FirstName = "Jed",
                    MiddleName = "",
                    LastName = "Steer",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(3)
                {
                    FirstName = "Lovre",
                    MiddleName = "",
                    LastName = "Kalinic",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(4)
                {
                    FirstName = "Neil",
                    MiddleName = "",
                    LastName = "Taylor",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(5)
                {
                    FirstName = "James",
                    MiddleName = "",
                    LastName = "Chester",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(6)
                {
                    FirstName = "Ahmed",
                    MiddleName = "",
                    LastName = "El Mohamady",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(7)
                {
                    FirstName = "Dominic",
                    MiddleName = "",
                    LastName = "Revan",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(8)
                {
                    FirstName = "Frederic",
                    MiddleName = "",
                    LastName = "Guilbert",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(9)
                {
                    FirstName = "James",
                    MiddleName = "",
                    LastName = "Bree",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(10)
                {
                    FirstName = "Mitchell",
                    MiddleName = "",
                    LastName = "Clark",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(11)
                {
                    FirstName = "Matt",
                    MiddleName = "",
                    LastName = "Targett",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(12)
                {
                    FirstName = "Kortney",
                    MiddleName = "",
                    LastName = "Hause",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(13)
                {
                    FirstName = "Tyrone",
                    MiddleName = "",
                    LastName = "Mings",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(14)
                {
                    FirstName = "Ezri",
                    MiddleName = "Konsa",
                    LastName = "Ngoyo",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(15)
                {
                    FirstName = "Björn",
                    MiddleName = "",
                    LastName = "Engels",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(16)
                {
                    FirstName = "John",
                    MiddleName = "",
                    LastName = "McGinn",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(17)
                {
                    FirstName = "Henri",
                    MiddleName = "",
                    LastName = "Lansbury",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(18)
                {
                    FirstName = "Jack",
                    MiddleName = "",
                    LastName = "Grealish",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(19)
                {
                    FirstName = "Conor",
                    MiddleName = "",
                    LastName = "Hourihane",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(20)
                {
                    FirstName = "Keinan",
                    MiddleName = "",
                    LastName = "Davis",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(21)
                {
                    FirstName = "Andre",
                    MiddleName = "",
                    LastName = "Green",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(22)
                {
                    FirstName = "Birkir",
                    MiddleName = "",
                    LastName = "Bjarnason",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(23)
                {
                    FirstName = "Jacob",
                    MiddleName = "",
                    LastName = "Ramsey",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(24)
                {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "Jota",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(25)
                {
                    FirstName = "Jake",
                    MiddleName = "",
                    LastName = "Doyle-Hayes",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(26)
                {
                    FirstName = "Callum",
                    MiddleName = "",
                    LastName = "O'Hare",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(27)
                {
                    FirstName = "Anwar",
                    MiddleName = "",
                    LastName = "El Ghazi",
                    Position = "Midfielder"
                };
                playerList.Add(player);

                player = new Player(28)
                {
                    FirstName = "Jonathan",
                    MiddleName = "",
                    LastName = "Kodjia",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(29)
                {
                    FirstName = "",
                    MiddleName = "",
                    LastName = "Wesley",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(30)
                {
                    FirstName = "Scott",
                    MiddleName = "",
                    LastName = "Hogan",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(31)
                {
                    FirstName = "Rushian",
                    MiddleName = "",
                    LastName = "Hepburn-Murphy",
                    Position = "Forward"
                };
                playerList.Add(player);

                player = new Player(32)
                {
                    FirstName = "Ross",
                    MiddleName = "",
                    LastName = "McCormack",
                    Position = "Forward"
                };
                playerList.Add(player);
            }

            return playerList;
        }

        /// <summary>
        /// Saves the current player.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined player

            return true;
        }
    }
}
