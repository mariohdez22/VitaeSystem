using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class EstadoTrabajador // propiedades del modelo estado trabajador
{
    public int IdestadoTrabajador { get; set; } // autoincremental

    public string EstadoTrabajador1 { get; set; } = null!; // propiedad - no es null

    //-------------------------------------------------------------------------------------------------------------------------

    public virtual ICollection<Trabajador> Trabajadors { get; } = new List<Trabajador>();
}
