//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFvetAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book0136
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book0136()
        {
            this.student01361 = new HashSet<student0136>();
        }
    
        public int ISBN { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public int AuthorsID { get; set; }
        public int StudentId { get; set; }
    
        public virtual Author0136 Author0136 { get; set; }
        public virtual student0136 student0136 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student0136> student01361 { get; set; }
    }
}
