namespace Enums_NS
{
    public enum Gen_Enum
    {
        // Tech Generations
        Gen1 = 0, // 1950s
        Gen2 = 1, // 1965s
        Gen3 = 2  // 1980s
    }

    public enum Ter_Units_Enum
    {
        // Motorized
        MBT = 101,
        L_Tank = 102,
        H_Mech = 103,
        L_Mech = 104,
        Mot = 105,
        SPAAG = 106,
        SPL_Art = 107,
        SPArt = 108,
        SPH_Art = 109,
        SPAT = 110,
        SPRArt = 111,

        // Leg 
        Inf_Eq = 201,
        AAG = 202,
        L_Art = 203,
        Art = 204,
        H_Art = 205,
        AT = 206
    }

    public enum Air_Units_Enum
    {
        // Jets
        MultiRole_Jet = 301,
        CAS = 302,
        Interd = 303,

        // Helis
        AtkHeli = 401,
        L_AtkHeli = 402
    }

    public enum Weather_Enum
    {
        Stormy = 1,
        Windy = 2,
        Clear = 3
    }

    public enum River_Enum
    {
        No = 0,
        Normal = 1,
        Large = 2
    }

    public enum Terrain_Enum
    {
        Plain = 0,
        Forest = 1,
        Hill = 2,
        Mountain = 3,
        Urban = 4
    }

    public enum Season_Enum
    {
        // For now only winter makes a difference
        Summer = 1,
        Spring = 2,
        Autumn = 3,
        Winter = 4
    }

    public enum Regiment_Exp_Enum
    {
        // Intended for this.value * 25% to get combat modifier
        Green = -1,
        Trained = 0,
        Regular = 1,
        Seasoned = 2,
        Veteran = 3
    }

    public enum Factions_Enum
    {
        // For now
        USA = 1,
        USSR = 2
    }
    public enum Doctrine_Enum
    {
        // Attack
        Breakthrough = 1,
        Well_Planned_Attack = 2,
        Relentless_Assault = 3,

        // Defense
        Elastic_Defense = 11,
        Overwhelming_Fire = 12,
        Backhand_Blow = 13
    }
}
