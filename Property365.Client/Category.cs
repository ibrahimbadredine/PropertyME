//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Property365.Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.MyProperties = new HashSet<MyProperty>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> PictureID { get; set; }
    
        public virtual Picture Picture { get; set; }
        public virtual ICollection<MyProperty> MyProperties { get; set; }
    }
}