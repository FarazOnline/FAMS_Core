using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets
{
    [Table("CashAccounts", Schema = "Assets")]
    public class Cash
    {
        [Key]
        public int CashId { get; set; }
        [Required, MaxLength(50)]
        public string Location { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("CashAccount")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}
