using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class TipoTrabajador
{
    public int IdtipoTrabajador { get; set; }

    public string TipoTrabajador1 { get; set; } = null!;

    public virtual ICollection<Trabajador> Trabajadors { get; } = new List<Trabajador>();
}
