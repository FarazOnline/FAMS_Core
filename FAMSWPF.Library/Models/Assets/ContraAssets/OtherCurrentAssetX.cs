using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.ContraAssets
{
    [Table("OtherCurrentX", Schema = "AssetsContra")]
    public class OtherCurrentAssetX
    {
        [Key]
        public int OCAXId { get; set; }
        [Required]
        public int MainAsset { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("OCAXMainAccWhich")]
        //With Main A/c for Provision's A/c Itself
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainAsset)), InverseProperty("OCAXMainAssetWhich")]
        //With for relevant Current Assets Provided
        public MainAccount MainAssetWhich { get; set; }
        #endregion
    }
}