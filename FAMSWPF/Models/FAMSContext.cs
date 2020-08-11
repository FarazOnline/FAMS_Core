using FAMSWPF.Library.Models.Assets.ContraAssets;
using FAMSWPF.Library.Models.Assets.CurrentAssets;
using FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories;
using FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets;
using FAMSWPF.Library.Models.Assets.NonCurrentAssets;
using FAMSWPF.Library.Models.Equity;
using FAMSWPF.Library.Models.Equity.Contra;
using FAMSWPF.Library.Models.Expenditure;
using FAMSWPF.Library.Models.Expenditure.Contra;
using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Journals;
using FAMSWPF.Library.Models.Liabilities.CurrentLiabilities;
using FAMSWPF.Library.Models.Liabilities.NonCurrentLiabilities;
using FAMSWPF.Library.Models.Revenue;
using FAMSWPF.Library.Models.Revenue.Contra;
using FAMSWPF.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace FAMSWPF.Models
{
    public class FAMSContext : DbContext
    {
        #region Foundation Tables
        public DbSet<AccountNature> AccountsNatures { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<MainAccount> MainAccounts { get; set; }
        #endregion

        #region Assets
        #region Current Assets
        public DbSet<Cash> CashAccounts { get; set; }
        public DbSet<Bank> BankAccounts { get; set; }
        public DbSet<LiquidSecurity> LiquidSecurities { get; set; }
        public DbSet<Advance> Advances { get; set; }
        public DbSet<Debtor> Debtors { get; set; }
        public DbSet<InventoryRaw> InvRaw { get; set; }
        public DbSet<InventoryInProcess> InvInProcess { get; set; }
        public DbSet<InventoryFinished> InvFinished { get; set; }
        public DbSet<OtherCurrentAsset> OthCurrAssets { get; set; }
        #endregion
        #region Non-Current Assets
        public DbSet<NonCurrentAsset> NonCurrentAssets { get; set; }
        public DbSet<RealEstate> RealEstate { get; set; }
        public DbSet<Machinery> Machine { get; set; }
        public DbSet<Furniture> Furniture { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<OtherNonCurrent> OthNonCurrAssets { get; set; }
        #endregion
        #region ContraAssets
        public DbSet<LiquidSecurityX> LiqSecX { get; set; }
        public DbSet<AdvanceX> AdvanceX { get; set; }
        public DbSet<DebtorX> DebtorX { get; set; }
        public DbSet<OtherCurrentAssetX> OthCurrAssetX { get; set; }
        public DbSet<NonCurrentAssetX> NonCurrAssetX { get; set; }
        #endregion
        #endregion

        #region Liabilities
        #region Current Liabilities
        public DbSet<Accrual> Accruals { get; set; }
        public DbSet<Creditor> Creditors { get; set; }
        public DbSet<UnearnedIncome> UnearnedIncomes { get; set; }
        #endregion
        #region Non-Current Liabilities
        public DbSet<Loan> Loans { get; set; }
        public DbSet<NonCurrentLiability> NonCurrentLiabilities { get; set; }
        #endregion
        #region Contra Liabilities
        #endregion
        #endregion
        
        #region Capital
        public DbSet<Capital> Capital { get; set; }
        #region Contra Capital
        public DbSet<CapitalX> CapitalX { get; set; }
        #endregion
        #endregion
        
        #region Revenue
        public DbSet<MainRevenue> MainRevenue { get; set; }
        public DbSet<OtherRevenue> OtherRevenue { get; set; }
        #region Contra Revenue
        public DbSet<MainRevenueX> MainRevenueX { get; set; }
        public DbSet<OtherRevenueX> OtherRevenueX { get; set; }
        #endregion
        #endregion
        
        #region Expenditure/Cost
        public DbSet<MainCost> MainCost { get; set; }
        public DbSet<DirectLabour> DirectLabour { get; set; }
        public DbSet<OtherExpense> OtherExpense { get; set; }
        #region Contra Cost
        public DbSet<MainCostX> MainCostX { get; set; }
        public DbSet<OtherExpenseX> OtherExpenseX { get; set; }
        #endregion
        #endregion
        
        #region Journals
        public DbSet<GeneralJournal> GeneralJournal { get; set; }
        
        #endregion

        /*
        public DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<GjItem> GjItem { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserAndRole> UserAndRole { get; set; }
        public DbSet<UserClaim> UserClaim { get; set; }
        public DbSet<UserLogIn> UserLogIn { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserRoleClaim> UserRoleClaim { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
         */

        protected override void OnConfiguring(DbContextOptionsBuilder DBCOB)
        {
            if (!DBCOB.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory + "\\Settings")
                .AddJsonFile("FAMS.json")
                .Build();

                DBCOB.UseSqlServer(configuration.GetConnectionString("FAMSDBCNXN"));
            }
        }

        protected override void OnModelCreating(ModelBuilder MB)
        {
            //2BC https://stackoverflow.com/questions/17127351/introducing-foreign-key-constraint-may-cause-cycles-or-multiple-cascade-paths/27019687
            MB.ApplyConfiguration(new AccNatConfig());
            MB.ApplyConfiguration(new AdvXConfig());
            MB.ApplyConfiguration(new LiqSecXConfig());
            MB.ApplyConfiguration(new DebtXConfig());
            MB.ApplyConfiguration(new OCAXConfig());
            MB.ApplyConfiguration(new NCAXConfig());
            MB.ApplyConfiguration(new CapXConfig());
            MB.ApplyConfiguration(new MainRevXConfig());
            MB.ApplyConfiguration(new OtherRevXConfig());
            MB.ApplyConfiguration(new MainCostXConfig());
            MB.ApplyConfiguration(new OtherExpXConfig());
        }
    }
}