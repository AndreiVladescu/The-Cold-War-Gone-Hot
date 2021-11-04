﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Enums_NS;
using Front_NS;
using Ter_Units_NS;
using Air_Units_NS;
using Wargame.User_Defined.Tools;

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

        public bool _atk_ter_attacks { get; set; }
        public bool _atk_air_attacks { get; set; }
        public bool _def_air_attacks { get; set; }

        float _fort_modifier,
            _air_gun_level_modifier,
            _river_crossing_modifier,
            _terrain_modifier_def,
            _terrain_modifier_atk,
            _weather_modifier,
            _season_modifier_air,
            _season_modifier_gnd,
            _night_attack_modifier;

        float _AABattery_dmg,
            _fort_dmg;

        int _fort_dmg_threshold = 40;
        int _AABattery_dmg_threshold = 35;

        private Battlefield()
        {
            _time = 12;
            _fort_level = 0;
            _air_gun_level = 0;
            _river = River_Enum.No;
            _terrain = Terrain_Enum.Plain;
            _season = Season_Enum.Spring;
            _weather = Weather_Enum.Clear;
            _atk_ter_attacks = true;
            _atk_air_attacks = true;
            _def_air_attacks = true;

            _AABattery_dmg = 0;
            _fort_dmg = 0;

            _atk.SetCommander(1, "Zhukov");
            _def.SetCommander(1, "MacArthur");

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
        #region Computing 
        public int ComputeTurn()
        {
            UpdateModifiers();
            UpdateEnvironment();

            // Aerial attacks come first
            // TODO add rng
            if (_atk_air_attacks == true && _def_air_attacks == true)
            {
                MutualAeriaLAttack();
            }
            else if (_atk_air_attacks == true)
            {
                AttackerAerialAttack();
            }
            else if (_def_air_attacks == true)
            {
                DefenderAerialAttack();
            }

            if (_atk_ter_attacks == true)
            {
                // TODO add rng
                DefenderGroundAttack(); // Defender starts first 
                AttackerGroundAttack();
            }

            //DefenderDealDamage();
            //AttackerDealDamage();

            return DetermineWinner();
        }
        private void AttackerGroundAttack()
        {
            if (_atk.IsTerDefeated())
                return;
            float damage; // The damage which is to be modified

            TerStruct thisPartyStruct = _atk.GetTerStruct();
            TerStruct otherPartyStruct = _def.GetTerStruct();

            int thisPartyNrOfUnits = _atk.GetTerUnitNumber();
            int otherPartyNrOfUnits = _def.GetTerUnitNumber();

            #region Attack_Modifiers
            float actual_defence_of_defender = otherPartyStruct._def * (1 + ((otherPartyStruct._entrench * 2) / otherPartyNrOfUnits) / 100);
            float atk_modifier_def_brkt = Tools.ReturnDefenseBreakthroughEffectiveness(actual_defence_of_defender, thisPartyStruct._breakt);
            float atk_modifier_armor_pierce = Tools.ReturnArmorPiercingEffectiveness(otherPartyStruct._armor, thisPartyStruct._pierce);
            float atk_modifier_combat_width = Tools.ReturnCombatWidthEffectiveness((int)thisPartyStruct._combat_width);
            #endregion

            #region Combat_Variables
            float actualHardness = (otherPartyStruct._hardness / otherPartyNrOfUnits) / 100; // Gives a rough estimate of how armored the enemy is
            float attackSegregated = actualHardness * thisPartyStruct._h_atk + (1 - actualHardness) * thisPartyStruct._s_atk;
            #endregion

            #region Battlefield_Variables

            #endregion

            // Apply combat related factors
            damage = attackSegregated *
                atk_modifier_armor_pierce *
                atk_modifier_combat_width *
                atk_modifier_def_brkt;

            // Apply battlefield specific factors
            damage *= (1 - _fort_modifier * _fort_level);

            // Apply natural related factors
            damage += damage * _terrain_modifier_atk;
            damage = damage *
                (1 - _season_modifier_gnd) *
                _night_attack_modifier *
                (1 - _river_crossing_modifier);

            // TODO entrenchment - done
            // TODO reliability losses - done
            // TODO fuel usage
            // TODO organisation loss

            // Added reliability losses for the attacker side after his attack
            float reliability_losses_for_attacker = Tools.ReturnCombatLossesThroughReliability(thisPartyStruct._reliab / thisPartyNrOfUnits, thisPartyStruct._hp);
            _atk.DamageTerHp(reliability_losses_for_attacker);
            
            // Finally, dish the damage
            _def.DamageTerHp(damage);
        }
        private void DefenderGroundAttack()
        {
            if (_def.IsTerDefeated())
                return;
            float damage; // The damage which is to be modified

            TerStruct thisPartyStruct = _def.GetTerStruct();
            TerStruct otherPartyStruct = _atk.GetTerStruct();

            int thisPartyNrOfUnits = _def.GetTerUnitNumber();
            int otherPartyNrOfUnits = _atk.GetTerUnitNumber();

            #region Attack_Modifiers
            float atk_modifier_def_brkt = Tools.ReturnDefenseBreakthroughEffectiveness(otherPartyStruct._def, thisPartyStruct._breakt);
            float atk_modifier_armor_pierce = Tools.ReturnArmorPiercingEffectiveness(otherPartyStruct._armor, thisPartyStruct._pierce);
            float atk_modifier_combat_width = Tools.ReturnCombatWidthEffectiveness((int)thisPartyStruct._combat_width);
            #endregion

            #region Combat_Variables
            float actualHardness = (otherPartyStruct._hardness / otherPartyNrOfUnits) / 100; // Gives a rough estimate of how armored the enemy is
            float attackSegregated = actualHardness * thisPartyStruct._h_atk + (1 - actualHardness) * thisPartyStruct._s_atk;
            #endregion

            #region Battlefield_Variables

            #endregion

            // Apply combat related factors
            damage = attackSegregated *
                atk_modifier_armor_pierce *
                atk_modifier_combat_width *
                atk_modifier_def_brkt;

            // Apply natural related factors
            damage += damage * _terrain_modifier_def;
            damage = damage *
                (1 - _season_modifier_gnd) *
                _night_attack_modifier;

            // TODO entrenchment - done
            // TODO reliability losses - done
            // TODO fuel usage
            // TODO organisation loss

            // Added reliability losses for the defender side after his attack
            float reliability_losses_for_attacker = Tools.ReturnCombatLossesThroughReliability(thisPartyStruct._reliab / thisPartyNrOfUnits, thisPartyStruct._hp);
            _def.DamageTerHp(reliability_losses_for_attacker);

            // Finally, dish the damage
            _atk.DamageTerHp(damage);
        }
        public void SetFuelAtk(float fuel)
        {
            _atk._fuel_left = fuel;
        }
        public void SetFuelDef(float fuel)
        {
            _def._fuel_left = fuel;
        }
        private void MutualAeriaLAttack()
        {
            if (_atk.IsAirDefeated() && _def.IsAirDefeated())
                return;

            Random rand = new Random();

            AirStruct airStructAtk = _atk.GetAirStruct();
            AirStruct airStructDef = _def.GetAirStruct();
            TerStruct terStructAtk = _atk.GetTerStruct();
            TerStruct terStructDef = _def.GetTerStruct();


            float damage_done_atk = airStructAtk._air_atk + terStructAtk._air_atk;
            float damage_done_def = airStructDef._air_atk + terStructDef._air_atk + _air_gun_level * 10;

            #region Modifiers
            float air_superiorty_modifier = Tools.ReturnAirSuperiorityEffectiveness(airStructAtk._air_sup, airStructDef._air_sup, _air_gun_level / 10);
            #endregion

            //  Ground Attack Part
            #region Ground Attack
            float damage_done_atk_gnd = airStructAtk._gnd_atk;
            float damage_done_def_gnd = airStructDef._gnd_atk;

            // RNG part
            float rng = rand.Next(-5, 5);
            if (!_def.IsAirDefeated())
                _def.DamageTerHp((damage_done_atk_gnd * (1 + rng / 100)) * air_superiorty_modifier);
            rng = rand.Next(-5, 5);
            if (!_atk.IsAirDefeated())
                _atk.DamageTerHp((damage_done_def_gnd * (1 + rng / 100)) * ( 1 / air_superiorty_modifier));
            #endregion

            #region Air Attack
            rng = rand.Next(-5, 5);
            float actual_damage_done_atk = (damage_done_atk * (1 + rng / 100)) * air_superiorty_modifier;
            rng = rand.Next(-5, 5);
            float actual_damage_done_def = (damage_done_def * (1 + rng / 100)) * (1 / air_superiorty_modifier);

            if (!_def.IsAirDefeated())
                _def.DamageAirHp(actual_damage_done_atk);
            if (!_atk.IsAirDefeated())
                _atk.DamageAirHp(actual_damage_done_def);
            #endregion

            #region Strategic Bombing
            if (_atk.IsAirDefeated())
                return;
            rng = rand.Next(-5, 5);
            float strategic_bombing_dmg = (airStructAtk._strat_bmb * (1 + rng / 100)) * air_superiorty_modifier;

            _fort_dmg += strategic_bombing_dmg;

            int fort_levels_destroyed = (int)_fort_dmg / _fort_dmg_threshold;
            _fort_dmg %= _fort_dmg_threshold;
            _fort_level -= fort_levels_destroyed;

            if (_fort_level < 0)
                _fort_level = 0;

            _AABattery_dmg += strategic_bombing_dmg;

            int AABattery_levels_destroyed = (int)_AABattery_dmg / _AABattery_dmg_threshold;
            _AABattery_dmg %= _AABattery_dmg_threshold;
            _air_gun_level -= AABattery_levels_destroyed;

            if (_air_gun_level < 0)
                _air_gun_level = 0;

            #endregion

        }
        private void AttackerAerialAttack()
        {
            if (_atk.IsAirDefeated())
                return;
            AirStruct airStructAtk = _atk.GetAirStruct();
            TerStruct terStructDef = _def.GetTerStruct();

            float damage_done = airStructAtk._gnd_atk;
            //airStructAtk;
            Random rand = new Random();
            float rng = rand.Next(-5, 5);

            if (!_def.IsAirDefeated())
                _def.DamageTerHp(damage_done * (1 + rng / 100));

            // Damage to the airwings

            if (!_def.IsTerDefeated())
            {
                _atk.DamageAirHp(terStructDef._air_atk + _air_gun_level * 10);
            }

            if (_atk.IsAirDefeated())
                return;

            // Strategic Bombing
            rng = rand.Next(-5, 5);
            float strategic_bombing_dmg = airStructAtk._strat_bmb * (1 + rng / 100);

            _fort_dmg += strategic_bombing_dmg;

            int fort_levels_destroyed = (int)_fort_dmg / _fort_dmg_threshold;
            _fort_dmg %= _fort_dmg_threshold;
            _fort_level -= fort_levels_destroyed;

            if (_fort_level < 0)
                _fort_level = 0;

            _AABattery_dmg += strategic_bombing_dmg;

            int AABattery_levels_destroyed = (int)_AABattery_dmg / _AABattery_dmg_threshold;
            _AABattery_dmg %= _AABattery_dmg_threshold;
            _air_gun_level -= AABattery_levels_destroyed;

            if (_air_gun_level < 0)
                _air_gun_level = 0;
        }
        private void DefenderAerialAttack()
        {
            if (_def.IsAirDefeated())
                return;
            AirStruct airStructDef = _def.GetAirStruct();
            TerStruct terStructAtk = _atk.GetTerStruct();

            float damage_done = airStructDef._gnd_atk;

            Random rand = new Random();
            float rng = rand.Next(-5, 5);

            _atk.DamageTerHp(damage_done * (1 + rng / 100));

            if (_atk.IsTerDefeated())
                return;

            _def.DamageAirHp(terStructAtk._air_atk);

        }
        public string GetCommanderNameDef()
        {
            return _def.GetCommanderName();
        }
        public string GetCommanderNameAtk()
        {
            return _atk.GetCommanderName();
        }
        public void SetCommanderNameAtk(string name)
        {
            _atk.SetCommanderName(name);
        }
        public void SetCommanderNameDef(string name)
        {
            _def.SetCommanderName(name);
        }
        private int DetermineWinner()
        {
            if (_atk.IsTerDefeated() && _atk.IsAirDefeated())
                return 3;
            else if (_def.IsTerDefeated() && _def.IsAirDefeated())
                return -3;
            else if (_atk.IsTerDefeated())
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
        private void DefenderDealDamage()
        {
            float gnd_damage = new float();
            float air_damage = new float();
            TerStruct terStruct = _def.GetTerStruct();
            TerStruct otherPartyterStruct = _atk.GetTerStruct();
            int numberOfTerUnits = _def.GetTerUnitNumber();
            int otherPartynumberOfTerUnits = _atk.GetTerUnitNumber();


            float atk_modifier_armor_pierce = 0;
            float atk_modifier_def_brkt = 1;

            atk_modifier_def_brkt += (float)Math.Round((otherPartyterStruct._breakt - terStruct._def) / 5);
            atk_modifier_armor_pierce = Tools.ReturnArmorPiercingEffectiveness(otherPartyterStruct._armor, terStruct._pierce);

            float actualHardness = otherPartyterStruct._hardness / otherPartynumberOfTerUnits;

            gnd_damage = (actualHardness * terStruct._h_atk + (1 - actualHardness) * terStruct._s_atk) * atk_modifier_def_brkt * atk_modifier_armor_pierce; // Phase one
            gnd_damage += gnd_damage * _terrain_modifier_def; // Phase two


            air_damage = terStruct._air_atk; // Phase one

            _atk.DamageTerHp(gnd_damage);
            _atk.DamageAirHp(air_damage);

        }
        private void AttackerDealDamage()
        {
            float gnd_damage = new float();
            float air_damage = new float();
            TerStruct terStruct = _atk.GetTerStruct();
            TerStruct otherPartyterStruct = _def.GetTerStruct();
            int numberOfTerUnits = _atk.GetTerUnitNumber();
            int otherPartynumberOfTerUnits = _def.GetTerUnitNumber();

            float atk_modifier_armor_pierce = 0;
            float atk_modifier_def_brkt = 1;

            atk_modifier_def_brkt += (float)Math.Round((terStruct._breakt - otherPartyterStruct._def) / 5);
            atk_modifier_armor_pierce = Tools.ReturnArmorPiercingEffectiveness(otherPartyterStruct._armor, terStruct._pierce);

            float actualHardness = otherPartyterStruct._hardness / otherPartynumberOfTerUnits;

            gnd_damage = (actualHardness * terStruct._h_atk + (1 - actualHardness) * terStruct._s_atk) * atk_modifier_def_brkt * atk_modifier_armor_pierce; // Phase one
            gnd_damage += gnd_damage * _terrain_modifier_atk; // Phase two

            air_damage = terStruct._air_atk; // Phase one

            _def.DamageTerHp(gnd_damage);
            _def.DamageAirHp(air_damage);
        }
        private void UpdateModifiers()
        {
            if (_time < 22 && _time > 6)
            {
                _is_night = false;
                _night_attack_modifier = (float)1;
            }
            else
            {
                _is_night = true;
                _night_attack_modifier = (float)0.5;
            }

            _fort_modifier = _fort_level * (float)0.1;

            _air_gun_level_modifier = _air_gun_level * (float)0.1;

            switch (_terrain)
            {
                case Terrain_Enum.Plain:
                    {
                        _terrain_modifier_atk = (float)0;
                        _terrain_modifier_def = (float)0;
                        break;
                    }
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
        #endregion
        #region Unit Adding/Subtracting
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
        #endregion
        #region Getters
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
        public int GetDefUnitNumber()
        {
            return GetDefLegUnitNumber() + GetDefMobUnitNumber();
        }
        public int GetAtkUnitNumber()
        {
            return GetAtkLegUnitNumber() + GetAtkMobUnitNumber();
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
        public TerStruct GetAtkTerStats()
        {
            return _atk.GetTerStruct();
        }
        public AirStruct GetAtkAirStats()
        {
            return _atk.GetAirStruct();
        }
        public TerStruct GetDefTerStats()
        {
            return _def.GetTerStruct();
        }
        public AirStruct GetDefAirStats()
        {
            return _def.GetAirStruct();
        }
        public string ReturnTerGeneration(Ter_Unit unit)
        {
            string gen;

            switch (unit._gen)
            {
                case Gen_Enum.Gen1:
                    {
                        gen = "Gen1";
                        break;
                    }
                case Gen_Enum.Gen2:
                    {
                        gen = "Gen2";
                        break;
                    }
                case Gen_Enum.Gen3:
                    {
                        gen = "Gen3";
                        break;
                    }
                default:
                    {
                        gen = "Generation default error";
                        break;
                    }
            }
            return gen;
        }
        public string ReturnTerExperience(Ter_Unit unit)
        {
            string exp;
            switch (unit._unit_exp)
            {
                case Regiment_Exp_Enum.Green:
                    {
                        exp = "Green";
                        break;
                    }
                case Regiment_Exp_Enum.Trained:
                    {
                        exp = "Trained";
                        break;
                    }
                case Regiment_Exp_Enum.Regular:
                    {
                        exp = "Regular";
                        break;
                    }
                case Regiment_Exp_Enum.Seasoned:
                    {
                        exp = "Seasoned";
                        break;
                    }
                case Regiment_Exp_Enum.Veteran:
                    {
                        exp = "Veteran";
                        break;
                    }
                default:
                    {
                        exp = "Experience default error";
                        break;
                    }
            }
            return exp;
        }
        public string ReturnAirGeneration(Air_Unit unit)
        {
            string gen;

            switch (unit._gen)
            {
                case Gen_Enum.Gen1:
                    {
                        gen = "Gen1";
                        break;
                    }
                case Gen_Enum.Gen2:
                    {
                        gen = "Gen2";
                        break;
                    }
                case Gen_Enum.Gen3:
                    {
                        gen = "Gen3";
                        break;
                    }
                default:
                    {
                        gen = "Generation default error";
                        break;
                    }
            }
            return gen;
        }
        public string ReturnAirExperience(Air_Unit unit)
        {
            string exp;
            switch (unit._unit_exp)
            {
                case Regiment_Exp_Enum.Green:
                    {
                        exp = "Green";
                        break;
                    }
                case Regiment_Exp_Enum.Trained:
                    {
                        exp = "Trained";
                        break;
                    }
                case Regiment_Exp_Enum.Regular:
                    {
                        exp = "Regular";
                        break;
                    }
                case Regiment_Exp_Enum.Seasoned:
                    {
                        exp = "Seasoned";
                        break;
                    }
                case Regiment_Exp_Enum.Veteran:
                    {
                        exp = "Veteran";
                        break;
                    }
                default:
                    {
                        exp = "Experience default error";
                        break;
                    }
            }
            return exp;
        }
        public string GetDefArmyComposition()
        {
            string returnString = "";

            
            List<Ter_Unit> ter_Units = _def.GetTerUnits();

            ter_Units.Sort((x,y) =>
                x._unit_type.CompareTo(y._unit_type));

            for (int index = 0; index< ter_Units.Count(); index++)
            {
                switch (ter_Units[index]._unit_type)
                {
                    case Ter_Units_Enum.MBT:
                        {
                            returnString += "MBT " + ReturnTerGeneration(ter_Units[index]) + ReturnTerExperience(ter_Units[index]);
                            break;
                        }
                    case Ter_Units_Enum.L_Tank:
                        {
                            break;
                        }
                    case Ter_Units_Enum.H_Mech:
                        {
                            break;
                        }
                    case Ter_Units_Enum.L_Mech:
                        {
                            break;
                        }
                    case Ter_Units_Enum.Mot:
                        {
                            break;
                        }
                    case Ter_Units_Enum.SPAAG:
                        {
                            break;
                        }
                    case Ter_Units_Enum.SPL_Art:
                        {
                            break;
                        }
                    case Ter_Units_Enum.SPArt:
                        {
                            break;
                        }
                    case Ter_Units_Enum.SPH_Art:
                        {
                            break;
                        }
                    case Ter_Units_Enum.SPAT:
                        {
                            break;
                        }
                    case Ter_Units_Enum.SPRArt:
                        {
                            break;
                        }
                    case Ter_Units_Enum.Inf_Eq:
                        {
                            break;
                        }
                    case Ter_Units_Enum.AAG:
                        {
                            break;
                        }
                    case Ter_Units_Enum.L_Art:
                        {
                            break;
                        }
                    case Ter_Units_Enum.Art:
                        {
                            break;
                        }
                    case Ter_Units_Enum.H_Art:
                        {
                            break;
                        }
                    case Ter_Units_Enum.AT:
                        {
                            break;
                        }
                    default:
                        {
                            returnString = "Default error";
                            break;
                        }
                }
            }

            return returnString;
        }
        #endregion
    }
}
