using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class FormacionProfecional
{
    public int Idformacion { get; set; }

    public int Idsolicitante { get; set; }

    public string Titulo { get; set; } = null!;

    public string InstitucionProcedencia { get; set; } = null!;

    public string FechaFormacion { get; set; } = null!;

    public string AreaFormacion { get; set; } = null!;

    public string CargoOcupacion { get; set; } = null!;

    public string InstitucionTrabajo { get; set; } = null!;

    public string FechaTrabajo { get; set; } = null!;

    public virtual InfoSolicitante OBsolicitante { get; set; } = null!;
}
