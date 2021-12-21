using Enums_NS;

namespace Doctrine_NS
{
    public class Doctrine
    {
        public string _name { get; set; }
        public Doctrine_Enum doctrineEnum { get; set; }
        // TODO Modifiers
        public Doctrine()
        {

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
