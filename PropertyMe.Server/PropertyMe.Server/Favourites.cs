using System.Collections.Generic;


namespace PropertyMe.Entities
{
    class Favourites
    {
        int _ID;
        User _User;
        List<Property> _Properties;

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
        public User User
        {
            get
            {
                return _User;
            }
            set
            {
                _User = value;
            }
        }
        public List<Property> Properties
        {
            get
            {
                return _Properties;
            }
            set
            {
                _Properties = value;
            }
        }

    }
}