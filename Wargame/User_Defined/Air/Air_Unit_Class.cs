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
        string _name;
        Gen_Enum _gen;
        Air_Units_Enum _unit_type;
        Regiment_Exp_Enum _unit_exp;

        // Image TODO
        float _hp,
            _air_atk,
            _gnd_atk,
            _strat_bmb,
            _air_sup;

        public Air_Unit() // For testing reasons
        {

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

            _hp = hp;
            _air_atk = air_atk;
            _gnd_atk = gnd_atk;
            _strat_bmb = strat_bmb;
            _air_sup = air_sup;
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
        public Air_Units_Enum GetUnitType()
        {
            return this._unit_type;
        }
        public float[] GetDetails()
        {
            float[] public_details = new float[]
            {
            _hp,
            _air_atk,
            _gnd_atk,
            _strat_bmb,
            _air_sup
            };

            return public_details;
        }
    }
}
