using FAMSWPF.Library.Models.Foundation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets
{
    [Table("BankAccounts", Schema = "Assets")]
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        [Required, MaxLength(50)]
        public string AccountNo { get; set; }
        [Required, MaxLength(50)]
        public string BankName { get; set; }
        [Required, MaxLength(50)]
        public string BankBranch { get; set; }
        [Required, MaxLength(30)]
        public string AccountType { get; set; }
        public DateTime? OpeningDate { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("BankAccount")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}
