using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class EstadoTrabajador
{
    public int IdestadoTrabajador { get; set; }

    public string EstadoTrabajador1 { get; set; } = null!;

    public virtual ICollection<Trabajador> Trabajadors { get; } = new List<Trabajador>();
}
