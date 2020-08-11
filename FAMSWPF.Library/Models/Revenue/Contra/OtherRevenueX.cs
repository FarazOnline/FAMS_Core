using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Revenue.Contra
{
    [Table("OtherRevenueX", Schema = "RevenueContra")]
    public class OtherRevenueX
    {
        [Key]
        public int RevXId { get; set; }
        [Required]
        public int MainAccount { get; set; }
        [Required]
        public int MainRevenue { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("OtherRevenueX")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainRevenue)), InverseProperty(nameof(OtherRevenue.OtherRevenueX))]
        public OtherRevenue MainRevWhich { get; set; }
        #endregion
    }
}