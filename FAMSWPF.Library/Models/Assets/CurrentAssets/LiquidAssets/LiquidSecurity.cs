using FAMSWPF.Library.Models.Assets.ContraAssets;
using FAMSWPF.Library.Models.Foundation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets
{
    [Table("LiquidSecurities", Schema = "Assets")]
    public class LiquidSecurity
    {
        [Key]
        public int SecurityId { get; set; }
        [Required, MaxLength(100)]
        public string Type { get; set; }
        [Required, MaxLength(30)]
        public string Serials { get; set; }
        [Required, MaxLength(100)]
        public string IssuingAuthority { get; set; }
        public DateTime? Since { get; set; }
        public int MainAccount { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("LiquidSecurity")]
        public MainAccount MainAccWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainLiqSecWhich")]
        public LiquidSecurityX LiquidSecurityX { get; set; }
        #endregion
    }
}
