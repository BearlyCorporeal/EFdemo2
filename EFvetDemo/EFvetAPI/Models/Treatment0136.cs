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
    
    public partial class Treatment0136
    {
        public int OwnerID { get; set; }
        public string PetName { get; set; }
        public int ProcedureID { get; set; }
        public decimal Price { get; set; }
        public System.DateTime Date { get; set; }
        public string Notes { get; set; }
    
        public virtual Pet0136 Pet0136 { get; set; }
    }
}
