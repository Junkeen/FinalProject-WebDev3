//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalWebDev3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class activity
    {
        public int activity_ID { get; set; }
        public Nullable<int> user_ID { get; set; }
        public string activity_Title { get; set; }
        public string activity_Description { get; set; }
    
        public virtual activity activity1 { get; set; }
        public virtual activity activity2 { get; set; }
        public virtual User User { get; set; }
    }
}