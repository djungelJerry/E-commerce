﻿// <auto-generated />
using System;
using MVC.E_Commerce;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.E_Commerce.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230507061236_storesupp")]
    partial class storesupp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 1
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 2
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 3
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 4
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 5
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 6
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 11
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 12
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 13
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 14
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 15
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 21
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 22
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 23
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 24
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 31
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 32
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 33
                        },
                        new
                        {
                            CategoriesId = 4,
                            ProductsId = 34
                        },
                        new
                        {
                            CategoriesId = 5,
                            ProductsId = 41
                        },
                        new
                        {
                            CategoriesId = 5,
                            ProductsId = 42
                        },
                        new
                        {
                            CategoriesId = 5,
                            ProductsId = 43
                        },
                        new
                        {
                            CategoriesId = 5,
                            ProductsId = 44
                        },
                        new
                        {
                            CategoriesId = 6,
                            ProductsId = 51
                        },
                        new
                        {
                            CategoriesId = 6,
                            ProductsId = 52
                        },
                        new
                        {
                            CategoriesId = 6,
                            ProductsId = 53
                        },
                        new
                        {
                            CategoriesId = 6,
                            ProductsId = 54
                        },
                        new
                        {
                            CategoriesId = 6,
                            ProductsId = 55
                        },
                        new
                        {
                            CategoriesId = 7,
                            ProductsId = 61
                        },
                        new
                        {
                            CategoriesId = 7,
                            ProductsId = 62
                        },
                        new
                        {
                            CategoriesId = 7,
                            ProductsId = 63
                        },
                        new
                        {
                            CategoriesId = 7,
                            ProductsId = 64
                        },
                        new
                        {
                            CategoriesId = 8,
                            ProductsId = 71
                        },
                        new
                        {
                            CategoriesId = 8,
                            ProductsId = 72
                        },
                        new
                        {
                            CategoriesId = 8,
                            ProductsId = 73
                        },
                        new
                        {
                            CategoriesId = 9,
                            ProductsId = 81
                        });
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CartTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<decimal>("CartItemTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Monitor"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Desktop"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Printer"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Mouse"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Keyboard"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Graphics card"
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "RAM"
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Floppy disk"
                        });
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductDescription = "13.3\", 1440x900, Intel Core i5 1.8GHz, 8GB, 128GB Flash Storage, Intel HD Graphics 6000",
                            ProductName = "Apple MacBook Air",
                            ProductPrice = 11890.00m
                        },
                        new
                        {
                            Id = 2,
                            ProductDescription = "13.3\", IPS Panel Retina Display 2560x1600, Intel Core i5 2.3GHz,8GB, 128GB SSD, Intel Iris Plus Graphics 640",
                            ProductName = "Apple MacBook Pro",
                            ProductPrice = 16599.99m
                        },
                        new
                        {
                            Id = 3,
                            ProductDescription = "15.6\", 1366x768, AMD A9-Series 9420 3GHz, 4GB, 500GB HDD, AMD Radeon R5",
                            ProductName = "Acer Aspire 3",
                            ProductPrice = 4599.90m
                        },
                        new
                        {
                            Id = 4,
                            ProductDescription = "14.0\", Full HD 1920x1080, Intel Core i7 8550U 1.8GHz, 16GB, 512GB SSD, Nvidia GeForce MX150",
                            ProductName = "ZenBook UX430UN",
                            ProductPrice = 15999.99m
                        },
                        new
                        {
                            Id = 5,
                            ProductDescription = "14.0\", IPS Panel Full HD 1920x1080, Intel Core i5 8250U 1.6GHz, 8GB, 256GB SSD, Intel UHD Graphics 620",
                            ProductName = "Acer Swift 3",
                            ProductPrice = 3998.49m
                        },
                        new
                        {
                            Id = 6,
                            ProductDescription = "13.3\", IPS Panel Full HD / Touchscreen 1920x1080, Intel Core i5 8250U 1.6GHz, 8GB, 128GB SSD, Intel UHD Graphics 620",
                            ProductName = "Dell XPS 13",
                            ProductPrice = 9999.98m
                        },
                        new
                        {
                            Id = 11,
                            ProductDescription = "24\", 1920x1080, IPS, 165Hz, FreeSync Premium",
                            ProductName = "Acer CP1241Y V",
                            ProductPrice = 1949.49m
                        },
                        new
                        {
                            Id = 12,
                            ProductDescription = "27\", 1920x1080, VA, 144Hz, FreeSync Premium",
                            ProductName = "AOC C27G1",
                            ProductPrice = 2199.99m
                        },
                        new
                        {
                            Id = 13,
                            ProductDescription = "32\", 2560x1440, IPS, 165Hz, FreeSync Premium",
                            ProductName = "Cooler Master GM32-FQ",
                            ProductPrice = 3669.00m
                        },
                        new
                        {
                            Id = 14,
                            ProductDescription = "27\", 2560x1440, VA, 165Hz, FreeSync Premium",
                            ProductName = "MSI G27CQ4",
                            ProductPrice = 4669.00m
                        },
                        new
                        {
                            Id = 15,
                            ProductDescription = "32\", 3840x2160, IPS, 144Hz, FreeSync Premium",
                            ProductName = "Samsung Odyssey G70B32",
                            ProductPrice = 3669.00m
                        },
                        new
                        {
                            Id = 21,
                            ProductDescription = "12th-generation Intel Core i5 – i9, NVIDIA GeForce RTX 3090, 128GB DDR5-3600. 2TB M.2 PCIe NVME SSD + 2TB SATA 7200RPM HDD",
                            ProductName = "Dell XPS Desktop",
                            ProductPrice = 1669.49m
                        },
                        new
                        {
                            Id = 22,
                            ProductDescription = "Apple M2 Pro, Integrated 16-core GPU, 32GB unified memory, 8TB SSD",
                            ProductName = "Apple Mac Mini M2",
                            ProductPrice = 21299.99m
                        },
                        new
                        {
                            Id = 23,
                            ProductDescription = "Intel Core i9-12900K, NVIDIA GeForce RTX 3090, 128GB 4400MHz DDR5, 2TB SSD + 3TB HDD",
                            ProductName = "MSI MEG Aegis Ti5",
                            ProductPrice = 36699.99m
                        },
                        new
                        {
                            Id = 24,
                            ProductDescription = "12th Gen Intel Core i9-12900K, Nvidia RTX 3080 Ti, 64GB DDR4 2666MHz, 1 x M.2 SSD + 1 x 2.5\" SSD",
                            ProductName = "Corsair One i300",
                            ProductPrice = 31599.00m
                        },
                        new
                        {
                            Id = 31,
                            ProductDescription = "High-resolution, 20 ppm, Ethernet/WiFi",
                            ProductName = "HP OfficeJet Pro 8025",
                            ProductPrice = 189.00m
                        },
                        new
                        {
                            Id = 32,
                            ProductDescription = "Duplex Printing, 32 ppm, Wi-Fi",
                            ProductName = "Brother Monochrome Laser Printer",
                            ProductPrice = 199.99m
                        },
                        new
                        {
                            Id = 33,
                            ProductDescription = "Mobile Printing, 9 ppm, USB/Wi-Fi",
                            ProductName = "Canon PIXMA",
                            ProductPrice = 89.00m
                        },
                        new
                        {
                            Id = 34,
                            ProductDescription = "Color Network Printer, 22 ppm, Ethernet/WiFi",
                            ProductName = "Kyocera Printer",
                            ProductPrice = 312.47m
                        },
                        new
                        {
                            Id = 41,
                            ProductDescription = "DPI: 8,000, Interface: Bluetooth and 2.4GHz wireless, Buttons: 7, Ergonomic: Right-handed, Features: up to 70 days battery life, USB-C charging",
                            ProductName = "Logitech MX Master 3S",
                            ProductPrice = 129.99m
                        },
                        new
                        {
                            Id = 42,
                            ProductDescription = "DPI: unavailable, Interface: Bluetooth, Buttons: 4, Ergonomic: Ambidextrous, Features: Microsoft’s BlueTrack technology, up to 33 feet in range, Battery level reporting",
                            ProductName = "Microsoft Modern Mobile Mouse",
                            ProductPrice = 69.90m
                        },
                        new
                        {
                            Id = 43,
                            ProductDescription = "DPI: 1300, Interface: Bluetooth, Buttons: 0 Ergonomic: Ambidextrous, Features: Multi-touch",
                            ProductName = "Apple Magic Mouse",
                            ProductPrice = 139.80m
                        },
                        new
                        {
                            Id = 44,
                            ProductDescription = "DPI: up to 30,000, Interface: Razer HyperSpeed Wireless, USB-C, Buttons: 5, Ergonomic: Right, Features: 90-hour battery, upgradable to 4,000Hz polling rate, optical switches",
                            ProductName = "Razer DeathAdder V3 Pro",
                            ProductPrice = 149.00m
                        },
                        new
                        {
                            Id = 51,
                            ProductDescription = "Interface: Bluetooth 5.1, Logi Bolt USB Receiver, Keyboard backlighting: Yes, Switches: TBD",
                            ProductName = "Logitech Signature K650",
                            ProductPrice = 899.00m
                        },
                        new
                        {
                            Id = 52,
                            ProductDescription = "Interface: USB wireless receiver, Keyboard backlighting: No, Switches: Cherry SX scissor",
                            ProductName = "Cherry Stream Desktop",
                            ProductPrice = 499.00m
                        },
                        new
                        {
                            Id = 53,
                            ProductDescription = "Interface: Bluetooth, Razer HyperSpeed 2.4GHz, Wired USB-C, Keyboard backlighting: Yes, Switches: Razer Yellow Mechanical Switch",
                            ProductName = "Razer Pro Type Ultra",
                            ProductPrice = 149.00m
                        },
                        new
                        {
                            Id = 54,
                            ProductDescription = "Interface: Bluetooth 5.1, USB-C, Keyboard backlighting: 7 white LED backlit effects, Switches: Pre-lubed Kailh Jellyfish mechanical switches",
                            ProductName = "Lofree 1% Transparent",
                            ProductPrice = 89.89m
                        },
                        new
                        {
                            Id = 55,
                            ProductDescription = "Interface: Wireless, Keyboard backlighting: Yes, Switches: Scissor",
                            ProductName = "Apple Magic Keyboard",
                            ProductPrice = 119.99m
                        },
                        new
                        {
                            Id = 61,
                            ProductDescription = "GPU: Ada AD102, GPU Cores: 16384, Boost Clock: 2,520 MHz, Video RAM: 24GB GDDR6X 21 Gbps, TBP: 450 watts",
                            ProductName = "GeForce RTX 4090",
                            ProductPrice = 1999.99m
                        },
                        new
                        {
                            Id = 62,
                            ProductDescription = "GPU: Navi 31, GPU Cores: 12288, Boost Clock: 2500 MHz, Video RAM: 24GB GDDR6 20 Gbps, TBP: 355 watts",
                            ProductName = "Radeon RX 7900 XTX",
                            ProductPrice = 1288.00m
                        },
                        new
                        {
                            Id = 63,
                            ProductDescription = "GPU: Navi 23, GPU Cores: 1792, Boost Clock: 2,491 MHz, Video RAM: 8GB GDDR6 14 Gbps, TBP: 132 watts",
                            ProductName = "Radeon RX 6600",
                            ProductPrice = 399.99m
                        },
                        new
                        {
                            Id = 64,
                            ProductDescription = "GPU: AD 104, GPU Cores: 7680, Boost Clock: 2,610 MHz, Video RAM: 12GB GDDR6X 21 Gbps, TBP: 320 watts",
                            ProductName = "GeForce RTX 4070 Ti",
                            ProductPrice = 1111.11m
                        },
                        new
                        {
                            Id = 71,
                            ProductDescription = "Capacity: 16GB (2 x 8GB), Memory Type: 288-Pin DDR4 SDRAM, Memory Speed: 3,200MHz, CAS Latency: 16",
                            ProductName = "HyperX Predator DDR4 RGB",
                            ProductPrice = 160.50m
                        },
                        new
                        {
                            Id = 72,
                            ProductDescription = "Capacity: 16GB (2 x 8GB), Memory Type: 288-Pin DDR4 SDRAM, Memory Speed: 3,200MHz, CAS Latency: 16",
                            ProductName = "Teamgroup T-Force Dark Z",
                            ProductPrice = 160.50m
                        },
                        new
                        {
                            Id = 73,
                            ProductDescription = "Capacity: 32GB (2 x 16GB), Memory Type: 288-Pin DDR5 SDRAM, Memory Speed: 5,200MHz, CAS Latency: 38",
                            ProductName = "Corsair Dominator Platinum RGB",
                            ProductPrice = 160.50m
                        },
                        new
                        {
                            Id = 81,
                            ProductDescription = "USB, External Floppy Disk Drive, Portable 1.44 MB FDD",
                            ProductName = "Chuanganzhuo",
                            ProductPrice = 26.50m
                        });
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.StoreSupport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StoreSupports");
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.Support", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supports");
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "Gaming"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "Office"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "Portable"
                        },
                        new
                        {
                            Id = 4,
                            TagName = "Productivity"
                        },
                        new
                        {
                            Id = 5,
                            TagName = "Retro"
                        });
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ProductTag");

                    b.HasData(
                        new
                        {
                            ProductsId = 1,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 1,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 2,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 2,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 3,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 4,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 4,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 5,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 6,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 6,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 11,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 12,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 13,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 14,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 15,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 15,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 31,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 32,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 33,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 34,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 41,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 41,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 42,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 43,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 44,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 51,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 52,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 52,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 53,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 54,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 55,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 55,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 61,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 61,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 62,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 62,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 63,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 64,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 64,
                            TagsId = 2
                        },
                        new
                        {
                            ProductsId = 71,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 72,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 73,
                            TagsId = 1
                        },
                        new
                        {
                            ProductsId = 73,
                            TagsId = 4
                        },
                        new
                        {
                            ProductsId = 81,
                            TagsId = 3
                        },
                        new
                        {
                            ProductsId = 81,
                            TagsId = 5
                        });
                });

            modelBuilder.Entity("StoreSupportSupport", b =>
                {
                    b.Property<int>("StoreSupportsId")
                        .HasColumnType("int");

                    b.Property<int>("SupportsId")
                        .HasColumnType("int");

                    b.HasKey("StoreSupportsId", "SupportsId");

                    b.HasIndex("SupportsId");

                    b.ToTable("StoreSupportSupport");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("MVC.E_Commerce.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.E_Commerce.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.CartItem", b =>
                {
                    b.HasOne("MVC.E_Commerce.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.E_Commerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.HasOne("MVC.E_Commerce.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.E_Commerce.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreSupportSupport", b =>
                {
                    b.HasOne("MVC.E_Commerce.Models.StoreSupport", null)
                        .WithMany()
                        .HasForeignKey("StoreSupportsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.E_Commerce.Models.Support", null)
                        .WithMany()
                        .HasForeignKey("SupportsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC.E_Commerce.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
