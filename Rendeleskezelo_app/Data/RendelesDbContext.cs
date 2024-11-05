﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Rendeleskezelo_app.Models;

namespace Rendeleskezelo_app.Data;

public partial class RendelesDbContext : DbContext
{
    public RendelesDbContext()
    {
    }

    public RendelesDbContext(DbContextOptions<RendelesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cim> Cim { get; set; }

    public virtual DbSet<Rendeles> Rendeles { get; set; }

    public virtual DbSet<RendelesTetel> RendelesTetel { get; set; }

    public virtual DbSet<Termek> Termek { get; set; }

    public virtual DbSet<TermekKategoria> TermekKategoria { get; set; }

    public virtual DbSet<Ugyfel> Ugyfel { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=merciszoft.database.windows.net;Initial Catalog=merciszoft;Persist Security Info=True;User ID=Hallgato;Password=Password123;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cim>(entity =>
        {
            entity.HasKey(e => e.CimId).HasName("PK__CIM__8A3BFC16E8428DCC");
        });

        modelBuilder.Entity<Rendeles>(entity =>
        {
            entity.HasKey(e => e.RendelesId).HasName("PK__RENDELES__8DBDC2AD6250D467");

            entity.Property(e => e.RendelesDatum).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.SzallitasiCim).WithMany(p => p.Rendeles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RENDELES_CIM");

            entity.HasOne(d => d.Ugyfel).WithMany(p => p.Rendeles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RENDELES_UGYFEL");
        });

        modelBuilder.Entity<RendelesTetel>(entity =>
        {
            entity.HasKey(e => e.TetelId).HasName("PK__RENDELES__18F19F74E08336B9");

            entity.HasOne(d => d.Rendeles).WithMany(p => p.RendelesTetel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RENDELES_TETEL_RENDELES");

            entity.HasOne(d => d.Termek).WithMany(p => p.RendelesTetel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RENDELES_TETEL_TERMEK");
        });

        modelBuilder.Entity<Termek>(entity =>
        {
            entity.HasKey(e => e.TermekId).HasName("PK__TERMEK__05635B297A9650B2");

            entity.HasOne(d => d.Kategoria).WithMany(p => p.Termek).HasConstraintName("FK_TERMEK_TERMEK_KATEGORIA");
        });

        modelBuilder.Entity<TermekKategoria>(entity =>
        {
            entity.HasKey(e => e.KategoriaId).HasName("PK__TERMEK_K__37D210EC6610263F");

            entity.HasOne(d => d.SzuloKategoria).WithMany(p => p.InverseSzuloKategoria).HasConstraintName("FK_TERMEK_KATEGORIA_SzuloKategoria");
        });

        modelBuilder.Entity<Ugyfel>(entity =>
        {
            entity.HasKey(e => e.UgyfelId).HasName("PK__UGYFEL__BD19A371725B70AB");

            entity.HasOne(d => d.Lakcim).WithMany(p => p.Ugyfel).HasConstraintName("FK_UGYFEL_CIM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
