using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class TipoTrabajador // propiedades del modelo tipo trabajador
{
    public int IdtipoTrabajador { get; set; } // autoincremental

    public string TipoTrabajador1 { get; set; } = null!; // propiedad - no es null

    //-------------------------------------------------------------------------------------------------------------------------

    public virtual ICollection<Trabajador> Trabajadors { get; } = new List<Trabajador>();
}
