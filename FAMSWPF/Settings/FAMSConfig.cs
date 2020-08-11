using FAMSWPF.Library.Models.Assets.ContraAssets;
using FAMSWPF.Library.Models.Equity;
using FAMSWPF.Library.Models.Equity.Contra;
using FAMSWPF.Library.Models.Expenditure.Contra;
using FAMSWPF.Library.Models.Foundation;
using FAMSWPF.Library.Models.Revenue.Contra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FAMSWPF.Settings
{
    public class AccNatConfig : IEntityTypeConfiguration<AccountNature>
    {
        public void Configure(EntityTypeBuilder<AccountNature> AccNat)
        {
            AccNat.HasIndex(e => e.NatureName).HasName("IX_AccountsNatures").IsUnique();
        }
    }

    public class AdvXConfig : IEntityTypeConfiguration<AdvanceX>
    {
        public void Configure(EntityTypeBuilder<AdvanceX> AdvX)
        {
            AdvX.HasKey(e => e.AdvXId).HasName("PK_AdvancesX");

            AdvX.HasIndex(e => e.MainAccount).HasName("IX_AdvanceX_MainAcc").IsUnique();

            AdvX.HasIndex(e => e.MainAdvance).HasName("IX_AdvanceX_MainAdv").IsUnique();

            AdvX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.AdvanceX)
                .HasForeignKey<AdvanceX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_AdvancesX_MainAcc_MainAcc");

            AdvX.HasOne(d => d.MainAdvWhich)
                .WithOne(p => p.AdvanceX)
                .HasForeignKey<AdvanceX>(d => d.MainAdvance)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_AdvancesX_Advances_MainAdv");
        }
    }

    public class LiqSecXConfig : IEntityTypeConfiguration<LiquidSecurityX>
    {
        public void Configure(EntityTypeBuilder<LiquidSecurityX> SecX)
        {
            SecX.HasIndex(e => e.MainAccount).HasName("IX_LiqSecX_MainAcc").IsUnique();

            SecX.HasIndex(e => e.MainSecurity).HasName("IX_LiqSecX_MainSec").IsUnique();

            SecX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.LiquidSecurityX)
                .HasForeignKey<LiquidSecurityX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            SecX.HasOne(d => d.MainLiqSecWhich)
                .WithOne(p => p.LiquidSecurityX)
                .HasForeignKey<LiquidSecurityX>(d => d.MainSecurity)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class DebtXConfig : IEntityTypeConfiguration<DebtorX>
    {
        public void Configure(EntityTypeBuilder<DebtorX> DebtX)
        {
            DebtX.HasIndex(e => e.MainAccount).HasName("IX_DebtorsX_MainAcc").IsUnique();

            DebtX.HasIndex(e => e.MainDebtor).HasName("IX_DebtorsX_MainDebt").IsUnique();

            DebtX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.DebtorX)
                .HasForeignKey<DebtorX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            DebtX.HasOne(d => d.MainDebtorWhich)
                .WithOne(p => p.DebtorX)
                .HasForeignKey<DebtorX>(d => d.MainDebtor)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class OCAXConfig : IEntityTypeConfiguration<OtherCurrentAssetX>
    {
        public void Configure(EntityTypeBuilder<OtherCurrentAssetX> OCAX)
        {
            OCAX.HasIndex(e => e.MainAccount).HasName("IX_OCAX_MainAcc").IsUnique();

            OCAX.HasIndex(e => e.MainAsset).HasName("IX_OCAX_MainAsset").IsUnique();

            OCAX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.OCAXMainAccWhich)
                .HasForeignKey<OtherCurrentAssetX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            OCAX.HasOne(d => d.MainAssetWhich)
                .WithOne(p => p.OCAXMainAssetWhich)
                .HasForeignKey<OtherCurrentAssetX>(d => d.MainAsset)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class NCAXConfig : IEntityTypeConfiguration<NonCurrentAssetX>
    {
        public void Configure(EntityTypeBuilder<NonCurrentAssetX> NCAX)
        {
            NCAX.HasIndex(e => e.MainAccount).HasName("IX_NCAX_MainAcc").IsUnique();

            NCAX.HasIndex(e => e.MainAsset).HasName("IX_NCAX_MainAsset").IsUnique();

            NCAX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.NCAXMainAccWhich)
                .HasForeignKey<NonCurrentAssetX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            NCAX.HasOne(d => d.MainAssetWhich)
                .WithOne(p => p.NCAXMainAssetWhich)
                .HasForeignKey<NonCurrentAssetX>(d => d.MainAsset)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class CapXConfig : IEntityTypeConfiguration<CapitalX>
    {
        public void Configure(EntityTypeBuilder<CapitalX> CapX)
        {
            CapX.HasIndex(e => e.MainAccount).HasName("IX_CapitalX_MainAcc").IsUnique();

            CapX.HasIndex(e => e.MainCapital).HasName("IX_CapitalX_Capital").IsUnique();

            CapX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.CapitalX)
                .HasForeignKey<CapitalX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            CapX.HasOne(d => d.MainCapitalWhich)
                .WithOne(p => p.CapitalX)
                .HasForeignKey<CapitalX>(d => d.MainCapital)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class MainRevXConfig : IEntityTypeConfiguration<MainRevenueX>
    {
        public void Configure(EntityTypeBuilder<MainRevenueX> MainRevX)
        {
            MainRevX.HasIndex(e => e.MainAccount).HasName("IX_MainRevX_MainAcc").IsUnique();

            MainRevX.HasIndex(e => e.MainRevenue).HasName("IX_MainRevX_Revenue").IsUnique();

            MainRevX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.MainRevenueX)
                .HasForeignKey<MainRevenueX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            MainRevX.HasOne(d => d.MainRevWhich)
                .WithOne(p => p.MainRevenueX)
                .HasForeignKey<MainRevenueX>(d => d.MainRevenue)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class OtherRevXConfig : IEntityTypeConfiguration<OtherRevenueX>
    {
        public void Configure(EntityTypeBuilder<OtherRevenueX> OtherRevX)
        {
            OtherRevX.HasIndex(e => e.MainAccount).HasName("IX_OtherRevX_MainAcc").IsUnique();

            OtherRevX.HasIndex(e => e.MainRevenue).HasName("IX_OtherRevX_Revenue").IsUnique();

            OtherRevX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.OtherRevenueX)
                .HasForeignKey<OtherRevenueX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            OtherRevX.HasOne(d => d.MainRevWhich)
                .WithOne(p => p.OtherRevenueX)
                .HasForeignKey<OtherRevenueX>(d => d.MainRevenue)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class MainCostXConfig : IEntityTypeConfiguration<MainCostX>
    {
        public void Configure(EntityTypeBuilder<MainCostX> MainCostX)
        {
            MainCostX.HasIndex(e => e.MainAccount).HasName("IX_MainCostX_MainAcc").IsUnique();

            MainCostX.HasIndex(e => e.MainCost).HasName("IX_MainCostX_Cost").IsUnique();

            MainCostX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.MainCostX)
                .HasForeignKey<MainCostX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            MainCostX.HasOne(d => d.MainCostWhich)
                .WithOne(p => p.MainCostX)
                .HasForeignKey<MainCostX>(d => d.MainCost)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class OtherExpXConfig : IEntityTypeConfiguration<OtherExpenseX>
    {
        public void Configure(EntityTypeBuilder<OtherExpenseX> OtherExpX)
        {
            OtherExpX.HasIndex(e => e.MainAccount).HasName("IX_OtherExpX_MainAcc").IsUnique();

            OtherExpX.HasIndex(e => e.MainExpense).HasName("IX_OtherExpX_Expense").IsUnique();

            OtherExpX.HasOne(d => d.MainAccWhich)
                .WithOne(p => p.OtherExpenseX)
                .HasForeignKey<OtherExpenseX>(d => d.MainAccount)
                .OnDelete(DeleteBehavior.NoAction);

            OtherExpX.HasOne(d => d.MainExpWhich)
                .WithOne(p => p.OtherExpenseX)
                .HasForeignKey<OtherExpenseX>(d => d.MainExpense)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
