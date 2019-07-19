using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.BL
{
    public class Team
    {
        // Use constructor chaining ': this(0)' to use constructor chaining to call the parameterized constructor with a teamId of 0
        // which always initializes PlayerList - giving a composition relationship
        public Team() : this(0)
        {

        }

        public Team(int teamId)
        {
            TeamId = teamId;
            // To prevent a null value exception to PlayerList create an instance of PlayerList
            PlayerList = new List<Player>();
        }

        public int TeamId { get; private set; }
        public string Name { get; set; }

        public List<Player> PlayerList { get; set; }

        /// <summary>
        /// Validates the team data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;

            return isValid;
        }
    }
}
