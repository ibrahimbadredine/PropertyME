

namespace PropertyMe.Entities
{
    public class Location : IEntity
    {
        int _ID;
        string _Name;
        Location _SubLocation;

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

        public Location SubLocation
        {
            get
            {
                return _SubLocation;
            }
            set
            {
                _SubLocation = value;
            }
        }
    }
}