using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Enums_NS;
using Front_NS;

namespace Battlefield_NS
{
    public class Battlefield
    {
        public static Battlefield battlefieldInstance = new Battlefield();
        public int _time { get; set; }
        public int _fort_level { get; set; }
        public int _air_gun_level { get; set; }
        public Weather_Enum _weather { get; set; }
        public River_Enum _river { get; set; }
        public Terrain_Enum _terrain { get; set; }
        public Season_Enum _season { get; set; }

        Front _atk = new Front(), 
            _def = new Front();

        bool _is_night = false;

        float _fort_modifier,
            _air_gun_level_modifier,
            _river_crossing_modifier,
            _terrain_modifier_def,
            _terrain_modifier_atk,
            _weather_modifier,
            _season_modifier_air,
            _season_modifier_gnd;


        private Battlefield()
        {

        }
        private Battlefield(int time, 
            int fort_level,
            Weather_Enum weather,
            River_Enum river, 
            Terrain_Enum terrain, 
            Season_Enum season)
        {
            _time = time;
            _fort_level = fort_level;
            _weather = weather;
            _river = river;
            _terrain = terrain;
            _season = season;
        }
        public int ComputeTurn()
        {
            UpdateModifiers();
            UpdateEnvironment();

            DefenderDealDamagge();
            AttackerDealDamage();

            return DetermineWinner();
        }
        private int DetermineWinner()
        {
            if (_atk.IsTerDefeated())
                return 2;
            else if (_def.IsTerDefeated())
                return -2;
            else if (_atk.IsAirDefeated())
                return 1;
            else if (_def.IsAirDefeated())
                return -1;
            else
                return 0;
        }
        private void DefenderDealDamagge()
        {
            float gnd_damage = new float();
            float air_damage = new float();

            TerStruct terStruct = _def.GetTerStruct();
            int numberOfTerUnits = _def.GetTerUnitNumber();
            float actualHardness = terStruct._hardness / numberOfTerUnits;

            gnd_damage = (actualHardness * terStruct._h_atk + (1 - actualHardness) * terStruct._s_atk); // Phase one
            gnd_damage += gnd_damage * _terrain_modifier_def; // Phase two

            air_damage = terStruct._air_atk; // Phase one

            _atk.DamageTerHp(gnd_damage);
            _atk.DamageAirHp(air_damage);

        }
        private void AttackerDealDamage()
        {

        }
        private void UpdateModifiers()
        {
            if (_time < 22 && _time > 6)
                _is_night = false;
            else 
                _is_night = true;

            _fort_modifier = _fort_level * (float)0.1;

            _air_gun_level_modifier = _air_gun_level * (float)0.1;

            switch (_terrain)
            {
                case Terrain_Enum.Forest:
                    {
                        _terrain_modifier_atk = -(float)0.2;
                        _terrain_modifier_def = (float)0;
                        break;
                    }
                case Terrain_Enum.Hill:
                    {
                        _terrain_modifier_atk = -(float)0.3;
                        _terrain_modifier_def = (float)0;
                        break;
                    }
                case Terrain_Enum.Mountain:
                    {
                        _terrain_modifier_atk = -(float)0.6;
                        _terrain_modifier_def = (float)0;
                        break;
                    }
                case Terrain_Enum.Urban:
                    {
                        _terrain_modifier_atk = -(float)0.4;
                        _terrain_modifier_def = (float)0.2;
                        break;
                    }
                default:
                    {
                        _terrain_modifier_atk = (float)0;
                        _terrain_modifier_def = (float)0;
                        break;
                    }
            }
            switch (_river)
            {
                case River_Enum.Normal:
                    {
                        _river_crossing_modifier = (float)0.3;
                        break;
                    }
                case River_Enum.Large:
                    {
                        _river_crossing_modifier = (float)0.6;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            switch (_weather)
            {
                case Weather_Enum.Stormy:
                    {
                        _weather_modifier = (float)0.6;
                        break;
                    }
                case Weather_Enum.Windy:
                    {
                        _weather_modifier = (float)0.2;
                        break;
                    }
                default:
                    {
                        _weather_modifier = (float)0;
                        break;
                    }
            }
            switch (_season)
            {
                case (Season_Enum.Winter):
                    {
                        _season_modifier_air = (float)0.2;
                        _season_modifier_gnd = (float)0.35;
                        break;
                    }
                default:
                    {
                        _season_modifier_air = (float)0;
                        _season_modifier_gnd = (float)0;
                        break;
                    }
            }

        }
        private void UpdateEnvironment()
        {
            // Chance for weather to become stormy, windy or clear
            Random random = new Random();
            float weather_change_chance = random.Next(0, 1);
            if (weather_change_chance >= 0.9)
            {
                this._weather = Weather_Enum.Stormy;
            }
            else if (weather_change_chance >= 0.7)
            {
                this._weather = Weather_Enum.Windy;
            }
            else
                this._weather = Weather_Enum.Clear;

            // An hour passes since last engagement
            _time++;

        }
        public void AddDefAirUnit(Gen_Enum gen, Air_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _def.AddAirUnit(gen, unit_type, unit_exp);
        }
        public void AddAtkAirUnit(Gen_Enum gen, Air_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _atk.AddAirUnit(gen, unit_type, unit_exp);
        }
        public void SubDefAirUnit(Gen_Enum gen, Air_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _def.SubAirUnit(gen, unit_type, unit_exp);
        }
        public void SubAtkAirUnit(Gen_Enum gen, Air_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _atk.SubAirUnit(gen, unit_type, unit_exp);

        }
        public void AddDefTerUnit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _def.AddTerUnit(gen, unit_type, unit_exp);
        }
        public void AddAtkTerUnit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _atk.AddTerUnit(gen, unit_type, unit_exp);
        }
        public void SubDefTerUnit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _def.SubTerUnit(gen, unit_type, unit_exp);
        }
        public void SubAtkTerUnit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _atk.SubTerUnit(gen, unit_type, unit_exp);
        }
        public int GetDefLegUnitNumber()
        {
            return _def.GetLegUnitNumber();
        }
        public int GetAtkLegUnitNumber()
        {
            return _atk.GetLegUnitNumber();
        }
        public int GetDefMobUnitNumber()
        {
            return _def.GetMobUnitNumber();
        }
        public int GetAtkMobUnitNumber()
        {
            return _atk.GetMobUnitNumber();
        }
        public int GetDefAirUnitNumber()
        {
            return _def.GetAirUnitNumber();
        }
        public int GetAtkAirUnitNumber()
        {
            return _atk.GetAirUnitNumber();
        }
    }
}
