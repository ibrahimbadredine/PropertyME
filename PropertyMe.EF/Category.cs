//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PropertyMe.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Properties = new HashSet<Property>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> PictureID { get; set; }
    
        public virtual Picture Picture { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}