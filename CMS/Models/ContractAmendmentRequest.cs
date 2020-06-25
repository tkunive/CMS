using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public partial class ContractAmendmentRequest
    {
        public ContractAmendmentRequest()
        {
            ContractAmendmentRequestARDetails = new HashSet<ContractAmendmentRequestARDetails>();
        }

        [Key]
        [Column("ContractAmendmentRequestID")]
        public long ContractAmendmentRequestId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SubmissionDateTime { get; set; }
        [Column("SAPResponseDateTime", TypeName = "datetime")]
        public DateTime? SAPResponseDateTime { get; set; }
        [Column("SAPResponseDetails")]
        public string SAPResponseDetails { get; set; }
        [Column("EntityID")]
        public int EntityID { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerNumber { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public short Status { get; set; }
        public short Type { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [StringLength(20)]
        public string LastModifiedBy { get; set; }
        public bool? IsArchived { get; set; }
        [StringLength(256)]
        public string UserEmail { get; set; }

        [InverseProperty("ContractAmendmentRequest")]
        public virtual ICollection<ContractAmendmentRequestARDetails> ContractAmendmentRequestARDetails { get; set; }
    }
}
