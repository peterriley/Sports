namespace Soccer.BL
{
    public class Player
    {
        public Player()
        {

        }

        public Player(int playerId)
        {
            PlayerId = playerId;
        }

        public int PlayerId { get; private set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                    if (!string.IsNullOrWhiteSpace(MiddleName))
                    {
                        fullName += " ";
                    }
                    fullName += MiddleName;
                }
                return fullName;
            }
        }
        public string Position { get; set; }
        public string Nationality { get; set; }
        public int TeamId { get; set; }
        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates the player data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Position)) isValid = false;

            return isValid;
        }
    }
}