using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander_NS
{
    public class Commander
    {
        int _level;
        string _name;
        // TODO Image
        public Commander()
        {

        }
        public Commander(int level,
            string name)
        {
            _level = level;
            _name = name;
        }
        // Getters
        public int GetLevel()
        {
            return _level;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
