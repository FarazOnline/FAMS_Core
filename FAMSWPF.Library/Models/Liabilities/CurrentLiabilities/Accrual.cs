using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Liabilities.CurrentLiabilities
{
    [Table("Accruals", Schema = "Liabilities")]
    public class Accrual
    {
        [Key]
        public int AccrualId { get; set; }
        [Required, StringLength(50)]
        public string Payee { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("Accrual")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}