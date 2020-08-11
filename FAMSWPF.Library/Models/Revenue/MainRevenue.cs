using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Revenue.Contra;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Revenue
{
    [Table("MainRevenue", Schema = "Revenue")]
    public class MainRevenue
    {
        [Key]
        public int RevId { get; set; }
        [StringLength(50)]
        public string RevenueScheme { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("MainRevenue")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainRevWhich")]
        public MainRevenueX MainRevenueX { get; set; }
        #endregion
    }
}