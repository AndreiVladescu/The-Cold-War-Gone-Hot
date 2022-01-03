using Enums_NS;

namespace Doctrine_NS
{
    public class Doctrine
    {
        public string _name { get; set; }
        public Doctrine_Enum doctrineEnum { get; set; }
        public float attackModifier { get; set; }
        public float defendModifier { get; set; }

        public Doctrine()
        {
            attackModifier = (float)0.075;
            defendModifier = (float)0.075;
        }
        public Doctrine(Doctrine_Enum doctrine)
        {
            doctrineEnum = doctrine;
        }
        public Doctrine(string name)
        {
            _name = name;
        }
    }
}
