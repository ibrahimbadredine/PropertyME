
namespace PropertyMe.Entities
{
    public class Agent : UserBase
    {
        string _Phone;
        string _Mobile;
        Picture _Photo;

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