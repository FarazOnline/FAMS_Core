using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Expenditure
{
    [Table("DirectLabour", Schema = "Expenditure")]
    public class DirectLabour
    {
        [Key]
        public int DLId { get; set; }
        [StringLength(100)]
        public string Labourer { get; set; }
        [StringLength(100)]
        public string LbrrAddress { get; set; }
        [StringLength(30)]
        public string LbrrContact { get; set; }
        [Required]
        public int MainAccount { get; set; }

        #region Navigatio4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("DirectLabour")]
        public MainAccount MainAccWhich { get; set; }
        #endregion
    }
}