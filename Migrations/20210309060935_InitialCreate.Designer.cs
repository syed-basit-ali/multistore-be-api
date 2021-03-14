﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet.Models;

namespace dotnet.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210309060935_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("dotnet.Models.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountType");

                    b.Property<string>("CNIC");

                    b.Property<short?>("IsVerified");

                    b.Property<string>("MSISDN");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("dotnet.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BankName");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("dotnet.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banner");

                    b.Property<string>("Description");

                    b.Property<long>("GroupId");

                    b.Property<string>("Name");

                    b.Property<string>("Thumnail");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("dotnet.Models.Classification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banner");

                    b.Property<long>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Thumbmail");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Classifications");
                });

            modelBuilder.Entity("dotnet.Models.Delivery", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AssignedDate");

                    b.Property<DateTime>("DeliveredDate");

                    b.Property<long>("OrderId");

                    b.Property<long>("RiderId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("RiderId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("dotnet.Models.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banner");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Thumbnail");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("dotnet.Models.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path");

                    b.Property<long>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("dotnet.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CustomerLat");

                    b.Property<double>("CustomerLong");

                    b.Property<string>("DelieveryAddress");

                    b.Property<string>("Description");

                    b.Property<short?>("IsReceived");

                    b.Property<int>("OrderCode");

                    b.Property<DateTime>("OrderDeliveryDate");

                    b.Property<DateTime>("OrderPlacementDate");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("PaymentMethod");

                    b.Property<long?>("ReturnDiscount");

                    b.Property<int?>("ReturnQuantity");

                    b.Property<long?>("ReturnedProductId");

                    b.Property<long?>("RiderId");

                    b.Property<long>("ShopId");

                    b.Property<long>("TotalAmmount");

                    b.Property<long>("UserId");

                    b.Property<int?>("deliveryCharges");

                    b.HasKey("Id");

                    b.HasIndex("ReturnedProductId");

                    b.HasIndex("RiderId");

                    b.HasIndex("ShopId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("dotnet.Models.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("OrderId");

                    b.Property<long>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("TotalAmount");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("dotnet.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ClassificationId");

                    b.Property<string>("Description");

                    b.Property<string>("Dimension");

                    b.Property<int?>("Discount");

                    b.Property<short?>("IsAllowed");

                    b.Property<short?>("IsDisabled");

                    b.Property<short?>("IsNew");

                    b.Property<short?>("IsOffer");

                    b.Property<short?>("IsOutOfStock");

                    b.Property<short?>("IsSale");

                    b.Property<int>("Price");

                    b.Property<string>("ProductCode");

                    b.Property<string>("ProductDetail");

                    b.Property<int?>("Quantity");

                    b.Property<long>("ShopId");

                    b.Property<string>("Title");

                    b.Property<string>("Unit");

                    b.Property<float?>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ClassificationId");

                    b.HasIndex("ShopId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("dotnet.Models.ProductType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("dotnet.Models.ReturnedProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("ReturnedProducts");
                });

            modelBuilder.Entity("dotnet.Models.Rider", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CNIC");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("DeliveryArea");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<long>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Riders");
                });

            modelBuilder.Entity("dotnet.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Title = "ShopOwner"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Customer"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Rider"
                        });
                });

            modelBuilder.Entity("dotnet.Models.Service", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Charges");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("dotnet.Models.Shop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber");

                    b.Property<string>("AccountType");

                    b.Property<string>("Address");

                    b.Property<string>("BankName");

                    b.Property<string>("Banner");

                    b.Property<string>("Contact");

                    b.Property<long>("DeliveryRadius");

                    b.Property<long>("GroupId");

                    b.Property<short?>("IsDisabled");

                    b.Property<short?>("IsInRange");

                    b.Property<short?>("IsReturnable");

                    b.Property<short?>("IsVerified");

                    b.Property<double>("Latitude");

                    b.Property<string>("Logo");

                    b.Property<double>("Longitude");

                    b.Property<string>("NDN_Number");

                    b.Property<string>("Name");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("dotnet.Models.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<long>("OrderId");

                    b.Property<long>("ShopId");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ShopId");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("dotnet.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CNIC");

                    b.Property<string>("CNIC_Image");

                    b.Property<int>("Code");

                    b.Property<string>("Contact_Number");

                    b.Property<string>("Email_Address");

                    b.Property<string>("FirstName");

                    b.Property<short?>("IsDisabled");

                    b.Property<short?>("IsVerified");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("RoleId");

                    b.Property<string>("Site_link");

                    b.Property<string>("UserImage");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("dotnet.Models.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.Property<string>("Registration_Number");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("dotnet.Models.Account", b =>
                {
                    b.HasOne("dotnet.Models.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Category", b =>
                {
                    b.HasOne("dotnet.Models.Group", "Group")
                        .WithMany("Categories")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Classification", b =>
                {
                    b.HasOne("dotnet.Models.Category", "Category")
                        .WithMany("Classifications")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Delivery", b =>
                {
                    b.HasOne("dotnet.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotnet.Models.Rider", "Rider")
                        .WithMany()
                        .HasForeignKey("RiderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Image", b =>
                {
                    b.HasOne("dotnet.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Order", b =>
                {
                    b.HasOne("dotnet.Models.ReturnedProduct", "ReturnedProduct")
                        .WithMany()
                        .HasForeignKey("ReturnedProductId");

                    b.HasOne("dotnet.Models.User", "Rider")
                        .WithMany()
                        .HasForeignKey("RiderId");

                    b.HasOne("dotnet.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotnet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.OrderItem", b =>
                {
                    b.HasOne("dotnet.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotnet.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Product", b =>
                {
                    b.HasOne("dotnet.Models.Classification", "Classification")
                        .WithMany()
                        .HasForeignKey("ClassificationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotnet.Models.Shop", "Shop")
                        .WithMany("Products")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Rider", b =>
                {
                    b.HasOne("dotnet.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Shop", b =>
                {
                    b.HasOne("dotnet.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotnet.Models.User", "User")
                        .WithMany("Shops")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.Transaction", b =>
                {
                    b.HasOne("dotnet.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotnet.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dotnet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dotnet.Models.User", b =>
                {
                    b.HasOne("dotnet.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
