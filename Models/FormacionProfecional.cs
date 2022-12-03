using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VitaeSystem.Models;

public partial class FormacionProfecional // propiedades del modelo formacion
{
    public int Idformacion { get; set; } // autoincremental

    public int Idsolicitante { get; set; } // propiedad - ID

    [StringLength(42, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Titulo { get; set; } = null!; // propiedad - no es null

    [StringLength(42, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string InstitucionProcedencia { get; set; } = null!; // propiedad - no es null

    [StringLength(11, MinimumLength = 11)] // validacion para restringir maximos y minimos de caracteres agregados
    public string FechaFormacion { get; set; } = null!; // propiedad - no es null

    [StringLength(42, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string AreaFormacion { get; set; } = null!; // propiedad - no es null

    [StringLength(42, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string CargoOcupacion { get; set; } = null!; // propiedad - no es null

    [StringLength(42, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string InstitucionTrabajo { get; set; } = null!; // propiedad - no es null

    [StringLength(11, MinimumLength = 11)] // validacion para restringir maximos y minimos de caracteres agregados
    public string FechaTrabajo { get; set; } = null!; // propiedad - no es null

    public virtual InfoSolicitante OBsolicitante { get; set; } = null!; // propiedad virtual para manejar la clase del modelo estado
}
