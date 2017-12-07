﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SalesApi.DataContext.Contexts;
using SalesApi.Shared.Enums;
using System;

namespace SalesApi.DataContext.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesApi.Models.Overall.SalesDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<string>("Date");

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction");

                    b.Property<int>("Order");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.HasKey("Id");

                    b.ToTable("SalesDays");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.ProductForRetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BoxPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<int>("EquivalentBox");

                    b.Property<decimal>("InternalPrice")
                        .HasColumnType("decimal(10, 6)");

                    b.Property<bool>("IsOrderByBox");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("MinOrderCount");

                    b.Property<int>("Order");

                    b.Property<int>("OrderDivisor");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 6)");

                    b.Property<int>("ProductId");

                    b.Property<int>("SalesType");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductForRetails");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<string>("Date");

                    b.Property<bool>("Deleted");

                    b.Property<bool>("Initialized");

                    b.Property<string>("LastAction");

                    b.Property<int>("Order");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.HasKey("Id");

                    b.ToTable("RetailDays");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.Retailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("No")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Order");

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("Pinyin")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("SalesType");

                    b.Property<int>("SubAreaId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("No")
                        .IsUnique();

                    b.HasIndex("SubAreaId");

                    b.ToTable("Retailers");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailProductSnapshot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barcode");

                    b.Property<decimal>("BoxPrice");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<bool>("Deleted");

                    b.Property<int>("EquivalentBox");

                    b.Property<decimal>("EquivalentTon");

                    b.Property<string>("FullName");

                    b.Property<decimal>("InternalPrice");

                    b.Property<bool>("IsOrderByBox");

                    b.Property<string>("LastAction");

                    b.Property<string>("LegacyProductId");

                    b.Property<int>("MinOrderCount");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<int>("OrderDivisor");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductForRetailId");

                    b.Property<int>("ProductUnit");

                    b.Property<int>("RetailDayId");

                    b.Property<int>("SalesType");

                    b.Property<int>("ShelfLife");

                    b.Property<string>("Specification");

                    b.Property<decimal>("TaxRate");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.HasKey("Id");

                    b.HasIndex("ProductForRetailId");

                    b.HasIndex("RetailDayId");

                    b.ToTable("RetailProductSnapshots");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("Order");

                    b.Property<int>("ProductForRetailId");

                    b.Property<int>("PurchaseBase");

                    b.Property<int>("RetailPromotionSeriesId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductForRetailId");

                    b.HasIndex("RetailPromotionSeriesId");

                    b.ToTable("RetailPromotionEvents");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionEventBonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BonusCount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Order");

                    b.Property<int>("ProductForRetailId");

                    b.Property<int>("RetailPromotionEventId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductForRetailId");

                    b.HasIndex("RetailPromotionEventId");

                    b.ToTable("RetailPromotionEventBonuses");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("DateRepeatType");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("Order");

                    b.Property<int>("ProductForRetailId");

                    b.Property<int>("PurchaseBase");

                    b.Property<int>("SalesType");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Step");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductForRetailId");

                    b.ToTable("RetailPromotionSeries");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionSeriesBonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BonusCount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Order");

                    b.Property<int>("ProductForRetailId");

                    b.Property<int>("RetailPromotionSeriesId");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductForRetailId");

                    b.HasIndex("RetailPromotionSeriesId");

                    b.ToTable("RetailPromotionSeriesBonuses");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.DeliveryVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<int>("DistributionGroupId");

                    b.Property<int?>("DistributionGroupId1");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LegacyAreaId")
                        .HasMaxLength(10);

                    b.Property<int>("Order");

                    b.Property<int>("SalesType");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("VehicleId");

                    b.Property<int?>("VehicleId1");

                    b.HasKey("Id");

                    b.HasIndex("DistributionGroupId");

                    b.HasIndex("DistributionGroupId1");

                    b.HasIndex("VehicleId");

                    b.HasIndex("VehicleId1");

                    b.HasIndex("SalesType", "VehicleId")
                        .IsUnique();

                    b.ToTable("DeliveryVehicles");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.DistributionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("No");

                    b.Property<int>("Order");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("No")
                        .IsUnique();

                    b.ToTable("DistributionGroups");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barcode")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<decimal>("EquivalentTon")
                        .HasColumnType("decimal(7, 6)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LegacyProductId")
                        .HasMaxLength(5);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Order");

                    b.Property<int>("ProductUnit");

                    b.Property<int>("ShelfLife");

                    b.Property<string>("Specification")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(7, 6)");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.SubArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<int>("DeliveryVehicleId");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LegacySubAreaId")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Order");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DeliveryVehicleId", "Name")
                        .IsUnique();

                    b.ToTable("SubAreas");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Order");

                    b.Property<string>("Owner")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("SalesApi.Models.Retail.ProductForRetail", b =>
                {
                    b.HasOne("SalesApi.Models.Settings.Product", "Product")
                        .WithOne("ProductForRetail")
                        .HasForeignKey("SalesApi.Models.Retail.ProductForRetail", "ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SalesApi.Models.Retail.Retailer", b =>
                {
                    b.HasOne("SalesApi.Models.Settings.SubArea", "SubArea")
                        .WithMany("Retailers")
                        .HasForeignKey("SubAreaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailProductSnapshot", b =>
                {
                    b.HasOne("SalesApi.Models.Retail.ProductForRetail", "ProductForRetail")
                        .WithMany("RetailProductSnapshots")
                        .HasForeignKey("ProductForRetailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesApi.Models.Retail.RetailDay", "RetailDay")
                        .WithMany("RetailProductSnapshots")
                        .HasForeignKey("RetailDayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionEvent", b =>
                {
                    b.HasOne("SalesApi.Models.Retail.ProductForRetail", "ProductForRetail")
                        .WithMany("RetailPromotionEvents")
                        .HasForeignKey("ProductForRetailId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SalesApi.Models.Retail.RetailPromotionSeries", "RetailPromotionSeries")
                        .WithMany("RetailPromotionEvents")
                        .HasForeignKey("RetailPromotionSeriesId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionEventBonus", b =>
                {
                    b.HasOne("SalesApi.Models.Retail.ProductForRetail", "ProductForRetail")
                        .WithMany("RetailPromotionEventBonuses")
                        .HasForeignKey("ProductForRetailId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SalesApi.Models.Retail.RetailPromotionEvent", "RetailPromotionEvent")
                        .WithMany("RetailPromotionEventBonuses")
                        .HasForeignKey("RetailPromotionEventId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionSeries", b =>
                {
                    b.HasOne("SalesApi.Models.Retail.ProductForRetail", "ProductForRetail")
                        .WithMany("RetailPromotionSeries")
                        .HasForeignKey("ProductForRetailId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SalesApi.Models.Retail.RetailPromotionSeriesBonus", b =>
                {
                    b.HasOne("SalesApi.Models.Retail.ProductForRetail", "ProductForRetail")
                        .WithMany("RetailPromotionSeriesBonuses")
                        .HasForeignKey("ProductForRetailId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SalesApi.Models.Retail.RetailPromotionSeries", "RetailPromotionSeries")
                        .WithMany("RetailPromotionSeriesBonuses")
                        .HasForeignKey("RetailPromotionSeriesId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SalesApi.Models.Settings.DeliveryVehicle", b =>
                {
                    b.HasOne("SalesApi.Models.Settings.DistributionGroup", "DistributionGroup")
                        .WithMany()
                        .HasForeignKey("DistributionGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SalesApi.Models.Settings.DistributionGroup")
                        .WithMany("DeliveryVehicles")
                        .HasForeignKey("DistributionGroupId1");

                    b.HasOne("SalesApi.Models.Settings.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SalesApi.Models.Settings.Vehicle")
                        .WithMany("DeliveryVehicles")
                        .HasForeignKey("VehicleId1");
                });

            modelBuilder.Entity("SalesApi.Models.Settings.SubArea", b =>
                {
                    b.HasOne("SalesApi.Models.Settings.DeliveryVehicle", "DeliveryVehicle")
                        .WithMany("SubAreas")
                        .HasForeignKey("DeliveryVehicleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
