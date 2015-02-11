
namespace PropertyMe.Entities
{
    public class UserBase : IEntity
    {
        int _ID;
        string _Name;
        string _Password;
        string _Tel;
        string _Email;
        string _Description;
        bool _Active;
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
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
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
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
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
