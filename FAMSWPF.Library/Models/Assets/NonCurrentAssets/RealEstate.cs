using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.NonCurrentAssets
{
    [Table("RealEstates", Schema = "Assets")]
    public class RealEstate
    {
        [Key]
        public int EstateId { get; set; }
        [Required, MaxLength(20)]
        public string PlotAddress { get; set; }
        [Required, MaxLength(50)]
        public string StreetAddress { get; set; }
        [Required, MaxLength(100)]
        public string RegionAddress { get; set; }
        [Required, MaxLength(50)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string Country { get; set; }
        [Required, MaxLength(10)]
        public string PostCode { get; set; }
        [Required, MaxLength(20)]
        public string AreaSize { get; set; }
        public int MainNCA { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainNCA)), InverseProperty(nameof(NonCurrentAsset.RealEstate))]
        public NonCurrentAsset MainNCAWhich { get; set; }
        #endregion
    }
}