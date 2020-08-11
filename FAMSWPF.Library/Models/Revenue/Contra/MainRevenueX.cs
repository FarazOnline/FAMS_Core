using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Revenue.Contra
{
    [Table("MainRevenueX", Schema = "RevenueContra")]
    public class MainRevenueX
    {
        [Key]
        public int RevXId { get; set; }
        [Required]
        public int MainAccount { get; set; }
        [Required]
        public int MainRevenue { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("MainRevenueX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainRevenue)), InverseProperty(nameof(Revenue.MainRevenue.MainRevenueX))]
        public MainRevenue MainRevWhich { get; set; }
        #endregion
    }
}