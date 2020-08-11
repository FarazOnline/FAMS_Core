using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories
{
    [Table("RawMaterials", Schema = "Assets")]
    public class InventoryRaw : IInventory
    {
        [Key]
        public int ItemId { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string ItemCode { get; set; }
        [MaxLength(100)]
        public string Manufacturer { get; set; }
        [Required, MaxLength(50)]
        public string QuantityUnit { get; set; }
        [Required, Column(TypeName = "decimal(26, 10)")]
        public decimal UnitSize { get; set; }
        [Column(TypeName = "decimal(26, 10)")]
        public decimal MinLevelUnits { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("RawMaterial")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}
