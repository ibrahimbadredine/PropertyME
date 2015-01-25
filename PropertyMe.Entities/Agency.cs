using System.Collections.Generic;

namespace PropertyMe.Entities
{
    public class Agency: IEntity
    {
        int _ID;
        string _Name;
        List<Agent> _Agents;
        Picture _Logo;
        private string _Phone;
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

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
                _Agents = value;
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
                _Logo = value;
            }
        }
    }
}