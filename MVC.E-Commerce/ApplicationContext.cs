using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using MVC.E_Commerce.Models;


namespace MVC.E_Commerce
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Support> Supports { get; set; }
        public DbSet<StoreSupport> StoreSupports { get; set; }
        


		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Categories Table
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Laptop" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 2, CategoryName = "Monitor" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 3, CategoryName = "Desktop" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 4, CategoryName = "Printer" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 5, CategoryName = "Mouse" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 6, CategoryName = "Keyboard" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 7, CategoryName = "Graphics card" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 8, CategoryName = "RAM" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 9, CategoryName = "Floppy disk" });

            //Products Table
            // -- Laptops --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "Apple MacBook Air", ProductDescription = "13.3\", 1440x900, Intel Core i5 1.8GHz, 8GB, 128GB Flash Storage, Intel HD Graphics 6000", ProductPrice = 11890.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 2, ProductName = "Apple MacBook Pro", ProductDescription = "13.3\", IPS Panel Retina Display 2560x1600, Intel Core i5 2.3GHz,8GB, 128GB SSD, Intel Iris Plus Graphics 640", ProductPrice = 16599.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 3, ProductName = "Acer Aspire 3", ProductDescription = "15.6\", 1366x768, AMD A9-Series 9420 3GHz, 4GB, 500GB HDD, AMD Radeon R5", ProductPrice = 4599.90M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 4, ProductName = "ZenBook UX430UN", ProductDescription = "14.0\", Full HD 1920x1080, Intel Core i7 8550U 1.8GHz, 16GB, 512GB SSD, Nvidia GeForce MX150", ProductPrice = 15999.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 5, ProductName = "Acer Swift 3", ProductDescription = "14.0\", IPS Panel Full HD 1920x1080, Intel Core i5 8250U 1.6GHz, 8GB, 256GB SSD, Intel UHD Graphics 620", ProductPrice = 3998.49M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 6, ProductName = "Dell XPS 13", ProductDescription = "13.3\", IPS Panel Full HD / Touchscreen 1920x1080, Intel Core i5 8250U 1.6GHz, 8GB, 128GB SSD, Intel UHD Graphics 620", ProductPrice = 9999.98M });
            // -- Monitors --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 11, ProductName = "Acer CP1241Y V", ProductDescription = "24\", 1920x1080, IPS, 165Hz, FreeSync Premium", ProductPrice = 1949.49M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 12, ProductName = "AOC C27G1", ProductDescription = "27\", 1920x1080, VA, 144Hz, FreeSync Premium", ProductPrice = 2199.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 13, ProductName = "Cooler Master GM32-FQ", ProductDescription = "32\", 2560x1440, IPS, 165Hz, FreeSync Premium", ProductPrice = 3669.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 14, ProductName = "MSI G27CQ4", ProductDescription = "27\", 2560x1440, VA, 165Hz, FreeSync Premium", ProductPrice = 4669.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 15, ProductName = "Samsung Odyssey G70B32", ProductDescription = "32\", 3840x2160, IPS, 144Hz, FreeSync Premium", ProductPrice = 3669.00M });
            // -- Desktops --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 21, ProductName = "Dell XPS Desktop", ProductDescription = "12th-generation Intel Core i5 – i9, NVIDIA GeForce RTX 3090, 128GB DDR5-3600. 2TB M.2 PCIe NVME SSD + 2TB SATA 7200RPM HDD", ProductPrice = 1669.49M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 22, ProductName = "Apple Mac Mini M2", ProductDescription = "Apple M2 Pro, Integrated 16-core GPU, 32GB unified memory, 8TB SSD", ProductPrice = 21299.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 23, ProductName = "MSI MEG Aegis Ti5", ProductDescription = "Intel Core i9-12900K, NVIDIA GeForce RTX 3090, 128GB 4400MHz DDR5, 2TB SSD + 3TB HDD", ProductPrice = 36699.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 24, ProductName = "Corsair One i300", ProductDescription = "12th Gen Intel Core i9-12900K, Nvidia RTX 3080 Ti, 64GB DDR4 2666MHz, 1 x M.2 SSD + 1 x 2.5\" SSD", ProductPrice = 31599.00M });
            // -- Printers --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 31, ProductName = "HP OfficeJet Pro 8025", ProductDescription = "High-resolution, 20 ppm, Ethernet/WiFi", ProductPrice = 189.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 32, ProductName = "Brother Monochrome Laser Printer", ProductDescription = "Duplex Printing, 32 ppm, Wi-Fi", ProductPrice = 199.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 33, ProductName = "Canon PIXMA", ProductDescription = "Mobile Printing, 9 ppm, USB/Wi-Fi", ProductPrice = 89.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 34, ProductName = "Kyocera Printer", ProductDescription = "Color Network Printer, 22 ppm, Ethernet/WiFi", ProductPrice = 312.47M });
            // -- Mice --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 41, ProductName = "Logitech MX Master 3S", ProductDescription = "DPI: 8,000, Interface: Bluetooth and 2.4GHz wireless, Buttons: 7, Ergonomic: Right-handed, Features: up to 70 days battery life, USB-C charging", ProductPrice = 129.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 42, ProductName = "Microsoft Modern Mobile Mouse", ProductDescription = "DPI: unavailable, Interface: Bluetooth, Buttons: 4, Ergonomic: Ambidextrous, Features: Microsoft’s BlueTrack technology, up to 33 feet in range, Battery level reporting", ProductPrice = 69.90M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 43, ProductName = "Apple Magic Mouse", ProductDescription = "DPI: 1300, Interface: Bluetooth, Buttons: 0 Ergonomic: Ambidextrous, Features: Multi-touch", ProductPrice = 139.80M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 44, ProductName = "Razer DeathAdder V3 Pro", ProductDescription = "DPI: up to 30,000, Interface: Razer HyperSpeed Wireless, USB-C, Buttons: 5, Ergonomic: Right, Features: 90-hour battery, upgradable to 4,000Hz polling rate, optical switches", ProductPrice = 149.00M });
            // -- Keyboards --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 51, ProductName = "Logitech Signature K650", ProductDescription = "Interface: Bluetooth 5.1, Logi Bolt USB Receiver, Keyboard backlighting: Yes, Switches: TBD", ProductPrice = 899.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 52, ProductName = "Cherry Stream Desktop", ProductDescription = "Interface: USB wireless receiver, Keyboard backlighting: No, Switches: Cherry SX scissor", ProductPrice = 499.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 53, ProductName = "Razer Pro Type Ultra", ProductDescription = "Interface: Bluetooth, Razer HyperSpeed 2.4GHz, Wired USB-C, Keyboard backlighting: Yes, Switches: Razer Yellow Mechanical Switch", ProductPrice = 149.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 54, ProductName = "Lofree 1% Transparent", ProductDescription = "Interface: Bluetooth 5.1, USB-C, Keyboard backlighting: 7 white LED backlit effects, Switches: Pre-lubed Kailh Jellyfish mechanical switches", ProductPrice = 89.89M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 55, ProductName = "Apple Magic Keyboard", ProductDescription = "Interface: Wireless, Keyboard backlighting: Yes, Switches: Scissor", ProductPrice = 119.99M });
            // -- Graphics cards --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 61, ProductName = "GeForce RTX 4090", ProductDescription = "GPU: Ada AD102, GPU Cores: 16384, Boost Clock: 2,520 MHz, Video RAM: 24GB GDDR6X 21 Gbps, TBP: 450 watts", ProductPrice = 1999.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 62, ProductName = "Radeon RX 7900 XTX", ProductDescription = "GPU: Navi 31, GPU Cores: 12288, Boost Clock: 2500 MHz, Video RAM: 24GB GDDR6 20 Gbps, TBP: 355 watts", ProductPrice = 1288.00M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 63, ProductName = "Radeon RX 6600", ProductDescription = "GPU: Navi 23, GPU Cores: 1792, Boost Clock: 2,491 MHz, Video RAM: 8GB GDDR6 14 Gbps, TBP: 132 watts", ProductPrice = 399.99M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 64, ProductName = "GeForce RTX 4070 Ti", ProductDescription = "GPU: AD 104, GPU Cores: 7680, Boost Clock: 2,610 MHz, Video RAM: 12GB GDDR6X 21 Gbps, TBP: 320 watts", ProductPrice = 1111.11M });
            // -- RAM --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 71, ProductName = "HyperX Predator DDR4 RGB", ProductDescription = "Capacity: 16GB (2 x 8GB), Memory Type: 288-Pin DDR4 SDRAM, Memory Speed: 3,200MHz, CAS Latency: 16", ProductPrice = 160.50M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 72, ProductName = "Teamgroup T-Force Dark Z", ProductDescription = "Capacity: 16GB (2 x 8GB), Memory Type: 288-Pin DDR4 SDRAM, Memory Speed: 3,200MHz, CAS Latency: 16", ProductPrice = 160.50M });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 73, ProductName = "Corsair Dominator Platinum RGB", ProductDescription = "Capacity: 32GB (2 x 16GB), Memory Type: 288-Pin DDR5 SDRAM, Memory Speed: 5,200MHz, CAS Latency: 38", ProductPrice = 160.50M });
            // -- Floppy disk --
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 81, ProductName = "Chuanganzhuo", ProductDescription = "USB, External Floppy Disk Drive, Portable 1.44 MB FDD", ProductPrice = 26.50M });

            //Tags Table
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, TagName = "Gaming" });
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 2, TagName = "Office" });
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 3, TagName = "Portable" });
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 4, TagName = "Productivity" });
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 5, TagName = "Retro" });
            
            //CategoryProduct Table
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 1 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 2 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 3 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 4 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 5 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 1, ProductsId = 6 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 11 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 12 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 13 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 14 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 2, ProductsId = 15 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 3, ProductsId = 21 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 3, ProductsId = 22 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 3, ProductsId = 23 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 3, ProductsId = 24 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 31 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 32 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 33 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 4, ProductsId = 34 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 5, ProductsId = 41 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 5, ProductsId = 42 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 5, ProductsId = 43 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 5, ProductsId = 44 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 6, ProductsId = 51 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 6, ProductsId = 52 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 6, ProductsId = 53 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 6, ProductsId = 54 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 6, ProductsId = 55 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 7, ProductsId = 61 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 7, ProductsId = 62 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 7, ProductsId = 63 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 7, ProductsId = 64 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 8, ProductsId = 71 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 8, ProductsId = 72 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 8, ProductsId = 73 });
            modelBuilder.Entity("CategoryProduct").HasData(
                new { CategoriesId = 9, ProductsId = 81 });

            //ProductTag Table
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 1, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 1, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 2, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 2, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 3, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 4, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 4, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 5, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 6, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 6, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 11, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 12, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 13, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 14, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 15, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 15, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 31, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 32, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 33, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 34, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 41, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 41, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 42, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 43, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 44, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 51, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 52, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 52, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 53, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 54, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 55, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 55, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 61, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 61, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 62, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 62, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 63, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 64, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 64, TagsId = 2 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 71, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 72, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 73, TagsId = 1 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 73, TagsId = 4 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 81, TagsId = 3 });
            modelBuilder.Entity("ProductTag").HasData(
                new { ProductsId = 81, TagsId = 5 });
        }
    }
}

