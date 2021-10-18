using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Enums_NS;
using Ter_Units_NS;
using Air_Units_NS;
using Commander_NS;

namespace Front_NS
{
    public class Front
    {
        Factions_Enum _faction;
        // TODO Faction Image
        Ter_Unit _gnd;
        Air_Unit _air;
        Commander _commander;

        public Front()
        {

        }
        public Front(Factions_Enum faction)
        {
            _faction = faction;
        }
        // Getters
        public Factions_Enum GetFaction()
        {
            return _faction;
        }
    }
}
