using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.BL
{
    public class FixtureEvent
    {
        public FixtureEvent()
        {

        }

        public FixtureEvent(int fixtureEventId)
        {
            FixtureEventId = fixtureEventId;
        }

        public int FixtureEventId { get; private set; }
        public int FixtureId { get; set; }
        public int PlayerId { get; set; }
        public string FullName { get; set; }
        public FixtureEventType FixtureEventType { get; set; }
        public int FixtureEventMinutes { get; set; }
        // Sets the number + or - for a particular FixtureEventType
        public int FixtureEventValue { get; set; }

        /// <summary>
        /// Validates the fixture event data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(FullName)) isValid = false;

            return isValid;
        }
    }
}
