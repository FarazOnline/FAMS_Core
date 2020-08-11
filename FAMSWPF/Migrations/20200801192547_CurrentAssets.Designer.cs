﻿// <auto-generated />
using System;
using FAMSWPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAMSWPF.Migrations
{
    [DbContext(typeof(FAMSContext))]
    [Migration("20200801192547_CurrentAssets")]
    partial class CurrentAssets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Advance", b =>
                {
                    b.Property<int>("AdvanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaidUpto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("AdvanceId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("Advances","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Debtor", b =>
                {
                    b.Property<int>("DebtorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("CNIC")
                        .HasColumnName("CNIC")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CellNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("Customer")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CustomerSince")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("KeyPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.Property<string>("NTN")
                        .HasColumnName("NTN")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PlotAddress")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("RegionAddress")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ResidNumber")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("DebtorId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("Debtors","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryFinished", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("MinLevelUnits")
                        .HasColumnType("decimal(26, 10)");

                    b.Property<string>("QuantityUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("UnitSize")
                        .HasColumnType("decimal(26, 10)");

                    b.HasKey("ItemId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("FinishedGoods","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryInProcess", b =>
                {
                    b.Property<int>("WIPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.HasKey("WIPId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("WorkInProcess","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryRaw", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("MinLevelUnits")
                        .HasColumnType("decimal(26, 10)");

                    b.Property<string>("QuantityUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("UnitSize")
                        .HasColumnType("decimal(26, 10)");

                    b.HasKey("ItemId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("RawMaterials","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OpeningDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BankId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("BankAccounts","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.Cash", b =>
                {
                    b.Property<int>("CashId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.HasKey("CashId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("CashAccounts","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.LiquidSecurity", b =>
                {
                    b.Property<int>("SecurityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IssuingAuthority")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.Property<string>("Serials")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("Since")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("SecurityId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("LiquidSecurity","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.OtherCurrentAsset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MainAccount")
                        .HasColumnType("int");

                    b.HasKey("AssetId");

                    b.HasIndex("MainAccount")
                        .IsUnique();

                    b.ToTable("OtherCurrent","Assets");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Foundation.AccountNature", b =>
                {
                    b.Property<string>("NatureId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("DebitNature")
                        .HasColumnType("bit");

                    b.Property<string>("NatureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("NatureId");

                    b.HasIndex("NatureName")
                        .HasName("IX_AccountsNatures");

                    b.ToTable("AccountNature","Foundation");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Foundation.Currency", b =>
                {
                    b.Property<string>("CurrencyId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<decimal?>("ConvertRatio")
                        .HasColumnType("numeric(18, 9)");

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("SinceWhen")
                        .HasColumnType("datetime2");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currency","Foundation");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Foundation.MainAccount", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("CurrencyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("NatureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("AccountId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("NatureId");

                    b.ToTable("MainAccount","Foundation");
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Advance", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("Advance")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.Advance", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Debtor", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("Debtor")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.Debtor", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryFinished", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("FinishedGood")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryFinished", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryInProcess", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("WorkInProcess")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryInProcess", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryRaw", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("RawMaterial")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.Inventories.InventoryRaw", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.Bank", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("BankAccount")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.Bank", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.Cash", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("CashAccount")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.Cash", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.LiquidSecurity", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("LiquidSecurity")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.LiquidAssets.LiquidSecurity", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Assets.CurrentAssets.OtherCurrentAsset", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.MainAccount", "MainAccNavigation")
                        .WithOne("OtherCurrent")
                        .HasForeignKey("FAMSWPF.Library.Models.Assets.CurrentAssets.OtherCurrentAsset", "MainAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FAMSWPF.Library.Models.Foundation.MainAccount", b =>
                {
                    b.HasOne("FAMSWPF.Library.Models.Foundation.Currency", "CurrencyNavigation")
                        .WithMany("MainAccounts")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAMSWPF.Library.Models.Foundation.AccountNature", "AccNatNavigation")
                        .WithMany("MainAccounts")
                        .HasForeignKey("NatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}