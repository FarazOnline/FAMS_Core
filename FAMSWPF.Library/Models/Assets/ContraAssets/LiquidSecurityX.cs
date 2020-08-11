using FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets;
using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.ContraAssets
{
    [Table("LiquidSecuritiesX", Schema = "AssetsContra")]
    public class LiquidSecurityX
    {
        [Key]
        public int SecXId { get; set; }
        [Required]
        public int MainSecurity { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("LiquidSecurityX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainSecurity)), InverseProperty(nameof(LiquidSecurity.LiquidSecurityX))]
        public LiquidSecurity MainLiqSecWhich { get; set; }
        #endregion
    }
}