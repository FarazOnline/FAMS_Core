using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Expenditure.Contra
{
    [Table("MainCostX", Schema = "ExpenditureContra")]
    public class MainCostX
    {
        [Key]
        public int CostXId { get; set; }
        [Required]
        public int MainAccount { get; set; }
        [Required]
        public int MainCost { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("MainCostX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainCost)), InverseProperty("MainCostX")]
        public MainCost MainCostWhich { get; set; }
        #endregion
    }
}