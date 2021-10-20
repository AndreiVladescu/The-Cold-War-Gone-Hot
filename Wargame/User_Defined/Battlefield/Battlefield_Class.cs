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
        public int _air_gun { get; set; }
        public Weather_Enum _weather { get; set; }
        public River_Enum _river { get; set; }
        public Terrain_Enum _terrain { get; set; }
        public Season_Enum _season { get; set; }

        Front _atk = new Front(), 
            _def = new Front();

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
            return 0;
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

    }
}
