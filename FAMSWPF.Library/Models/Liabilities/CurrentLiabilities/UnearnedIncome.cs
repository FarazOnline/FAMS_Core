using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Liabilities.CurrentLiabilities
{
    [Table("UnearnedIncomes", Schema = "Liabilities")]
    public class UnearnedIncome
    {
        [Key]
        public int UIncId { get; set; }
        [Required, StringLength(50)]
        public string Income { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("UnearnedIncome")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}