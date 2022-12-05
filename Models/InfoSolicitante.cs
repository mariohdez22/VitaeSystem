using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VitaeSystem.Models;

public partial class InfoSolicitante // propiedades del modelo solicitante
{
    public int Idsolicitante { get; set; } // autoincremental

    public int Idtrabajador { get; set; } // propiedad - ID

    [StringLength(22, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Nombres { get; set; } = null!; // propiedad - no es null

    [StringLength(22, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Apellidos { get; set; } = null!; // propiedad - no es null

    [StringLength(9, MinimumLength = 8)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Celular { get; set; } = null!; // propiedad - no es null

    [StringLength(24, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Email { get; set; } = null!; // propiedad - no es null

    [StringLength(42, MinimumLength = 20)] // validacion para restringir maximos y minimos de caracteres agregados
    public string DeptoVivienda { get; set; } = null!; // propiedad - no es null

    [StringLength(22, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Objetivo { get; set; } = null!; // propiedad - no es null

    [StringLength(200, MinimumLength = 5)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Foto { get; set; } = null!; // propiedad - no es null

    public int IdestadoSolicitante { get; set; } // propiedad - ID

    public virtual Trabajador OBtrabajador { get; set; } = null!; // propiedad virtual para manejar la clase del modelo trabajador

    public virtual EstadoSolicitante OBestadoSolicitante { get; set; } = null!; // propiedad virtual para manejar la clase del modelo estado

    //------------------------------------------------------------------------------------------------------------------------

    public virtual ICollection<Destreza> Destrezas { get; } = new List<Destreza>();

    public virtual ICollection<FormacionProfecional> FormacionProfecionals { get; } = new List<FormacionProfecional>();

    public virtual ICollection<Referencia> Referencia { get; } = new List<Referencia>();
}
