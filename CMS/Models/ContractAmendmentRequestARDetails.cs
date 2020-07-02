using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    [Table("ContractAmendmentRequestARDetails")]
    public partial class ContractAmendmentRequestARDetails
    {
        [Key]
        [Column("ContractAmendmentRequestID")]
        public long ContractAmendmentRequestId { get; set; }
        [Required]
        [StringLength(20)]
        public string ContractNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductGrouping { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Column("ProductID")]
        public long ProductID { get; set; }
        [Key]
        [Column("LicensableID")]
        [StringLength(20)]
        public string LicensableID { get; set; }
        [StringLength(35)]
        public string LanguageName { get; set; }
        [Required]
        [StringLength(5)]
        public string LanguageCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOnPriceList { get; set; }
        [Column("COAEndItemPartNumber")]
        [StringLength(30)]
        public string CoaendItemPartNumber { get; set; }
        public short Action { get; set; }
        public short Status { get; set; }
        public bool DisplayStatus { get; set; }

        [ForeignKey(nameof(ContractAmendmentRequestId))]
        [InverseProperty("ContractAmendmentRequestARDetails")]
        public virtual ContractAmendmentRequest ContractAmendmentRequest { get; set; }
    }
}
