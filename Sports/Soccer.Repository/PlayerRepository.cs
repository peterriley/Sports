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
                player.FirstName = "Billy";
                player.MiddleName = "The";
                player.LastName = "Fish";
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
                    FirstName = "Billy",
                    MiddleName = "The",
                    LastName = "Fish",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(2)
                {
                    FirstName = "Thomas",
                    MiddleName = "The",
                    LastName = "Tank-Engine",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(3)
                {
                    FirstName = "Bob",
                    MiddleName = "The",
                    LastName = "Builder",
                    Position = "Midfielder"
                };
                playerList.Add(player);
            }

            if (teamId == 2)
            {
                Player player = new Player(1)
                {
                    FirstName = "Roger",
                    MiddleName = "",
                    LastName = "Mellie",
                    Position = "Goalkeeper"
                };
                playerList.Add(player);

                player = new Player(2)
                {
                    FirstName = "Biffa",
                    MiddleName = "",
                    LastName = "Bacon",
                    Position = "Defender"
                };
                playerList.Add(player);

                player = new Player(3)
                {
                    FirstName = "Mr",
                    MiddleName = "",
                    LastName = "Logic",
                    Position = "Midfielder"
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
