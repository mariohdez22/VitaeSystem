using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VitaeSystem.Models;

public partial class Destreza // propiedades del modelo destrezas
{
    public int Iddestrezas { get; set; } // autoincremental

    public int Idsolicitante { get; set; } // propiedad - ID

    [StringLength(57, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Habilidades { get; set; } = null!; // propiedad - no es null

    [StringLength(57, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Competencias { get; set; } = null!; // propiedad - no es null

    [StringLength(22, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Dominio { get; set; } = null!; // propiedad - no es null

    public virtual InfoSolicitante OBsolicitante { get; set; } = null!; // propiedad virtual para manejar la clase del modelo estado
}
