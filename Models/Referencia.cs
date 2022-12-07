using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VitaeSystem.Models;

public partial class Referencia // propiedades del modelo referencias
{
    public int Idreferencias { get; set; } // autoincremental

    public int Idsolicitante { get; set; } // propiedad - ID

    [StringLength(22, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string ReferentePersonal { get; set; } = null!; // propiedad - no es null

    [StringLength(9, MinimumLength = 8)] // validacion para restringir maximos y minimos de caracteres agregados
    public string CellRefPersonal { get; set; } = null!; // propiedad - no es null

    [StringLength(22, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string ReferenteTrabajo { get; set; } = null!; // propiedad - no es null

    [StringLength(9, MinimumLength = 8)] // validacion para restringir maximos y minimos de caracteres agregados
    public string CellRefTrabajo { get; set; } = null!; // propiedad - no es null

    public virtual InfoSolicitante OBsolicitante { get; set; } = null!; // propiedad virtual para manejar la clase del modelo estad
}
