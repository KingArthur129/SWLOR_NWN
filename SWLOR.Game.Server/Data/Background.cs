//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWLOR.Game.Server.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Background
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Background()
        {
            this.Name = "";
            this.Description = "";
            this.Bonuses = "";
        }
    
        public int BackgroundID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bonuses { get; set; }
        public bool IsActive { get; set; }
    }
}
