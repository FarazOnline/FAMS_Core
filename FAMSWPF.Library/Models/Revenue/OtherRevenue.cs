using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Revenue.Contra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Revenue
{
    [Table("OtherRevenue", Schema = "Revenue")]
    public class OtherRevenue
    {
        [Key]
        public int RevId { get; set; }
        [StringLength(50)]
        public string RevScheme { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("OtherRevenue")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainRevWhich")]
        public OtherRevenueX OtherRevenueX { get; set; }
        #endregion
    }
}