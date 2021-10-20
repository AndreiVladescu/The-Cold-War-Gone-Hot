using Enums_NS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ter_Units_NS
{
    public class Ter_Unit
    {
        public string _name { get; set; }
        public Gen_Enum _gen { get; set; }
        public Ter_Units_Enum _unit_type { get; set; }
        public Regiment_Exp_Enum _unit_exp { get; set; }
        public float _hp,
            _s_atk,
            _h_atk,
            _def,
            _armor,
            _pierce,
            _breakt,
            _fuel,
            _reliab,
            _organ,
            _air_atk,
            _entrench,
            _combat_width,
            _hardness;

        public Ter_Unit() // For testing reasons
        {

        }
        public Ter_Unit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _gen = gen;
            _unit_type = unit_type;
            _unit_exp = unit_exp;
            // TODO automatic adding from file
        }
        public Ter_Unit(string name,
            Gen_Enum gen,
            Ter_Units_Enum unit_type,
            Regiment_Exp_Enum unit_exp,
            float hp,
            float s_atk,
            float h_atk,
            float def,
            float armor,
            float pierce,
            float breakt,
            float fuel,
            float reliab,
            float organ,
            float air_atk,
            float entrench,
            float combat_width,
            float hardness
            )
        {
            _name = name;
            _gen = gen;
            _unit_type = unit_type;
            _unit_exp = unit_exp;

            float unitGenModifier = (float)gen * (float)0.15; // 15% per tech level
            float unitExpModifier = (float)unit_exp * (float)0.25; // 25% per xp level

            // Commented structures have no sense - the machine doesn't change with unit xp
            hp += unitGenModifier * hp;
            s_atk += unitGenModifier * s_atk;
            h_atk += unitGenModifier * h_atk;
            def += unitGenModifier * def;
            armor += unitGenModifier * armor;
            pierce += unitGenModifier * pierce;
            breakt += unitGenModifier * breakt;
            fuel += unitGenModifier * fuel;
            reliab += unitGenModifier * reliab;
            organ += unitGenModifier * organ;
            air_atk += unitGenModifier * air_atk;
            //entrench += unitGenModifier * entrench;
            //combat_width += unitGenModifier * combat_width;
            hardness += unitGenModifier * hardness;
            
            
            _hp = hp + unitExpModifier * hp;
            _s_atk = s_atk + unitExpModifier * s_atk;
            _h_atk = h_atk + unitExpModifier * h_atk;
            _def = def + unitExpModifier * def;
            _armor = armor; // + unitExpModifier * armor;
            _pierce = pierce + unitExpModifier * pierce;
            _breakt = breakt + unitExpModifier * breakt;
            _fuel = fuel; // + unitExpModifier * fuel;
            _reliab = reliab + unitExpModifier * reliab;
            _organ = organ + unitExpModifier * organ;
            _air_atk = air_atk + unitExpModifier * air_atk;
            _entrench = entrench + unitExpModifier * entrench;
            _combat_width = combat_width;// + unitExpModifier * combat_width;
            _hardness = hardness; // + unitExpModifier * hardness;
        }
        // Getters
        public float[] GetBaseStats()
        {
            float[] baseStats = new float[] { _hp, _s_atk, _h_atk };
            return baseStats;
        }
        public float[] GetExtendedStats()
        {
            float[] stats = new float[]
            {
                _hp,
                _s_atk,
                _h_atk,
                _def,
                _armor,
                _pierce,
                _breakt,
                _fuel,
                _reliab,
                _organ,
                _air_atk,
                _entrench,
                _combat_width,
                _hardness
            };
            return stats;
        }
    }
}
