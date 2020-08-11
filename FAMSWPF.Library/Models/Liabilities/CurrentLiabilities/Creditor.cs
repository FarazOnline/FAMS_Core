using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Liabilities.CurrentLiabilities
{
    [Table("Creditors", Schema = "Liabilities")]
    public class Creditor : IContact
    {
        [Key]
        public int CrId { get; set; }
        [StringLength(100)]
        public string KeyPerson { get; set; }
        [StringLength(100)]
        public string BusinessName { get; set; }
        public bool? Supplier { get; set; }
        public DateTime? Since { get; set; }
        [StringLength(20)]
        public string CNIC { get; set; }
        [StringLength(20)]
        public string NTN { get; set; }
        [StringLength(50)]
        public string JobTitle { get; set; }
        [StringLength(20)]
        public string PlotAddress { get; set; }
        [StringLength(50)]
        public string StreetAddress { get; set; }
        [StringLength(100)]
        public string RegionAddress { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [StringLength(30)]
        public string CellNumber { get; set; }
        [StringLength(30)]
        public string ResidNumber { get; set; }
        [StringLength(30)]
        public string WorkNumber { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("Creditor")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}