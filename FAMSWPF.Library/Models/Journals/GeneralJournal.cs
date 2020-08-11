using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Journals
{
    [Table("GeneralJournal", Schema = "Transactions")]
    public class GeneralJournal
    {
        [Key]
        public int GenTranxId { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime TranxDate { get; set; }
        [StringLength(100)]
        public string Details { get; set; }

        #region HashSets & Collections
        [InverseProperty(nameof(GJItem.MainTranxWhich))]
        public virtual ICollection<GJItem> GJItems { get; set; }
        public GeneralJournal()
        {
            GJItems = new HashSet<GJItem>();
        }
        #endregion
    }
}