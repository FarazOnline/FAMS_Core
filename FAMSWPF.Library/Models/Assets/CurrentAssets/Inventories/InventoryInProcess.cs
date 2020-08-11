using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories
{
    [Table("WorkInProcess", Schema = "Assets")]
    public class InventoryInProcess
    {
        [Key]
        public int WIPId { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("WorkInProcess")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}
