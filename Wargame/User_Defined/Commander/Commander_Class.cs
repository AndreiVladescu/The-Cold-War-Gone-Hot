namespace Commander_NS
{
    public class Commander
    {
        public int _level { get; set; }
        public string _name { get; set; }
        public Commander()
        {

        }
        public Commander(int level,
            string name)
        {
            _level = level;
            _name = name;
        }
    }
}
