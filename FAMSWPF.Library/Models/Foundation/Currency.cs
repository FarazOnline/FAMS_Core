using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Foundation
{
    [Table("Currency", Schema = "Foundation")]
    public class Currency
    {
        [Key, MaxLength(10)]
        public string CurrencyId { get; set; }
        [Required, MaxLength(50)]
        public string CurrencyName { get; set; }
        [Column(TypeName = "numeric(18, 9)")]
        public decimal? ConvertRatio { get; set; }
        public DateTime? SinceWhen { get; set; }

        #region HashSets & Collections
        [InverseProperty(nameof(MainAccount.CurrencyWhich))]
        public ICollection<MainAccount> MainAccounts { get; set; }
        public Currency()
        {
            MainAccounts = new HashSet<MainAccount>();
        } 
        #endregion
    }
}