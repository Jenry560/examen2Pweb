using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParcialDosWeb.Models;

public partial class ParcialDosContext : DbContext
{
    public ParcialDosContext()
    {
    }

    public ParcialDosContext(DbContextOptions<ParcialDosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Visita> Visitas { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Visita>(entity =>
        {
            entity.HasKey(e => e.VisitaId).HasName("PK__Visitas__D8D4BC42DF4DDD07");

            entity.Property(e => e.Apellido)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
