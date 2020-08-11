using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.NonCurrentAssets
{
    [Table("FurnitureFixtures", Schema = "Assets")]
    public class Furniture
    {
        [Key]
        public int AssetId { get; set; }
        [Required, MaxLength(30)]
        public string Type { get; set; }
        [Required, MaxLength(30)]
        public string Size { get; set; }
        [MaxLength(30)]
        public string Make { get; set; }
        public int MainNCA { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainNCA)), InverseProperty(nameof(NonCurrentAsset.Furniture))]
        public NonCurrentAsset MainNCAWhich { get; set; }
        #endregion
    }
}