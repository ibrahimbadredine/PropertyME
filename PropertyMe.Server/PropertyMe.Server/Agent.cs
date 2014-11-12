

namespace PropertyMe.Entities
{
    public class Agent
    {
        int _ID;
        string _Name;
        string _Email;
        string _Phone;
        string _Mobile;
        Picture _Photo;

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
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        public string Mobile
        {
            get
            {
                return _Mobile;
            }
            set
            {
                _Mobile = value;
            }
        }
        public Picture Photo
        {
            get
            {
                return _Photo;
            }
            set
            {
                _Photo = value;
            }
        }
    }
}