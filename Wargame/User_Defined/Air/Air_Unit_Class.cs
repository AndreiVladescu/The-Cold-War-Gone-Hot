using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Enums_NS;

namespace Air_Units_NS
{
    public class Air_Unit
    {
        public string _name { get; set; }
        public Gen_Enum _gen { get; set; }
        public Air_Units_Enum _unit_type { get; set; }
        public Regiment_Exp_Enum _unit_exp { get; set; }

        public float 
            _hp,
            _air_atk,
            _gnd_atk,
            _strat_bmb,
            _air_sup;

        public Air_Unit() // For testing reasons
        {

        }
        public Air_Unit(Gen_Enum gen, Air_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _gen = gen;
            _unit_type = unit_type;
            _unit_exp = unit_exp;
            // TODO automatic add from xml file
        }
        public Air_Unit(string name,
        Gen_Enum gen,
        Air_Units_Enum unit_type,
        Regiment_Exp_Enum unit_exp,
        float hp,
        float air_atk,
        float gnd_atk,
        float strat_bmb,
        float air_sup)
        {
            _name = name;
            _gen = gen;
            _unit_type = unit_type;
            _unit_exp = unit_exp;

            float unitGenModifier = (float)gen * (float)0.15; // 15% per tech level
            float unitExpModifier = (float)unit_exp * (float)0.25; // 25% per xp level

            hp += unitGenModifier * hp;
            air_atk += unitGenModifier * air_atk;
            gnd_atk += unitGenModifier * gnd_atk;
            strat_bmb += unitGenModifier * strat_bmb;
            air_sup += unitGenModifier * air_sup;

            _hp = hp + unitExpModifier * hp;
            _air_atk = air_atk + unitExpModifier * air_atk;
            _gnd_atk = gnd_atk + unitExpModifier * gnd_atk;
            _strat_bmb = strat_bmb + unitExpModifier * strat_bmb;
            _air_sup = air_sup + unitExpModifier * air_sup;
        }
        // Getters
        public float[] GetExtendedStats()
        {
            float[] stats = new float[]
            {
            _hp,
            _air_atk,
            _gnd_atk,
            _strat_bmb,
            _air_sup
            };

            return stats;
        }
    }
}
