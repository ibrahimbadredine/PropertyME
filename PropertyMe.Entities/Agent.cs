
namespace PropertyMe.Entities
{
    public class Agent : UserBase
    {
        private Agency _agency;

        public Agency propAgency
        {
            get { return _agency; }
            set { _agency = value; }
        }

    }
}