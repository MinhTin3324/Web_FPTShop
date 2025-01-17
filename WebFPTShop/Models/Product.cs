//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFPTShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Ratings = new HashSet<Rating>();
        }
    
        public int ProductID { get; set; }
        public string NamePro { get; set; }
        public string DescriptionPro { get; set; }
        public Nullable<int> IDCate { get; set; }
        public Nullable<int> IDManu { get; set; }
        public Nullable<long> Price { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public Nullable<int> SoLuongBan { get; set; }
        public string Screen { get; set; }
        public string Camera { get; set; }
        public string CameraSelfie { get; set; }
        public string CPU { get; set; }
        public Nullable<int> Store { get; set; }
        public string ImagePro { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
