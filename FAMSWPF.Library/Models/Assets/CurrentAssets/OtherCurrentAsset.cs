using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets
{
    [Table("OtherCurrent", Schema = "Assets")]
    public class OtherCurrentAsset
    {
        [Key]
        public int AssetId { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("OtherCurrent")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}
