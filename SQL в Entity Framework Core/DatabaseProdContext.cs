using Microsoft.EntityFrameworkCore;

namespace SQL_в_Entity_Framework_Core;

public partial class DatabaseProdContext : DbContext
{
    public DatabaseProdContext()
    {
    }

    public DatabaseProdContext(DbContextOptions<DatabaseProdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-SE38RKL;Database=Fruits_And_Veg;Integrated Security=SSPI;TrustServerCertificate=true");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Product>(entity =>
    //    {
    //        entity.HasKey(e => e.Id)
    //            .HasName("aaaaabooks_PK")
    //            .IsClustered(false);

    //        entity.ToTable("books");

    //        entity.Property(e => e.Name).HasMaxLength(100);
    //        entity.Property(e => e.Color).HasMaxLength(50);
    //        entity.Property(e => e.Type).HasMaxLength(50);
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
