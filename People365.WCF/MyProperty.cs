//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace People365.WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class MyProperty
    {
        public MyProperty()
        {
            this.Comments = new HashSet<Comment>();
            this.Favorites = new HashSet<Favorite>();
            this.PropertyPictures = new HashSet<PropertyPicture>();
            this.Ratings = new HashSet<Rating>();
            this.Views = new HashSet<View>();
        }
    
        public long ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Long { get; set; }
        public decimal Lat { get; set; }
        public int Area { get; set; }
        public string Location { get; set; }
        public int PropertyCategoryID { get; set; }
        public int Bedroom { get; set; }
        public int Bathroom { get; set; }
        public string ReferenceNumber { get; set; }
        public long PropertyUserID { get; set; }
        public bool IsSale { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual PropertyCategory PropertyCategory { get; set; }
        public virtual PropertyUser PropertyUser { get; set; }
        public virtual ICollection<PropertyPicture> PropertyPictures { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<View> Views { get; set; }
    }
}
