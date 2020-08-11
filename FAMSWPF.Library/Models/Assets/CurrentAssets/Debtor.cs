using FAMSWPF.Library.Models.Assets.ContraAssets;
using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets
{
    [Table("Debtors", Schema = "Assets")]
    public class Debtor : IContact
    {
        [Key]
        public int DebtorId { get; set; }
        [Required, MaxLength(100)]
        public string KeyPerson { get; set; }
        [MaxLength(100)]
        public string BusinessName { get; set; }
        public bool? Customer { get; set; }
        public DateTime? CustomerSince { get; set; }
        [Column("CNIC")]
        [MaxLength(20)]
        public string CNIC { get; set; }
        [Column("NTN")]
        [MaxLength(20)]
        public string NTN { get; set; }
        [MaxLength(100)]
        public string JobTitle { get; set; }
        [MaxLength(20)]
        public string PlotAddress { get; set; }
        [MaxLength(50)]
        public string StreetAddress { get; set; }
        [MaxLength(100)]
        public string RegionAddress { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string EmailAddress { get; set; }
        [Required, MaxLength(30)]
        public string CellNumber { get; set; }
        [MaxLength(30)]
        public string ResidNumber { get; set; }
        [MaxLength(30)]
        public string WorkNumber { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("Debtor")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainDebtorWhich")]
        public DebtorX DebtorX { get; set; }
        #endregion
    }
}
