using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.Spatial;
using System.Web;

namespace Property365.Client
{
    [IgnorePropertiesAttribute("location")]
    [DataServiceKey("THING_KEY")]

    public class IOfThings_Things
    {
        GeographyPointWrapper _w;

        public IOfThings_Things()
        {
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long THING_KEY { get; set; }
        public long CLASS_KEY { get; set; }
        public System.Data.Spatial.DbGeography location { get { return _w; } set { _w = value; } }
        public Nullable timestamp { get; set; }
        public string metadataURI { get; set; }
        public string serviceURI { get; set; }
        public string manifestURI { get; set; }

        [NotMappedAttribute]
        public GeographyPoint wcf_location { get { return _w; } set { _w = value; } }
    }
}