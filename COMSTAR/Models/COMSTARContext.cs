using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace COMSTAR.Models
{
    public partial class COMSTARContext : DbContext
    {
        public COMSTARContext()
        {
        }

        public COMSTARContext(DbContextOptions<COMSTARContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("CSconn")); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__Events__7944C8108C94A8CC");

                entity.Property(e => e.EventId).HasMaxLength(7);

                entity.Property(e => e.EventDate).HasColumnType("date");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasMaxLength(280);

                entity.Property(e => e.EventImage).HasColumnType("image");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EventTarget)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
