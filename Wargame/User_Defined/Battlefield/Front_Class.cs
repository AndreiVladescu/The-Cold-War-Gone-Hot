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

    public struct TerStruct
    {
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

        public void IntegrateRegiment(float[] terUnitStats)
        {
            _hp += terUnitStats[0];
            _s_atk += terUnitStats[1];
            _h_atk += terUnitStats[2];
            _def += terUnitStats[3];
            _armor += terUnitStats[4];
            _pierce += terUnitStats[5];
            _breakt += terUnitStats[6];
            _fuel += terUnitStats[7];
            _reliab += terUnitStats[8];
            _organ += terUnitStats[9];
            _air_atk += terUnitStats[10];
            _entrench += terUnitStats[11];
            _combat_width += terUnitStats[12];
            _hardness += terUnitStats[13];
        }
        public void DisolveRegiment(float[] terUnitStats)
        {
            _hp -= terUnitStats[0];
            _s_atk -= terUnitStats[1];
            _h_atk -= terUnitStats[2];
            _def -= terUnitStats[3];
            _armor -= terUnitStats[4];
            _pierce -= terUnitStats[5];
            _breakt -= terUnitStats[6];
            _fuel -= terUnitStats[7];
            _reliab -= terUnitStats[8];
            _organ -= terUnitStats[9];
            _air_atk -= terUnitStats[10];
            _entrench -= terUnitStats[11];
            _combat_width -= terUnitStats[12];
            _hardness -= terUnitStats[13];
        }
    }
    public struct AirStruct
    {
        public float _hp, // Airforce attributes
        _air_atk,
        _gnd_atk,
        _strat_bmb,
        _air_sup;

        public void IntegrateSquadron(float[] airUnitStats)
        {
            _hp += airUnitStats[0];
            _air_atk += airUnitStats[1];
            _gnd_atk += airUnitStats[2];
            _strat_bmb += airUnitStats[3];
            _air_sup += airUnitStats[4];
        }

        public void DisolveSquadron(float[] airUnitStats)
        {
            _hp -= airUnitStats[0];
            _air_atk -= airUnitStats[1];
            _gnd_atk -= airUnitStats[2];
            _strat_bmb -= airUnitStats[3];
            _air_sup -= airUnitStats[4];
        }
    }
    public class Front
    {
        Factions_Enum _faction;
        // TODO Faction Image
        List<Ter_Unit> _gnd = new List<Ter_Unit>();
        List<Air_Unit> _air = new List<Air_Unit>();

        Commander _commander;

        TerStruct terStruct = new TerStruct();
        AirStruct airStruct = new AirStruct();

        public Front()
        {

        }
        // Getters
        public Factions_Enum GetFaction()
        {
            return _faction;
        }
        public void AddTerUnit(List<float> unitStats) // Don't use me
        {
            Ter_Unit newTerUnit = new Ter_Unit();
            _gnd.Add(newTerUnit);
            terStruct.IntegrateRegiment(unitStats.ToArray());
        }
        public void AddTerUnit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp) // XML Parsing method
        {
            Ter_Unit newTerUnit = new Ter_Unit(gen, unit_type, unit_exp);
            _gnd.Add(newTerUnit);
            terStruct.IntegrateRegiment(_gnd[_gnd.Count() - 1].GetExtendedStats()); // Get the stats from the last added element
        }
        public void AddAirUnit(List<float> unitStats) // Don't use me
        {
            Air_Unit newAirUnit = new Air_Unit();
            _air.Add(newAirUnit);
            airStruct.IntegrateSquadron(unitStats.ToArray());
        }
        public void AddAirUnit(Gen_Enum gen, Air_Units_Enum unit_type, Regiment_Exp_Enum unit_exp) // XML Parsing Method
        {
            Air_Unit newAirUnit = new Air_Unit(gen, unit_type, unit_exp);
            _air.Add(newAirUnit);
            airStruct.IntegrateSquadron(_air[_air.Count() - 1].GetExtendedStats()); // Get the stats from the last added element
        }
        public void SubTerUnit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            for (int index = 0; index < _gnd.Count(); index++)
            {
                Ter_Unit unit = _gnd[index];
                if (unit._gen == gen && unit._unit_exp == unit_exp && unit._unit_type == unit_type)
                {
                    _gnd.RemoveAt(index);
                    break;
                }
            }
        }
        public void SubAirUnit(Gen_Enum gen, Air_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            for (int index = 0; index < _air.Count(); index++)
            {
                Air_Unit unit = _air[index];
                if (unit._gen == gen && unit._unit_exp == unit_exp && unit._unit_type == unit_type)
                {
                    _air.RemoveAt(index);
                    break;
                }

            }
        }
        public void SetCommander(int level, string name)
        {
            _commander = new Commander(level, name);
        }
        public void SetFaction(Factions_Enum faction)
        {
            _faction = faction;
        }
        public float[] GetBaseStats() // Don't use me
        {
            float[] baseStats = new float[] { terStruct._hp, terStruct._s_atk, terStruct._h_atk };
            return baseStats;
        }
        public void DamageTerHp(float hp)
        {
            terStruct._hp -= hp;
        }
        public void DamageAirHp(float hp)
        {
            airStruct._hp -= hp;
        }
        public int GetTerUnitNumber()
        {
            return _gnd.Count();
        }
        public int GetAirUnitNumber()
        {
            return _air.Count();
        }
        public TerStruct GetTerStruct()
        {
            return terStruct;
        }
        public AirStruct GetAirStruct()
        {
            return airStruct;
        }
        public int GetCommanderLevel()
        {
            return _commander._level;
        }
        public int GetLegUnitNumber()
        {
            int nmbr = 0;
            for (int index =0;index < _gnd.Count(); index++)
            {
                if ((int)_gnd[index]._unit_type > 200)
                    nmbr++;
            }
            return nmbr;
        }
        public int GetMobUnitNumber()
        {
            int nmbr = 0;
            for (int index = 0; index < _gnd.Count(); index++)
            {
                if ((int)_gnd[index]._unit_type < 200)
                    nmbr++;
            }
            return nmbr;
        }
        public bool IsTerDefeated()
        {
            if (terStruct._hp > 0)
                return false;
            return true;
        }
        public bool IsAirDefeated()
        {
            if (airStruct._hp > 0)
                return false;
            return true;
        }
    }
}
