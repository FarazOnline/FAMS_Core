using FAMSWPF.Library.Models.Foundation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Journals
{
    [Table("GeneralJournalItems", Schema = "Transactions")]
    public class GJItem
    {
        [Key]
        public int GTAccId { get; set; }
        public int MainAccount { get; set; }
        [StringLength(10)]
        public string DrCr { get; set; }
        public double Amount { get; set; }
        public int MainTranx { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(MainAccount)), InverseProperty("GJItems")]
        public MainAccount MainAccWhich { get; set; }
        [ForeignKey(nameof(MainTranx)), InverseProperty(nameof(GeneralJournal.GJItems))]
        public GeneralJournal MainTranxWhich { get; set; }
        #endregion
    }
}