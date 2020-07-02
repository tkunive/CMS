using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public partial class UserInfo
    {
        [Key]
        [Column("Entity_ID")]
        public int Entity_ID { get; set; }
        [Required]
        [Column("F_Name")]
        [StringLength(100)]
        public string F_Name { get; set; }
        [Required]
        [Column("L_Name")]
        [StringLength(100)]
        public string L_Name { get; set; }
        [Required]
        [Column("EMail")]
        [StringLength(128)]
        public string EMail { get; set; }
        [StringLength(60)]
        public string Fax { get; set; }
        [Column("Special_Info")]
        [StringLength(100)]
        public string Special_Info { get; set; }
        [Column("Passport_ID_Hi")]
        public int? Passport_ID_Hi { get; set; }
        [Column("Passport_ID_Lo")]
        public int? Passport_ID_Lo { get; set; }
        [Column("Primary_Cust_ID")]
        public int? Primary_Cust_ID { get; set; }
        [Column("Geography_ID")]
        public int? Geography_ID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }
        [StringLength(1)]
        public string SkipPassport { get; set; }
        [StringLength(3)]
        public string TelCountryCode { get; set; }
        [StringLength(30)]
        public string TelNumber { get; set; }
        [StringLength(8)]
        public string TelExt { get; set; }
        [Column("skipdc")]
        [StringLength(1)]
        public string skipdc { get; set; }
        [Column("LCID")]
        public int? LCID { get; set; }
        [StringLength(510)]
        public string JobTitle { get; set; }
        public int? TimeZone { get; set; }
        public int? DateFormat { get; set; }
        [StringLength(3)]
        public string CountryCode { get; set; }
    }
}
