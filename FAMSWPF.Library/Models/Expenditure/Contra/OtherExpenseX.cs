using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Expenditure.Contra
{
    [Table("OtherExpenseX", Schema = "ExpenditureContra")]
    public class OtherExpenseX
    {
        [Key]
        public int ExpXId { get; set; }
        [Required]
        public int MainAccount { get; set; }
        [Required]
        public int MainExpense { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("OtherExpenseX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainExpense)), InverseProperty(nameof(OtherExpense.OtherExpenseX))]
        public OtherExpense MainExpWhich { get; set; }
        #endregion
    }
}