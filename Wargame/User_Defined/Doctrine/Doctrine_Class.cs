using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Enums_NS;

namespace Doctrine_NS
{
    public class Doctrine
    {
        public string _name { get; set; }
        // TODO Modifiers
        public Doctrine()
        {

        }
        public Doctrine(string name)
        {
            _name = name;
        }
    }
}
