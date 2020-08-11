using FAMSWPF.Library.Models.Equity.Contra;
using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Equity
{
    [Table("Capital", Schema = "Capital")]
    public class Capital: IContact
    {
        [Key]
        public int CapId { get; set; }
        [StringLength(100)]
        public string KeyPerson { get; set; }
        [MaxLength(100)]
        public string BusinessName { get; set; }
        public double ShareRatio { get; set; }
        public DateTime OwnerSince { get; set; }
        [StringLength(20)]
        public string CNIC { get; set; }
        [StringLength(20)]
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
        [ForeignKey(nameof(MainAccount)), InverseProperty("Capital")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainCapitalWhich")]
        public CapitalX CapitalX { get; set; }
        #endregion
    }
}