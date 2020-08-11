using FAMSWPF.Library.Models.Assets.ContraAssets;
using FAMSWPF.Library.Models.Foundation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets
{
    [Table("Advances", Schema = "Assets")]
    public class Advance
    {
        [Key]
        public int AdvanceId { get; set; }
        [Required, MaxLength(100)]
        public string Purpose { get; set; }
        public DateTime? PaidUpto { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("Advance")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainAdvWhich")]
        public AdvanceX AdvanceX { get; set; }
        #endregion
    }
}
