using System.Collections.Generic;


namespace PropertyMe.Entities
{
    class Agency
    {
        int _ID;
        string _Name;
        List<Agent> _Agents;
        Picture _Logo;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public List<Agent> Agents
        {
            get
            {
                return _Agents;
            }
            set
            {
                Agents = value;
            }
        }
        public Picture Logo
        {
            get
            {
                return _Logo;
            }
            set
            {
                Logo = value;
            }
        }
    }
}