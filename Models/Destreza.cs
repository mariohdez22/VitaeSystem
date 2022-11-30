using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class Destreza
{
    public int Iddestrezas { get; set; }

    public int Idsolicitante { get; set; }

    public string Habilidades { get; set; } = null!;

    public string Competencias { get; set; } = null!;

    public string Dominio { get; set; } = null!;

    public virtual InfoSolicitante OBsolicitante { get; set; } = null!;
}
