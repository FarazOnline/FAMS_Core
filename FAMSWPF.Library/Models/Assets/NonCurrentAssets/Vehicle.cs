using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.NonCurrentAssets
{
    [Table("Vehicles", Schema = "Assets")]
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required, MaxLength(50)]
        public string VehicleType { get; set; }
        [Required, MaxLength(50)]
        public string Manufucturer { get; set; }
        [Required, MaxLength(50)]
        public string Make { get; set; }
        [Required, MaxLength(50)]
        public string Model { get; set; }
        [MaxLength(50)]
        public string Capacity { get; set; }
        [Required, MaxLength(50)]
        public string RegNo { get; set; }
        [Column("MainNCA")]
        public int MainNCA { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainNCA)), InverseProperty(nameof(NonCurrentAsset.Vehicle))]
        public NonCurrentAsset MainNCAWhich { get; set; }
        #endregion
    }
}