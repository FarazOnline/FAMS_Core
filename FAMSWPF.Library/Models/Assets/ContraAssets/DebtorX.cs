using FAMSWPF.Library.Models.Assets.CurrentAssets;
using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.ContraAssets
{
    [Table("DebtorsX", Schema = "AssetsContra")]
    public class DebtorX
    {
        [Key]
        public int DrXId { get; set; }
        [Required]
        public int MainAccount { get; set; }
        [Required]
        public int MainDebtor { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("DebtorX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainDebtor)), InverseProperty(nameof(Debtor.DebtorX))]
        public Debtor MainDebtorWhich { get; set; }
        #endregion
    }
}