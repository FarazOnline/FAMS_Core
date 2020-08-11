using FAMSWPF.Library.Models.Foundation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace FAMSWPF.Library.Models.Assets.NonCurrentAssets
{
    [Table("NonCurrentAssets", Schema = "Assets")]
    public class NonCurrentAsset
    {
        [Key]
        public int AssetId { get; set; }
        [Required, MaxLength(100)]
        public string AssetName { get; set; }
        public DateTime PurchDt { get; set; }
        [Required, Column(TypeName = "decimal(26, 10)")]
        public decimal OriginalCost { get; set; }
        [Required, Column(TypeName = "decimal(26, 10)")]
        public decimal LifeYears { get; set; }
        public bool New { get; set; }
        [MaxLength(50)]
        public string Vendor { get; set; }
        [Required, MaxLength(30)]
        public string DepreciationType { get; set; }
        [Column(TypeName = "decimal(26, 10)")]
        public decimal DepreciationRate { get; set; }
        [Required, Column(TypeName = "decimal(26, 10)")]
        public decimal ScrapValue { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("NonCurrentAsset")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainNCAWhich")]
        public RealEstate RealEstate { get; set; }
        [InverseProperty("MainNCAWhich")]
        public Machinery Machinery { get; set; }
        [InverseProperty("MainNCAWhich")]
        public Vehicle Vehicle { get; set; }
        [InverseProperty("MainNCAWhich")]
        public Furniture Furniture { get; set; }
        [InverseProperty("MainNCAWhich")]
        public OtherNonCurrent OtherNCA { get; set; }
        #endregion
    }
}