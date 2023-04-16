using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataInTablesProductsCategoriesTagsCategoryProductProductTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Laptop" },
                    { 2, "Monitor" },
                    { 3, "Desktop" },
                    { 4, "Printer" },
                    { 5, "Mouse" },
                    { 6, "Keyboard" },
                    { 7, "Graphics card" },
                    { 8, "RAM" },
                    { 9, "Floppy disk" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "13.3\", 1440x900, Intel Core i5 1.8GHz, 8GB, 128GB Flash Storage, Intel HD Graphics 6000", "Apple MacBook Air", 11890.00m },
                    { 2, "13.3\", IPS Panel Retina Display 2560x1600, Intel Core i5 2.3GHz,8GB, 128GB SSD, Intel Iris Plus Graphics 640", "Apple MacBook Pro", 16599.99m },
                    { 3, "15.6\", 1366x768, AMD A9-Series 9420 3GHz, 4GB, 500GB HDD, AMD Radeon R5", "Acer Aspire 3", 4599.90m },
                    { 4, "14.0\", Full HD 1920x1080, Intel Core i7 8550U 1.8GHz, 16GB, 512GB SSD, Nvidia GeForce MX150", "ZenBook UX430UN", 15999.99m },
                    { 5, "14.0\", IPS Panel Full HD 1920x1080, Intel Core i5 8250U 1.6GHz, 8GB, 256GB SSD, Intel UHD Graphics 620", "Acer Swift 3", 3998.49m },
                    { 6, "13.3\", IPS Panel Full HD / Touchscreen 1920x1080, Intel Core i5 8250U 1.6GHz, 8GB, 128GB SSD, Intel UHD Graphics 620", "Dell XPS 13", 9999.98m },
                    { 11, "24\", 1920x1080, IPS, 165Hz, FreeSync Premium", "Acer CP1241Y V", 1949.49m },
                    { 12, "27\", 1920x1080, VA, 144Hz, FreeSync Premium", "AOC C27G1", 2199.99m },
                    { 13, "32\", 2560x1440, IPS, 165Hz, FreeSync Premium", "Cooler Master GM32-FQ", 3669.00m },
                    { 14, "27\", 2560x1440, VA, 165Hz, FreeSync Premium", "MSI G27CQ4", 4669.00m },
                    { 15, "32\", 3840x2160, IPS, 144Hz, FreeSync Premium", "Samsung Odyssey G70B32", 3669.00m },
                    { 21, "12th-generation Intel Core i5 – i9, NVIDIA GeForce RTX 3090, 128GB DDR5-3600. 2TB M.2 PCIe NVME SSD + 2TB SATA 7200RPM HDD", "Dell XPS Desktop", 1669.49m },
                    { 22, "Apple M2 Pro, Integrated 16-core GPU, 32GB unified memory, 8TB SSD", "Apple Mac Mini M2", 21299.99m },
                    { 23, "Intel Core i9-12900K, NVIDIA GeForce RTX 3090, 128GB 4400MHz DDR5, 2TB SSD + 3TB HDD", "MSI MEG Aegis Ti5", 36699.99m },
                    { 24, "12th Gen Intel Core i9-12900K, Nvidia RTX 3080 Ti, 64GB DDR4 2666MHz, 1 x M.2 SSD + 1 x 2.5\" SSD", "Corsair One i300", 31599.00m },
                    { 31, "High-resolution, 20 ppm, Ethernet/WiFi", "HP OfficeJet Pro 8025", 189.00m },
                    { 32, "Duplex Printing, 32 ppm, Wi-Fi", "Brother Monochrome Laser Printer", 199.99m },
                    { 33, "Mobile Printing, 9 ppm, USB/Wi-Fi", "Canon PIXMA", 89.00m },
                    { 34, "Color Network Printer, 22 ppm, Ethernet/WiFi", "Kyocera Printer", 312.47m },
                    { 41, "DPI: 8,000, Interface: Bluetooth and 2.4GHz wireless, Buttons: 7, Ergonomic: Right-handed, Features: up to 70 days battery life, USB-C charging", "Logitech MX Master 3S", 129.99m },
                    { 42, "DPI: unavailable, Interface: Bluetooth, Buttons: 4, Ergonomic: Ambidextrous, Features: Microsoft’s BlueTrack technology, up to 33 feet in range, Battery level reporting", "Microsoft Modern Mobile Mouse", 69.90m },
                    { 43, "DPI: 1300, Interface: Bluetooth, Buttons: 0 Ergonomic: Ambidextrous, Features: Multi-touch", "Apple Magic Mouse", 139.80m },
                    { 44, "DPI: up to 30,000, Interface: Razer HyperSpeed Wireless, USB-C, Buttons: 5, Ergonomic: Right, Features: 90-hour battery, upgradable to 4,000Hz polling rate, optical switches", "Razer DeathAdder V3 Pro", 149.00m },
                    { 51, "Interface: Bluetooth 5.1, Logi Bolt USB Receiver, Keyboard backlighting: Yes, Switches: TBD", "Logitech Signature K650", 899.00m },
                    { 52, "Interface: USB wireless receiver, Keyboard backlighting: No, Switches: Cherry SX scissor", "Cherry Stream Desktop", 499.00m },
                    { 53, "Interface: Bluetooth, Razer HyperSpeed 2.4GHz, Wired USB-C, Keyboard backlighting: Yes, Switches: Razer Yellow Mechanical Switch", "Razer Pro Type Ultra", 149.00m },
                    { 54, "Interface: Bluetooth 5.1, USB-C, Keyboard backlighting: 7 white LED backlit effects, Switches: Pre-lubed Kailh Jellyfish mechanical switches", "Lofree 1% Transparent", 89.89m },
                    { 55, "Interface: Wireless, Keyboard backlighting: Yes, Switches: Scissor", "Apple Magic Keyboard", 119.99m },
                    { 61, "GPU: Ada AD102, GPU Cores: 16384, Boost Clock: 2,520 MHz, Video RAM: 24GB GDDR6X 21 Gbps, TBP: 450 watts", "GeForce RTX 4090", 1999.99m },
                    { 62, "GPU: Navi 31, GPU Cores: 12288, Boost Clock: 2500 MHz, Video RAM: 24GB GDDR6 20 Gbps, TBP: 355 watts", "Radeon RX 7900 XTX", 1288.00m },
                    { 63, "GPU: Navi 23, GPU Cores: 1792, Boost Clock: 2,491 MHz, Video RAM: 8GB GDDR6 14 Gbps, TBP: 132 watts", "Radeon RX 6600", 399.99m },
                    { 64, "GPU: AD 104, GPU Cores: 7680, Boost Clock: 2,610 MHz, Video RAM: 12GB GDDR6X 21 Gbps, TBP: 320 watts", "GeForce RTX 4070 Ti", 1111.11m },
                    { 71, "Capacity: 16GB (2 x 8GB), Memory Type: 288-Pin DDR4 SDRAM, Memory Speed: 3,200MHz, CAS Latency: 16", "HyperX Predator DDR4 RGB", 160.50m },
                    { 72, "Capacity: 16GB (2 x 8GB), Memory Type: 288-Pin DDR4 SDRAM, Memory Speed: 3,200MHz, CAS Latency: 16", "Teamgroup T-Force Dark Z", 160.50m },
                    { 73, "Capacity: 32GB (2 x 16GB), Memory Type: 288-Pin DDR5 SDRAM, Memory Speed: 5,200MHz, CAS Latency: 38", "Corsair Dominator Platinum RGB", 160.50m },
                    { 81, "USB, External Floppy Disk Drive, Portable 1.44 MB FDD", "Chuanganzhuo", 26.50m }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "Gaming" },
                    { 2, "Office" },
                    { 3, "Portable" },
                    { 4, "Productivity" },
                    { 5, "Retro" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 3, 21 },
                    { 3, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 4, 31 },
                    { 4, 32 },
                    { 4, 33 },
                    { 4, 34 },
                    { 5, 41 },
                    { 5, 42 },
                    { 5, 43 },
                    { 5, 44 },
                    { 6, 51 },
                    { 6, 52 },
                    { 6, 53 },
                    { 6, 54 },
                    { 6, 55 },
                    { 7, 61 },
                    { 7, 62 },
                    { 7, 63 },
                    { 7, 64 },
                    { 8, 71 },
                    { 8, 72 },
                    { 8, 73 },
                    { 9, 81 }
                });

            migrationBuilder.InsertData(
                table: "ProductTag",
                columns: new[] { "ProductsId", "TagsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 2 },
                    { 6, 3 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 15, 4 },
                    { 31, 2 },
                    { 32, 2 },
                    { 33, 2 },
                    { 34, 2 },
                    { 41, 2 },
                    { 41, 4 },
                    { 42, 3 },
                    { 43, 2 },
                    { 44, 1 },
                    { 51, 2 },
                    { 52, 2 },
                    { 52, 4 },
                    { 53, 1 },
                    { 54, 3 },
                    { 55, 2 },
                    { 55, 4 },
                    { 61, 1 },
                    { 61, 4 },
                    { 62, 1 },
                    { 62, 4 },
                    { 63, 2 },
                    { 64, 1 },
                    { 64, 2 },
                    { 71, 1 },
                    { 72, 1 },
                    { 73, 1 },
                    { 73, 4 },
                    { 81, 3 },
                    { 81, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 31 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 33 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 41 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 42 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 43 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 44 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 6, 51 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 6, 52 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 6, 53 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 6, 54 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 6, 55 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 61 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 62 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 63 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 64 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 71 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 72 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 73 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 9, 81 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 42, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 52, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 55, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 61, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 62, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 73, 4 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 81, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 81, 5 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
