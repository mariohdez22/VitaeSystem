using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VitaeSystem.Models;

public partial class VitaeSystemContext : DbContext // clase conectada a la base de datos
{ 
    public VitaeSystemContext() // constructor - sin utilidad
    {
    }

    public VitaeSystemContext(DbContextOptions<VitaeSystemContext> options) // segundo constructor para opciones
        : base(options)
    {
    }

    public virtual DbSet<Destreza> Destrezas { get; set; } // entidad virtual de destrezas

    public virtual DbSet<EstadoSolicitante> EstadoSolicitantes { get; set; } // entidad virtual de estado solicitante

    public virtual DbSet<EstadoTrabajador> EstadoTrabajadors { get; set; } // entidad virtual de estado trabajadores

    public virtual DbSet<FormacionProfecional> FormacionProfecionals { get; set; } // entidad virtual de formaciones

    public virtual DbSet<InfoSolicitante> InfoSolicitantes { get; set; } // entidad virtual de solicitantes

    public virtual DbSet<Referencia> Referencias { get; set; } // entidad virtual de referencias

    public virtual DbSet<TipoTrabajador> TipoTrabajadors { get; set; } // entidad virtual de tipo trabajadores

    public virtual DbSet<Trabajador> Trabajadors { get; set; } // entidad virtual de trabajadores

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // metodo para conexion - inutilizado
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) // metodo modificador tipo builder que contiene
    {                                                                  // todas las entidades conectadas a las tablas de
                                                                       // la base de datos de vitae system
        modelBuilder.Entity<Destreza>(entity => // entida destreza                        
        {
            entity.HasKey(e => e.Iddestrezas).HasName("PK__destreza__43A0B5DD9F3E1C13"); // llave primaria

            entity.ToTable("destrezas"); // nombre de la tabla

            entity.Property(e => e.Iddestrezas).HasColumnName("iddestrezas"); // nombre del id
            entity.Property(e => e.Competencias)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("competencias"); // valor de la tabla
            entity.Property(e => e.Dominio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dominio"); // valor de la tabla
            entity.Property(e => e.Habilidades)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("habilidades"); // valor de la tabla 
            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante"); // valor de la tabla

            entity.HasOne(d => d.OBsolicitante).WithMany(p => p.Destrezas)
                .HasForeignKey(d => d.Idsolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__destrezas__idsol__440B1D61"); // llave foranea
        });

        modelBuilder.Entity<EstadoSolicitante>(entity => // entidad estado solicitante
        {
            entity.HasKey(e => e.IdestadoSolicitante).HasName("PK__estado_s__EB2D9A6C5A803138"); // llave primaria

            entity.ToTable("estado_solicitante"); // nombre de la tabla

            entity.Property(e => e.IdestadoSolicitante).HasColumnName("idestadoSolicitante"); // id de la tabla
            entity.Property(e => e.EstadoSolicitante1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estadoSolicitante"); // valor de la tabla
        });

        modelBuilder.Entity<EstadoTrabajador>(entity => // entidad estado trabajador
        {
            entity.HasKey(e => e.IdestadoTrabajador).HasName("PK__estado_t__0C6EFB77E16EF02D"); // llave primaria

            entity.ToTable("estado_trabajador"); // nombre de la tabla

            entity.Property(e => e.IdestadoTrabajador).HasColumnName("idestadoTrabajador"); // id de la tabla
            entity.Property(e => e.EstadoTrabajador1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estadoTrabajador"); // valor de la tabla
        });

        modelBuilder.Entity<FormacionProfecional>(entity => // entidad formacion 
        {
            entity.HasKey(e => e.Idformacion).HasName("PK__formacio__0E213017B1A1BDA4"); // llave primaria

            entity.ToTable("formacion_profecional"); // nombre de la tabla

            entity.Property(e => e.Idformacion).HasColumnName("idformacion"); // id de la tabla
            entity.Property(e => e.AreaFormacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("areaFormacion"); // valor de la tabla
            entity.Property(e => e.CargoOcupacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cargoOcupacion"); // valor de la tabla
            entity.Property(e => e.FechaFormacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechaFormacion"); // valor de la tabla
            entity.Property(e => e.FechaTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechaTrabajo"); // valor de la tabla
            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante"); // valor de la tabla
            entity.Property(e => e.InstitucionProcedencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("institucionProcedencia"); // valor de la tabla
            entity.Property(e => e.InstitucionTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("institucionTrabajo"); // valor de la tabla
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("titulo"); // valor de la tabla

            entity.HasOne(d => d.OBsolicitante).WithMany(p => p.FormacionProfecionals)
                .HasForeignKey(d => d.Idsolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__formacion__idsol__412EB0B6"); // llave foranea
        });

        modelBuilder.Entity<InfoSolicitante>(entity => // entidad info solicitante
        {
            entity.HasKey(e => e.Idsolicitante).HasName("PK__info_sol__AEFEBBBF5FDBAE25"); // llave primaria

            entity.ToTable("info_solicitante"); // nombre de la tabla

            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante"); // id de la tabla
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos"); // valor de la tabla
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("celular"); // valor de la tabla
            entity.Property(e => e.DeptoVivienda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("depto_vivienda"); // valor de la tabla
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email"); // valor de la tabla
            entity.Property(e => e.Foto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("foto"); // valor de la tabla
            entity.Property(e => e.IdestadoSolicitante).HasColumnName("idestadoSolicitante"); // valor de la tabla
            entity.Property(e => e.Idtrabajador).HasColumnName("idtrabajador"); // valor de la tabla
            entity.Property(e => e.Nombres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombres"); // valor de la tabla
            entity.Property(e => e.Objetivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("objetivo"); // valor de la tabla

            entity.HasOne(d => d.OBestadoSolicitante).WithMany(p => p.InfoSolicitantes)
                .HasForeignKey(d => d.IdestadoSolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__info_soli__idest__49C3F6B7"); // llave foranea 1

            entity.HasOne(d => d.OBtrabajador).WithMany(p => p.InfoSolicitantes)
                .HasForeignKey(d => d.Idtrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__info_soli__idtra__3E52440B"); // llave foranea 2
        });

        modelBuilder.Entity<Referencia>(entity => // entidad referencia
        {
            entity.HasKey(e => e.Idreferencias).HasName("PK__referenc__2D81444D7F425BBD"); // llave primaria

            entity.ToTable("referencias"); // nombre de la tabla

            entity.Property(e => e.Idreferencias).HasColumnName("idreferencias"); // id de la tabla
            entity.Property(e => e.CellRefPersonal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cellRefPersonal"); // valor de la tabla 
            entity.Property(e => e.CellRefTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cellRefTrabajo"); // valor de la tabla 
            entity.Property(e => e.Idsolicitante).HasColumnName("idsolicitante"); // valor de la tabla 
            entity.Property(e => e.ReferentePersonal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referentePersonal"); // valor de la tabla 
            entity.Property(e => e.ReferenteTrabajo) 
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referenteTrabajo"); // valor de la tabla 

            entity.HasOne(d => d.OBsolicitante).WithMany(p => p.Referencia)
                .HasForeignKey(d => d.Idsolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__referenci__idsol__46E78A0C"); // llave foranea
        });

        modelBuilder.Entity<TipoTrabajador>(entity => // entidad tipo trabajador
        {
            entity.HasKey(e => e.IdtipoTrabajador).HasName("PK__tipo_tra__F18769A59E578598"); // llave primaria

            entity.ToTable("tipo_trabajador");

            entity.Property(e => e.IdtipoTrabajador).HasColumnName("idtipoTrabajador"); // id de la tabla
            entity.Property(e => e.TipoTrabajador1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoTrabajador"); // valor de la tabla
        });

        modelBuilder.Entity<Trabajador>(entity => // entidad trabajador
        {
            entity.HasKey(e => e.Idtrabajador).HasName("PK__trabajad__765CB46432533E1D"); // llave primaria

            entity.ToTable("trabajador"); // nombre de la tabla

            entity.Property(e => e.Idtrabajador).HasColumnName("idtrabajador"); // id de la tabla
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email"); // valor de la tabla
            entity.Property(e => e.IdestadoTrabajador).HasColumnName("idestadoTrabajador"); // valor de la tabla
            entity.Property(e => e.IdtipoTrabajador).HasColumnName("idtipoTrabajador"); // valor de la tabla
            entity.Property(e => e.Nickname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nickname"); // valor de la tabla
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false) 
                .HasColumnName("nombre"); // valor de la tabla
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono"); // valor de la tabla

            entity.HasOne(d => d.OBestadoTrabajador).WithMany(p => p.Trabajadors)
                .HasForeignKey(d => d.IdestadoTrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__trabajado__idest__3B75D760"); // llave foranea 1

            entity.HasOne(d => d.OBtipoTrabajador).WithMany(p => p.Trabajadors)
                .HasForeignKey(d => d.IdtipoTrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__trabajado__idtip__3A81B327"); // llave foranea 2
        });

        OnModelCreatingPartial(modelBuilder); // ejecucion del metodo para compilar todas las entidades
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder); // metodo builder para compilacion
}
