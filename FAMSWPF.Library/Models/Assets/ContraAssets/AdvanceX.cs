using FAMSWPF.Library.Models.Assets.CurrentAssets;
using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.ContraAssets
{
    [Table("AdvancesX", Schema = "AssetsContra")]
    public class AdvanceX
    {
        [Key]
        public int AdvXId { get; set; }
        [Required]
        public int? MainAdvance { get; set; }
        [Required]
        public int? MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("AdvanceX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainAdvance)), InverseProperty(nameof(Advance.AdvanceX))]
        public Advance MainAdvWhich { get; set; }
        #endregion
    }
}