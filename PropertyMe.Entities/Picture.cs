

namespace PropertyMe.Entities
{
    public class Picture
    {
        int _ID;
        byte[] _Image;

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
    }
}