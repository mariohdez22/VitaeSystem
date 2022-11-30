using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class EstadoSolicitante
{
    public int IdestadoSolicitante { get; set; }

    public string EstadoSolicitante1 { get; set; } = null!;

    public virtual ICollection<InfoSolicitante> InfoSolicitantes { get; } = new List<InfoSolicitante>();
}
