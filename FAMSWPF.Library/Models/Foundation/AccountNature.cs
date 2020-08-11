using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Foundation
{
    [Table("AccountNature", Schema = "Foundation")]
    public class AccountNature
    {
        [Key, MaxLength(10)]
        public string NatureId { get; set; }
        [MaxLength(150), Required]
        public string NatureName { get; set; }
        [Required]
        public bool DebitNature { get; set; }

        #region HashSets & Collections
        [InverseProperty(nameof(MainAccount.AccNatWhich))]
        public ICollection<MainAccount> MainAccounts { get; set; }
        public AccountNature()
        {
            MainAccounts = new HashSet<MainAccount>();
        } 
        #endregion
    }
}
