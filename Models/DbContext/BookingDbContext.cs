using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BookingForBeauty.Models.Entities;

namespace Models
{
    public partial class BookingDbContext : DbContext
    {
        public BookingDbContext()
        {
        }

        public BookingDbContext(DbContextOptions<BookingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appuntamenti> Appuntamentis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=BookingDB;User Id=postgres;Password=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appuntamenti>(entity =>
            {
                entity.HasKey(e => e.IdAppuntamento)
                    .HasName("Appuntamenti_pkey");

                entity.ToTable("Appuntamenti");

                entity.Property(e => e.IdAppuntamento).HasColumnName("id_appuntamento");

                entity.Property(e => e.Data)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("data");

                entity.Property(e => e.Descrizione).HasColumnName("descrizione");

                entity.Property(e => e.NomeCliente)
                    .HasMaxLength(50)
                    .HasColumnName("nome_cliente");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
