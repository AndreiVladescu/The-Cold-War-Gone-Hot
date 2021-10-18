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
        List<Ter_Unit> _gnd;
        List<Air_Unit> _air;
        Commander _commander;
        List<float> _stats;
        float _hp,
        _s_attack,
        _h_attack;
        public Front()
        {

        }
        // Getters
        public Factions_Enum GetFaction()
        {
            return _faction;
        }
        public void AddTerUnit(List<float> unitStats)
        {
            Ter_Unit newTerUnit = new Ter_Unit();
            this._gnd.Add(newTerUnit);
        }
        public void AddAirUnit(List<float> unitStats)
        {
            Air_Unit newAirUnit = new Air_Unit();
            this._air.Add(newAirUnit);
        }
        public void SetCommander(int level, string name)
        {
            _commander = new Commander(level, name);
        }
        public void SetFaction(Factions_Enum faction)
        {
            _faction = faction;
        }
        public void ComputeStats()
        {

            for (int index = 0; index < _gnd.Count(); index++)
            {
                float[] base_stats = _gnd[index].GetBaseStats();
                _hp += base_stats[0];
                _s_attack += base_stats[1];
                _h_attack += base_stats[2];
            }
        }
        public float[] GetBaseStats()
        {
            float[] baseStats = new float[] { _hp, _s_attack, _h_attack };
            return baseStats;
        }
        public void DamageHp(float hp)
        {
            _hp -= hp;
        }
    }
}
