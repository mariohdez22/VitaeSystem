using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class Referencia
{
    public int Idreferencias { get; set; }

    public int Idsolicitante { get; set; }

    public string ReferentePersonal { get; set; } = null!;

    public string CellRefPersonal { get; set; } = null!;

    public string ReferenteTrabajo { get; set; } = null!;

    public string CellRefTrabajo { get; set; } = null!;

    public virtual InfoSolicitante OBsolicitante { get; set; } = null!;
}
