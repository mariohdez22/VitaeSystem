using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class EstadoSolicitante // propiedades del modelo estado trabajador
{
    public int IdestadoSolicitante { get; set; } // autoincremental

    public string EstadoSolicitante1 { get; set; } = null!; // propiedad - no es null

    //-------------------------------------------------------------------------------------------------------------------------

    public virtual ICollection<InfoSolicitante> InfoSolicitantes { get; } = new List<InfoSolicitante>();
}
