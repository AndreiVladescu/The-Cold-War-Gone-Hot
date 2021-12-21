using System;
using System.Collections.Generic;

namespace Parser
{
    class Units
    {
        public struct Air_Unit
        {
            public Air_Unit(int ID, float hp, float air_atk, float gnd_atk,
                float strat_bmb, float air_sup)
            {
                this.ID = ID;
                this.hp = hp;
                this.air_atk = air_atk;
                this.gnd_atk = gnd_atk;
                this.strat_bmb = strat_bmb;
                this.air_sup = air_sup;
            }
            public int ID { get; set; }
            public float hp { get; set; }
            public float air_atk { get; set; }
            public float gnd_atk { get; set; }
            public float strat_bmb { get; set; }
            public float air_sup { get; set; }
        }

        public struct Ter_Unit
        {
            public Ter_Unit(int ID, float hp, float s_atk, float h_atk, float def,
                float armor, float pierce, float breaktr, float fuel, float reliab,
                float organ, float air_atk, float entrench, float combat_width, float hardness)
            {
                this.ID = ID;
                this.hp = hp;
                this.s_atk = s_atk;
                this.h_atk = h_atk;
                this.def = def;
                this.armor = armor;
                this.pierce = pierce;
                this.breaktr = breaktr;
                this.fuel = fuel;
                this.reliab = reliab;
                this.organ = organ;
                this.air_atk = air_atk;
                this.entrench = entrench;
                this.combat_width = combat_width;
                this.hardness = hardness;
            }

            public int ID { get; set; }
            public float hp { get; set; }
            public float s_atk { get; set; }
            public float h_atk { get; set; }
            public float def { get; set; }
            public float armor { get; set; }
            public float pierce { get; set; }
            public float breaktr { get; set; }
            public float fuel { get; set; }
            public float reliab { get; set; }
            public float organ { get; set; }
            public float air_atk { get; set; }
            public float entrench { get; set; }
            public float combat_width { get; set; }
            public float hardness { get; set; }
        }

        static public List<float> GetUnitField(int ID) //folosesc listele globale ca sa caut in ele atributele
        {
            if (ID < 101 || ID > 402)
            {
                Console.WriteLine("Sorry, no unit was found with the ID {0}", ID);
                return null;
            }

            List<float> attributes = new List<float>();

            if (ID < 300)
            {
                foreach (Units.Ter_Unit unit in Wargame.Program.allTerUnits)
                {
                    if (unit.ID == ID)
                    {
                        attributes.Add(unit.hp);
                        attributes.Add(unit.s_atk);
                        attributes.Add(unit.h_atk);
                        attributes.Add(unit.def);
                        attributes.Add(unit.armor);
                        attributes.Add(unit.pierce);
                        attributes.Add(unit.breaktr);
                        attributes.Add(unit.fuel);
                        attributes.Add(unit.reliab);
                        attributes.Add(unit.organ);
                        attributes.Add(unit.air_atk);
                        attributes.Add(unit.entrench);
                        attributes.Add(unit.combat_width);
                        attributes.Add(unit.hardness);

                        return attributes;
                    }
                }
            }
            else
                foreach (Units.Air_Unit unit in Wargame.Program.allAirUnits)
                {
                    if (unit.ID == ID)
                    {
                        attributes.Add(unit.hp);
                        attributes.Add(unit.air_atk);
                        attributes.Add(unit.gnd_atk);
                        attributes.Add(unit.strat_bmb);
                        attributes.Add(unit.air_sup);

                        return attributes;
                    }
                }



            return attributes;
        }

        static public void printUnit(Units.Ter_Unit sumUnit) //testing purposes only
        {
            Console.WriteLine("Unit ID: {0}", sumUnit.ID);
            Console.WriteLine("Unit HP: {0}", sumUnit.hp);
            Console.WriteLine("Unit Soft Attack: {0}", sumUnit.s_atk);
            Console.WriteLine("Unit Hard Attack: {0}", sumUnit.h_atk);
            Console.WriteLine("Unit Defence: {0}", sumUnit.def);
            Console.WriteLine("Unit Armor: {0}", sumUnit.armor);
            Console.WriteLine("Unit Pierce: {0}", sumUnit.pierce);
            Console.WriteLine("Unit Breakthrough: {0}", sumUnit.breaktr);
            Console.WriteLine("Unit Fuel: {0}", sumUnit.fuel);
            Console.WriteLine("Unit Reliability: {0}", sumUnit.reliab);
            Console.WriteLine("Unit Organisation: {0}", sumUnit.organ);
            Console.WriteLine("Unit Air Attack: {0}", sumUnit.air_atk);
            Console.WriteLine("Unit Entrenchment: {0}", sumUnit.entrench);
            Console.WriteLine("Unit Combat Width: {0}", sumUnit.combat_width);
            Console.WriteLine("Unit Hardness: {0}", sumUnit.hardness);
        }

        static public void printUnit(Units.Air_Unit sumUnit)
        {
            Console.WriteLine("Unit ID: {0}", sumUnit.ID);
            Console.WriteLine("Unit HP: {0}", sumUnit.hp);
            Console.WriteLine("Unit Air Attack: {0}", sumUnit.air_atk);
            Console.WriteLine("Unit Ground Attack: {0}", sumUnit.gnd_atk);
            Console.WriteLine("Unit Strategical Bombardments: {0}", sumUnit.strat_bmb);
            Console.WriteLine("Unit Air Support: {0}", sumUnit.air_sup);
        }

    }
}
