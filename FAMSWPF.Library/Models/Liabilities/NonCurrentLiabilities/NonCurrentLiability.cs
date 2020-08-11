using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Liabilities.NonCurrentLiabilities
{
    [Table("NonCurrent", Schema = "Liabilities")]
    public class NonCurrentLiability
    {
        [Key]
        public int LoanId { get; set; }
        [Column(TypeName = "decimal(26, 10)")]
        public decimal Term { get; set; }
        [Column(TypeName = "decimal(26, 10)")]
        public decimal AnnualRate { get; set; }
        [StringLength(50)]
        public string Lender { get; set; }
        [StringLength(50)]
        public string Purpose { get; set; }
        public int MainAccount { get; set; }

        [ForeignKey(nameof(MainAccount)), InverseProperty("NonCurrentLiability")]
        public MainAccount MainAccWhich { get; set; }
    }
}