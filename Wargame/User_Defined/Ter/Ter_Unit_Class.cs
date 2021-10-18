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
        string _name;
        // Image TODO 
        Gen_Enum _gen;
        Ter_Units_Enum _unit_type;
        Regiment_Exp_Enum _unit_exp;

        float _hp,
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

            _hp = hp;
            _s_atk = s_atk;
            _h_atk = h_atk;
            _def = def;
            _armor = armor;
            _pierce = pierce;
            _breakt = breakt;
            _fuel = fuel;
            _reliab = reliab;
            _organ = organ;
            _air_atk = air_atk;
            _entrench = entrench;
            _combat_width = combat_width;
            _hardness = hardness;
        }
        // Getters
        public string GetName()
        {
            return this._name;
        }
        public Gen_Enum GetGen()
        {
            return this._gen;
        }
        public Regiment_Exp_Enum GetUnitExp()
        {
            return this._unit_exp;
        }
        public Ter_Units_Enum GetUnitType()
        {
            return this._unit_type;
        }
        public float[] GetDetails()
        {
            float[] public_details = new float[] 
            {_hp,
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

            return public_details;
        }
    }
}
