using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.NonCurrentAssets
{
    [Table("MachinesEquips", Schema = "Assets")]
    public class Machinery
    {
        [Key]
        public int MachineId { get; set; }
        [Required, MaxLength(20)]
        public string MachineTyp { get; set; }
        [Required, MaxLength(50)]
        public string Manufacturer { get; set; }
        [Required, MaxLength(50)]
        public string Make { get; set; }
        [Required, MaxLength(50)]
        public string Model { get; set; }
        [MaxLength(50)]
        public string Capacity { get; set; }
        public int MainNCA { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainNCA)), InverseProperty(nameof(NonCurrentAsset.Machinery))]
        public NonCurrentAsset MainNCAWhich { get; set; }
        #endregion
    }
}