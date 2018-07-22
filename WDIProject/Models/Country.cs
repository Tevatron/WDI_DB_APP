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
    
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            this.CollectedThroughs = new HashSet<CollectedThrough>();
            this.CollectedThroughs1 = new HashSet<CollectedThrough>();
            this.Footnotes = new HashSet<Footnote>();
            this.Indicators = new HashSet<Indicator>();
            this.IsSimilars = new HashSet<IsSimilar>();
            this.IsSimilars1 = new HashSet<IsSimilar>();
        }
    
        public string CountryCode { get; set; }
        public string ShortName { get; set; }
        public string TableName { get; set; }
        public string LongName { get; set; }
        public string Alpha2Code { get; set; }
        public string CurrencyUnit { get; set; }
        public string SpecialNotes { get; set; }
        public string Region { get; set; }
        public string IncomeGroup { get; set; }
        public string Wb2Code { get; set; }
        public string NationalAccountsBaseYear { get; set; }
        public string NationalAccountsReferenceYear { get; set; }
        public string SnaPriceValuation { get; set; }
        public string LendingCategory { get; set; }
        public string OtherGroups { get; set; }
        public string SystemOfNationalAccounts { get; set; }
        public string AlternativeConversionFactor { get; set; }
        public string PppSurveyYear { get; set; }
        public string BalanceOfPaymentsManualInUse { get; set; }
        public string ExternalDebtReportingStatus { get; set; }
        public string SystemOfTrade { get; set; }
        public string GovernmentAccountingConcept { get; set; }
        public string ImfDataDisseminationStandard { get; set; }
        public string LatestPopulationCensus { get; set; }
        public string LatestHouseholdSurvey { get; set; }
        public string SourceOfMostRecentIncomeAndExpenditureData { get; set; }
        public string VitalRegistrationComplete { get; set; }
        public string LatestAgriculturalCensus { get; set; }
        public string LatestIndustrialData { get; set; }
        public Nullable<double> LatestTradeData { get; set; }
        public Nullable<double> LatestWaterWithdrawalData { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectedThrough> CollectedThroughs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectedThrough> CollectedThroughs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Footnote> Footnotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indicator> Indicators { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsSimilar> IsSimilars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsSimilar> IsSimilars1 { get; set; }
    }
}
