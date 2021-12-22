using Air_Units_NS;
using Commander_NS;
using Doctrine_NS;
using Enums_NS;
using System;
using System.Collections.Generic;
using System.Linq;
using Ter_Units_NS;

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
        public void DisolveRegiment(Ter_Unit unit)
        {
            _hp -= unit._hp;
            _s_atk -= unit._s_atk;
            _h_atk -= unit._h_atk;
            _def -= unit._def;
            _armor -= unit._armor;
            _pierce -= unit._pierce;
            _breakt -= unit._breakt;
            _fuel -= unit._fuel;
            _reliab -= unit._reliab;
            _organ -= unit._organ;
            _air_atk -= unit._air_atk;
            _entrench -= unit._entrench;
            _combat_width -= unit._combat_width;
            _hardness -= unit._hardness;
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

        public void DisolveSquadron(Air_Unit unit)
        {
            _hp -= unit._hp;
            _air_atk -= unit._air_atk;
            _gnd_atk -= unit._gnd_atk;
            _strat_bmb -= unit._strat_bmb;
            _air_sup -= unit._air_sup;
        }
    }
    public class Front
    {
        Factions_Enum _faction;
        List<Ter_Unit> _gnd = new List<Ter_Unit>();
        List<Air_Unit> _air = new List<Air_Unit>();

        Commander _commander;
        Doctrine _doctrine;

        public float initialHP;

        public TerStruct terStruct = new TerStruct();
        public AirStruct airStruct = new AirStruct();

        public float _fuel_left { get; set; }
        public bool isRetreating { get; set; }
        public Front()
        {
            isRetreating = false;
            _fuel_left = 1000;
        }
        // Getters
        public string GetCommanderName()
        {
            return _commander._name;
        }
        public void SetCommanderName(string name)
        {
            _commander._name = name;
        }
        public Factions_Enum GetFaction()
        {
            return _faction;
        }
        public void AddTerUnit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp) // XML Parsing method
        {
            Ter_Unit newTerUnit = new Ter_Unit(gen, unit_type, unit_exp);
            _gnd.Add(newTerUnit);
            initialHP += newTerUnit._hp;
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
                    initialHP -= unit._hp;
                    terStruct.DisolveRegiment(unit);
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
                    airStruct.DisolveSquadron(unit);
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
            if (terStruct._hp < 0)
                terStruct._hp = 0;

            MoraleCheck();
        }
        private void MoraleCheck()
        {
            Random rand = new Random();

            int chanceToRetreat = rand.Next(1, 100);

            if (initialHP * 0.2 > terStruct._hp)
            {
                terStruct._organ *= (float)0.3;
            }
            else if (initialHP * 0.5 > terStruct._hp)
            {
                terStruct._organ *= (float)0.6;
            }
            else if (initialHP * 0.72 > terStruct._hp)
            {
                terStruct._organ *= (float)0.8;
            }
            else if (initialHP * 0.95 > terStruct._hp)
            {
                terStruct._organ *= (float)0.95;
            }
            else
            {
                terStruct._organ *= (float)0.98;
            }

            if (terStruct._organ * 0.90 + chanceToRetreat * 0.10 < 20)
            {
                isRetreating = true;
            }
        }
        public void DamageAirHp(float hp)
        {
            airStruct._hp -= hp;
            if (airStruct._hp < 0)
                airStruct._hp = 0;
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
            for (int index = 0; index < _gnd.Count(); index++)
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
        public List<Ter_Unit> GetTerUnits()
        {
            return _gnd;
        }
        public List<Air_Unit> GetAirUnits()
        {
            return _air;
        }
    }
}
