//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Inventory_System_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblcustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblcustomer()
        {
            this.tblinvice_details = new HashSet<tblinvice_details>();
        }
    
        public int Customer_id { get; set; }
        public string Customet_name { get; set; }
        public string Email_address { get; set; }
        public string mobile_number { get; set; }
        public string City { get; set; }
        public string Customer_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblinvice_details> tblinvice_details { get; set; }
    }
}
