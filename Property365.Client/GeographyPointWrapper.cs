using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Globalization;
using System.Linq;
using System.Spatial;
using System.Web;

namespace Property365.Client
{
    public class GeographyPointWrapper
    {
        public static CultureInfo defaultCulture = CultureInfo.GetCultureInfo("En-Us");
        // implicit Spatial Geography Point to GeographyPointWrapper conversion operator
        public static implicit operator GeographyPointWrapper(GeographyPoint gp)
        {
            double l_lat = (double)(gp != null ? gp.Latitude : 0);
            double l_lon = (double)(gp != null ? gp.Longitude : 0);
            double? l_alt = gp != null ? gp.Z : 0;

            return GeographyPointWrapper.Create(l_lat, l_lon, l_alt);
        }

        // implicit GeographyPointWrapper to Spatial Geography Point conversion operator
        public static implicit operator GeographyPoint(GeographyPointWrapper p)
        {
            double l_lat = (double)(p != null ? p.Latitude : 0);
            double l_lon = (double)(p != null ? p.Longitude : 0);
            double? l_alt = p != null ? p.Altitude : 0;

            return GeographyPoint.Create(l_lat, l_lon, l_alt);
        }

        // implicit SQLGeography to GeographyPointWrapper conversion operator
        public static implicit operator GeographyPointWrapper(DbGeography dbg)
        {
            double l_lat = (double)(dbg != null && dbg.Latitude != null ? dbg.Latitude : 0);
            double l_lon = (double)(dbg != null && dbg.Longitude != null ? dbg.Longitude : 0);
            double? l_alt = dbg != null ? dbg.Elevation : 0;

            return GeographyPointWrapper.Create(l_lat, l_lon, l_alt);
        }

        // implicit GeographyPointWrapper to SQLGeography conversion operator
        public static implicit operator DbGeography(GeographyPointWrapper p)
        {
            // has to be optimized !!
            return DbGeography.FromText("POINT(" + p.Latitude.ToString(defaultCulture)
            + " " + p.Longitude.ToString(defaultCulture) + ")");
        }

        public static GeographyPointWrapper Create(double lat, double lon, double? alt)
        {
            return new GeographyPointWrapper(lat, lon, alt);
        }

        double _lat;
        double _lon;
        double? _alt;

        protected GeographyPointWrapper(double lat, double lon, double? alt)
        {
            _lat = lat;
            _lon = lon;
            _alt = alt;
        }

        public double Latitude { get { return _lat; } set { _lat = value; } }
        public double Longitude { get { return _lon; } set { _lon = value; } }
        public double? Altitude { get { return _alt; } set { _alt = value; } }
    }
}