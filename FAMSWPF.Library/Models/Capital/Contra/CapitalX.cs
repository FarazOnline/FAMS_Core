using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Equity.Contra
{
    [Table("CapitalX", Schema = "CapitalContra")]
    public class CapitalX
    {
        [Key]
        public int CapXId { get; set; }
        [Required]
        public int MainAccount { get; set; }
        [Required]
        public int MainCapital { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("CapitalX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainCapital)), InverseProperty(nameof(Capital.CapitalX))]
        public Capital MainCapitalWhich { get; set; }
        #endregion
    }
}