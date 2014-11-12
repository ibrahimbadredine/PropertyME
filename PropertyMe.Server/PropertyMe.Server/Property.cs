using System.Collections.Generic;

namespace PropertyMe.Entities
{
    public class Property
    {
        int _ID;
        decimal _Price;
        Location _Location;
        Category _Category;
        int _Size;
        int _Bedrooms;
        int _BathRooms;
        List<Picture> _Pictures;
        string _ReferenceNumber;
        string _Description;
        Agent _Agent;
        List<Feature> _Features;
        decimal _Lattitude;
        decimal _Longitude;
        bool _IsSale;
        bool _IsRent;

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
        public decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }
        public Location Location
        {
            get
            {
                return _Location;
            }
            set
            {
                _Location = value;
            }
        }
        public Category Category
        {
            get
            {
                return _Category;
            }
            set
            {
                _Category = value;
            }
        }
        public int Size
        {
            get { return _Size; }
            set { _Size = value; }
        }
        public int Bedrooms
        {
            get
            {
                return _Bedrooms;
            }
            set
            {
                _Bedrooms = value;
            }
        }
        public int BathRooms
        {
            get
            {
                return _BathRooms;
            }
            set
            {
                _BathRooms = value;
            }
        }
        public List<Picture> Pictures
        {
            get
            {
                return _Pictures;
            }
            set
            {
                _Pictures = value;
            }
        }
        public string ReferenceNumber
        {
            get
            {
                return _ReferenceNumber;
            }
            set
            {
                _ReferenceNumber = value;
            }
        }
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
        public Agent Agent
        {
            get
            {
                return _Agent;
            }
            set
            {
                _Agent = value;
            }
        }
        public List<Feature> Features
        {
            get
            {
                return _Features;
            }
            set
            {
                _Features = value;
            }
        }
        public decimal Lattitude
        {
            get
            {
                return _Lattitude;
            }
            set
            {
                _Lattitude = value;
            }
        }
        public decimal Longitude
        {
            get
            {
                return _Longitude;
            }
            set
            {
                _Longitude = value;
            }
        }
        public bool IsSale
        {
            get
            {
                return _IsSale;
            }
            set
            {
                _IsSale = value;
            }
        }
        public bool IsRent
        {
            get
            {
                return _IsRent;
            }
            set
            {
                _IsRent = value;
            }
        }

    }
}
