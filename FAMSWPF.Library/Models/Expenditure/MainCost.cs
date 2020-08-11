using FAMSWPF.Library.Models.Expenditure.Contra;
using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Expenditure
{
    [Table("MainCost", Schema = "Expenditure")]
    public class MainCost
    {
        [Key]
        public int CostId { get; set; }
        [StringLength(50)]
        public string CostScheme { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("MainCost")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainCostWhich")]
        public MainCostX MainCostX { get; set; }
        #endregion
    }
}