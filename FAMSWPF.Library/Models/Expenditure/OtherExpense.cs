using FAMSWPF.Library.Models.Expenditure.Contra;
using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Expenditure
{
    [Table("OtherExpense", Schema = "Expenditure")]
    public class OtherExpense
    {
        [Key]
        public int ExpId { get; set; }
        [StringLength(50)]
        public string ExpScheme { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("OtherExpense")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainExpWhich")]
        public OtherExpenseX OtherExpenseX { get; set; }
        #endregion
    }
}