//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Property365.EFCodeFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyUser
    {
        public PropertyUser()
        {
            this.MyProperties = new HashSet<MyProperty>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public Nullable<long> PictureID { get; set; }
        public int PropertyRoleID { get; set; }
        public bool isActive { get; set; }
    
        public virtual ICollection<MyProperty> MyProperties { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual PropertyRole PropertyRole { get; set; }
    }
}
