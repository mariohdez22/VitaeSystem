using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class Trabajador
{
    public int Idtrabajador { get; set; }

    public string Nombre { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public int IdtipoTrabajador { get; set; }

    public int IdestadoTrabajador { get; set; }

    public virtual EstadoTrabajador OBestadoTrabajador { get; set; } = null!;

    public virtual TipoTrabajador OBtipoTrabajador { get; set; } = null!;

    public virtual ICollection<InfoSolicitante> InfoSolicitantes { get; } = new List<InfoSolicitante>();
}
