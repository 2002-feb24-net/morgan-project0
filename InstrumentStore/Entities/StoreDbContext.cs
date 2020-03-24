using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InstrumentStore.App.Entities
{
    public partial class StoreDbContext : DbContext
    {
        public StoreDbContext()
        {
        }

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerProducts> CustomerProducts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ProductOrders> ProductOrders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<StoreManagers> StoreManagers { get; set; }
        public virtual DbSet<StoreProducts> StoreProducts { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:2002-training-hay.database.windows.net,1433;Initial Catalog=StoreDb;Persist Security Info=False;User ID=morgan;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerProducts>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Customer__C3905BAFCCCB9488");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerP__Custo__22751F6C");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerP__Produ__2180FB33");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64B89BB0F06E");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Customers__Store__18EBB532");
            });

            modelBuilder.Entity<Managers>(entity =>
            {
                entity.HasKey(e => e.ManagerId)
                    .HasName("PK__Managers__3BA2AA810E1B98E0");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Managers__StoreI__1BC821DD");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BAF3A7D3E05");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__Customer__29221CFB");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__ProductI__2A164134");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__StoreID__2B0A656D");
            });

            modelBuilder.Entity<ProductOrders>(entity =>
            {
                entity.HasKey(e => e.ProductOrderId)
                    .HasName("PK__ProductO__2FE526C53A5651A0");

                entity.Property(e => e.ProductOrderId).HasColumnName("ProductOrderID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductOr__Order__2FCF1A8A");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductOr__Produ__2EDAF651");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6EDF8F84237");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreManagers>(entity =>
            {
                entity.Property(e => e.StoreManagersId).HasColumnName("StoreManagersID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.StoreManagers)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreMana__Manag__3493CFA7");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreManagers)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreMana__Store__339FAB6E");
            });

            modelBuilder.Entity<StoreProducts>(entity =>
            {
                entity.HasKey(e => e.StoreProduct)
                    .HasName("PK__StorePro__4070B305C8024AF3");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StoreProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreProd__Produ__2645B050");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreProducts)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreProd__Store__25518C17");
            });

            modelBuilder.Entity<Stores>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__Stores__3B82F0E1E5B78B98");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
