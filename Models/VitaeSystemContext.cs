using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VitaeSystem.Models;

public partial class VitaeSystemContext : DbContext
{
    public VitaeSystemContext()
    {
    }

    public VitaeSystemContext(DbContextOptions<VitaeSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Destreza> Destrezas { get; set; }

    public virtual DbSet<EstadoSolicitante> EstadoSolicitantes { get; set; }

    public virtual DbSet<EstadoTrabajador> EstadoTrabajadors { get; set; }

    public virtual DbSet<FormacionProfecional> FormacionProfecionals { get; set; }

    public virtual DbSet<InfoSolicitante> InfoSolicitantes { get; set; }

    public virtual DbSet<Referencia> Referencias { get; set; }

    public virtual DbSet<TipoTrabajador> TipoTrabajadors { get; set; }

    public virtual DbSet<Trabajador> Trabajadors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Destreza>(entity =>
        {
            entity.HasKey(e => e.Iddestrezas).HasName("PK__destreza__43A0B5DD9F3E1C13");

            entity.ToTable("destrezas");

            entity.Property(e => e.Iddestrezas).HasColumnName("iddestrezas");
            entity.Property(e => e.Competencias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("competencias");
            entity.Property(e => e.Dominio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dominio");
            entity.Property(e => e.Habilidades)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("habilidades");
            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante");

            entity.HasOne(d => d.OBsolicitante).WithMany(p => p.Destrezas)
                .HasForeignKey(d => d.Idsolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__destrezas__idsol__440B1D61");
        });

        modelBuilder.Entity<EstadoSolicitante>(entity =>
        {
            entity.HasKey(e => e.IdestadoSolicitante).HasName("PK__estado_s__EB2D9A6C5A803138");

            entity.ToTable("estado_solicitante");

            entity.Property(e => e.IdestadoSolicitante).HasColumnName("idestadoSolicitante");
            entity.Property(e => e.EstadoSolicitante1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estadoSolicitante");
        });

        modelBuilder.Entity<EstadoTrabajador>(entity =>
        {
            entity.HasKey(e => e.IdestadoTrabajador).HasName("PK__estado_t__0C6EFB77E16EF02D");

            entity.ToTable("estado_trabajador");

            entity.Property(e => e.IdestadoTrabajador).HasColumnName("idestadoTrabajador");
            entity.Property(e => e.EstadoTrabajador1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estadoTrabajador");
        });

        modelBuilder.Entity<FormacionProfecional>(entity =>
        {
            entity.HasKey(e => e.Idformacion).HasName("PK__formacio__0E213017B1A1BDA4");

            entity.ToTable("formacion_profecional");

            entity.Property(e => e.Idformacion).HasColumnName("idformacion");
            entity.Property(e => e.AreaFormacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("areaFormacion");
            entity.Property(e => e.CargoOcupacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cargoOcupacion");
            entity.Property(e => e.FechaFormacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechaFormacion");
            entity.Property(e => e.FechaTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechaTrabajo");
            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante");
            entity.Property(e => e.InstitucionProcedencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("institucionProcedencia");
            entity.Property(e => e.InstitucionTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("institucionTrabajo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("titulo");

            entity.HasOne(d => d.OBsolicitante).WithMany(p => p.FormacionProfecionals)
                .HasForeignKey(d => d.Idsolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__formacion__idsol__412EB0B6");
        });

        modelBuilder.Entity<InfoSolicitante>(entity =>
        {
            entity.HasKey(e => e.Idsolicitante).HasName("PK__info_sol__AEFEBBBF5FDBAE25");

            entity.ToTable("info_solicitante");

            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.DeptoVivienda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("depto_vivienda");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Foto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("foto");
            entity.Property(e => e.IdestadoSolicitante).HasColumnName("idestadoSolicitante");
            entity.Property(e => e.Idtrabajador).HasColumnName("idtrabajador");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Objetivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("objetivo");

            entity.HasOne(d => d.OBestadoSolicitante).WithMany(p => p.InfoSolicitantes)
                .HasForeignKey(d => d.IdestadoSolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__info_soli__idest__49C3F6B7");

            entity.HasOne(d => d.OBtrabajador).WithMany(p => p.InfoSolicitantes)
                .HasForeignKey(d => d.Idtrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__info_soli__idtra__3E52440B");
        });

        modelBuilder.Entity<Referencia>(entity =>
        {
            entity.HasKey(e => e.Idreferencias).HasName("PK__referenc__2D81444D7F425BBD");

            entity.ToTable("referencias");

            entity.Property(e => e.Idreferencias).HasColumnName("idreferencias");
            entity.Property(e => e.CellRefPersonal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cellRefPersonal");
            entity.Property(e => e.CellRefTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cellRefTrabajo");
            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante");
            entity.Property(e => e.ReferentePersonal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referentePersonal");
            entity.Property(e => e.ReferenteTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenteTrabajo");

            entity.HasOne(d => d.OBsolicitante).WithMany(p => p.Referencia)
                .HasForeignKey(d => d.Idsolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__referenci__idsol__46E78A0C");
        });

        modelBuilder.Entity<TipoTrabajador>(entity =>
        {
            entity.HasKey(e => e.IdtipoTrabajador).HasName("PK__tipo_tra__F18769A59E578598");

            entity.ToTable("tipo_trabajador");

            entity.Property(e => e.IdtipoTrabajador).HasColumnName("idtipoTrabajador");
            entity.Property(e => e.TipoTrabajador1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoTrabajador");
        });

        modelBuilder.Entity<Trabajador>(entity =>
        {
            entity.HasKey(e => e.Idtrabajador).HasName("PK__trabajad__765CB46432533E1D");

            entity.ToTable("trabajador");

            entity.Property(e => e.Idtrabajador).HasColumnName("idtrabajador");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdestadoTrabajador).HasColumnName("idestadoTrabajador");
            entity.Property(e => e.IdtipoTrabajador).HasColumnName("idtipoTrabajador");
            entity.Property(e => e.Nickname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nickname");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.OBestadoTrabajador).WithMany(p => p.Trabajadors)
                .HasForeignKey(d => d.IdestadoTrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__trabajado__idest__3B75D760");

            entity.HasOne(d => d.OBtipoTrabajador).WithMany(p => p.Trabajadors)
                .HasForeignKey(d => d.IdtipoTrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__trabajado__idtip__3A81B327");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
