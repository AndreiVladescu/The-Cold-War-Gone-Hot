using Enums_NS;
using System.Collections.Generic;

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

        private Ter_Unit() // For testing reasons
        {

        }
        public Ter_Unit(Gen_Enum gen, Ter_Units_Enum unit_type, Regiment_Exp_Enum unit_exp)
        {
            _gen = gen;
            _unit_type = unit_type;
            _unit_exp = unit_exp;


            float unitGenModifier = (float)gen * (float)0.15; // 15% per tech level
            float unitExpModifier = (float)unit_exp * (float)0.25; // 25% per xp level

            List<float> Attr = Parser.Units.GetUnitField((int)unit_type);

            /// Console test
            //foreach (float attr in Attr)
            //{
            //    Console.WriteLine(attr);
            //}

            float hp = Attr[0];
            float s_atk = Attr[1];
            float h_atk = Attr[2];
            float def = Attr[3];
            float armor = Attr[4];
            float pierce = Attr[5];
            float breakt = Attr[6];
            float fuel = Attr[7];
            float reliab = Attr[8];
            float organ = Attr[9];
            float air_atk = Attr[10];
            float entrench = Attr[11];
            float combat_width = Attr[12];
            float hardness = Attr[13];


            //// Commented structures have no sense - the machine doesn't change with unit xp
            hp += unitGenModifier * hp;
            s_atk += unitGenModifier * s_atk;
            h_atk += unitGenModifier * h_atk;
            def += unitGenModifier * def;
            armor += unitGenModifier * armor;
            pierce += unitGenModifier * pierce;
            breakt += unitGenModifier * breakt;
            fuel += unitGenModifier * fuel;
            //reliab += unitGenModifier * reliab;
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
            _reliab = reliab; // + unitExpModifier * reliab;
            _organ = organ + unitExpModifier * organ;
            _air_atk = air_atk + unitExpModifier * air_atk;
            _entrench = entrench + unitExpModifier * entrench;
            _combat_width = combat_width;// + unitExpModifier * combat_width;
            _hardness = hardness; // + unitExpModifier * hardness;
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
