using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exercise_9.Entity
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(" Server=tcp:snexercise9rpalo.database.windows.net,1433;Initial Catalog=exercise9rpalo;Persist Security Info=False;User ID=FY2205rdp;Password=@ccenture123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Caliber).HasMaxLength(150);

                entity.Property(e => e.CaseMaterial)
                    .HasColumnName("Case_Material")
                    .HasMaxLength(150);

                entity.Property(e => e.Chronograph).HasMaxLength(150);

                entity.Property(e => e.Diameter).HasMaxLength(150);

                entity.Property(e => e.FullDescription)
                    .HasColumnName("Full_Description")
                    .HasMaxLength(4000);

                entity.Property(e => e.Height).HasMaxLength(150);

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemNumber)
                    .IsRequired()
                    .HasColumnName("Item_Number")
                    .HasMaxLength(150);

                entity.Property(e => e.Jewely).HasMaxLength(150);

                entity.Property(e => e.Movement).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("Short_Description")
                    .HasMaxLength(4000);

                entity.Property(e => e.StrapMaterial)
                    .HasColumnName("Strap_Material")
                    .HasMaxLength(150);

                entity.Property(e => e.Thickness).HasMaxLength(150);

                entity.Property(e => e.Weight).HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
