using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace People365.WCF
{
    public class PropertyModel
    {
        private long _ID;
        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _title;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _img;
        public string img
        {
            get { return _img; }
            set { _img = value; }
        }

        private string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _type;
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        private decimal _price;
        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _bedrooms;
        public int bedrooms
        {
            get { return _bedrooms; }
            set { _bedrooms = value; }
        }

        private int _bathrooms;
        public int bathrooms
        {
            get { return _bathrooms; }
            set { _bathrooms = value; }
        }

        private decimal _area;
        public decimal area
        {
            get { return _area; }
            set { _area = value; }
        }

        private PositionModel _position;
        public PositionModel position
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _markerIcon;
        public string markerIcon
        {
            get { return "marker-green.png"; }
            set { _markerIcon = value; }
        }

        private string[] _carousselPics;
        public string[] carousselPics
        {
            get { return _carousselPics; }
            set { _carousselPics = value; }
        }

    }

    public class PositionModel
    {
        private decimal _lat;

        public decimal lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        private decimal _lng;

        public decimal lng
        {
            get { return _lng; }
            set { _lng = value; }
        }

    }
}