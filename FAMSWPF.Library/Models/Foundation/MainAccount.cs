using FAMSWPF.Library.Models.Assets.ContraAssets;
using FAMSWPF.Library.Models.Assets.CurrentAssets;
using FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories;
using FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets;
using FAMSWPF.Library.Models.Assets.NonCurrentAssets;
using FAMSWPF.Library.Models.Equity;
using FAMSWPF.Library.Models.Equity.Contra;
using FAMSWPF.Library.Models.Expenditure;
using FAMSWPF.Library.Models.Expenditure.Contra;
using FAMSWPF.Library.Models.Journals;
using FAMSWPF.Library.Models.Liabilities.CurrentLiabilities;
using FAMSWPF.Library.Models.Liabilities.NonCurrentLiabilities;
using FAMSWPF.Library.Models.Revenue;
using FAMSWPF.Library.Models.Revenue.Contra;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Library.Models.Foundation
{
    [Table("MainAccount", Schema = "Foundation")]
    public class MainAccount
    {
        [Key]
        public int AccountId { get; set; }
        [MaxLength(200), Required]
        public string AccountTitle { get; set; }
        [MaxLength(10), Required]
        public string NatureId { get; set; }
        [MaxLength(10), Required]
        public string CurrencyId { get; set; }
        [MaxLength(200)]
        public string Details { get; set; }

        #region Navigation4FKs
        [ForeignKey(nameof(NatureId))]
        public AccountNature AccNatWhich { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        public Currency CurrencyWhich { get; set; }
        #endregion

        #region Navigation2FKs
        [InverseProperty("MainAccWhich")]
        public Cash CashAccount { get; set; }

        [InverseProperty("MainAccWhich")]
        public Bank BankAccount { get; set; }

        [InverseProperty("MainAccWhich")]
        public LiquidSecurity LiquidSecurity { get; set; }

        [InverseProperty("MainAccWhich")]
        public Advance Advance { get; set; }

        [InverseProperty("MainAccWhich")]
        public Debtor Debtor { get; set; }

        [InverseProperty("MainAccWhich")]
        public InventoryRaw RawMaterial { get; set; }

        [InverseProperty("MainAccWhich")]
        public InventoryInProcess WorkInProcess { get; set; }

        [InverseProperty("MainAccWhich")]
        public InventoryFinished FinishedGood { get; set; }

        [InverseProperty("MainAccWhich")]
        public OtherCurrentAsset OtherCurrent { get; set; }

        [InverseProperty("MainAccWhich")]
        public NonCurrentAsset NonCurrentAsset { get; set; }

        [InverseProperty("MainAccWhich")]
        public LiquidSecurityX LiquidSecurityX { get; set; }

        [InverseProperty("MainAccWhich")]
        public AdvanceX AdvanceX { get; set; }

        [InverseProperty("MainAccWhich")]
        public DebtorX DebtorX { get; set; }

        //With Main A/c for Provision's A/c Itself
        [InverseProperty("MainAccWhich")]
        public OtherCurrentAssetX OCAXMainAccWhich { get; set; }

        //With for relevant Current Assets Provided
        [InverseProperty("MainAssetWhich")]
        public OtherCurrentAssetX OCAXMainAssetWhich { get; set; }

        //With Main A/c for Provision's A/c Itself
        [InverseProperty("MainAccWhich")]
        public NonCurrentAssetX NCAXMainAccWhich { get; set; }

        //With for relevant Non-Current Assets Provided
        [InverseProperty("MainAssetWhich")]
        public NonCurrentAssetX NCAXMainAssetWhich { get; set; }

        [InverseProperty("MainAccWhich")]
        public Accrual Accrual { get; set; }

        [InverseProperty("MainAccWhich")]
        public Creditor Creditor { get; set; }

        [InverseProperty("MainAccWhich")]
        public UnearnedIncome UnearnedIncome { get; set; }

        [InverseProperty("MainAccWhich")]
        public Loan Loan { get; set; }

        [InverseProperty("MainAccWhich")]
        public NonCurrentLiability NonCurrentLiability { get; set; }

        [InverseProperty("MainAccWhich")]
        public Capital Capital { get; set; }

        [InverseProperty("MainAccWhich")]
        public CapitalX CapitalX { get; set; }

        [InverseProperty("MainAccWhich")]
        public MainRevenue MainRevenue { get; set; }

        [InverseProperty("MainAccWhich")]
        public MainRevenueX MainRevenueX { get; set; }

        [InverseProperty("MainAccWhich")]
        public OtherRevenue OtherRevenue { get; set; }

        [InverseProperty("MainAccWhich")]
        public OtherRevenueX OtherRevenueX { get; set; }

        [InverseProperty("MainAccWhich")]
        public virtual MainCost MainCost { get; set; }

        [InverseProperty("MainAccWhich")]
        public virtual DirectLabour DirectLabour { get; set; }

        [InverseProperty("MainAccWhich")]
        public virtual OtherExpense OtherExpense { get; set; }

        [InverseProperty("MainAccWhich")]
        public virtual MainCostX MainCostX { get; set; }

        [InverseProperty("MainAccWhich")]
        public virtual OtherExpenseX OtherExpenseX { get; set; }
        #endregion

        #region HashSets & Collections
        [InverseProperty(nameof(GJItem.MainAccWhich))]
        public virtual ICollection<GJItem> GJItems { get; set; }
        public MainAccount()
        {
            GJItems = new HashSet<GJItem>();
        }
        #endregion
    }
}