using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.BL
{
    public enum FixtureEventType
    {
        Goal,
        OwnGoal,
        MissedPenalty,
        SavedPenalty,
        YellowCard,
        RedCard,
        SubstituteOff,
        SubstituteOn,
        HalfTimeWhistle,
        FullTimeWhistle
    }
}
