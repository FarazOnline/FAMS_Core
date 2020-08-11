using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.NonCurrentAssets
{
    [Table("OtherNonCurrent", Schema = "Assets")]
    public class OtherNonCurrent
    {
        [Key]
        public int AssetId { get; set; }
        [Required, MaxLength(50)]
        public string AssetType { get; set; }
        [Required, MaxLength(100)]
        public string Manufacturer { get; set; }
        [MaxLength(100)]
        public string Details { get; set; }
        [Column("MainNCA")]
        public int MainNCA { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainNCA)), InverseProperty(nameof(NonCurrentAsset.OtherNCA))]
        public NonCurrentAsset MainNCAWhich { get; set; }
        #endregion
    }
}