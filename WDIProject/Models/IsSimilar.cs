//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WDIProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IsSimilar
    {
        public string CountryPrimary { get; set; }
        public string CountrySecondary { get; set; }
        public Nullable<double> SimilarityScore { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Country Country1 { get; set; }
    }
}
