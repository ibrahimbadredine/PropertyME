

namespace PropertyMe.Entities
{
    public class Picture
    {
        int _ID;
        byte[] _Image;
        Property _Property;

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
        public byte[] Image
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;
            }
        }
        public Property Property
        {
            get
            {
                return _Property;
            }
            set
            {
                _Property = value;
            }
        }
    }
}