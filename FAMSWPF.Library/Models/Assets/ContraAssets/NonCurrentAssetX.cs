using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.ContraAssets
{
    [Table("NonCurrrentX", Schema = "AssetsContra")]
    public class NonCurrentAssetX
    {
        [Key]
        public int NCAXId { get; set; }
        [Required]
        public int MainAsset { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("NCAXMainAccWhich")]
        //With Main A/c for Provision's A/c Itself
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainAsset)), InverseProperty("NCAXMainAssetWhich")]
        //With for relevant Current Assets Provided
        public MainAccount MainAssetWhich { get; set; }
        #endregion
    }
}