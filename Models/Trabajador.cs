using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VitaeSystem.Models;

public partial class Trabajador // propiedades del modelo trabajador
{
    public int Idtrabajador { get; set; } // autoincremental

    [StringLength(28, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Nombre { get; set; } = null!; // propiedad - no es null

    [StringLength(8, MinimumLength = 8)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Telefono { get; set; } = null!; // propiedad - no es null

    [StringLength(29, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Email { get; set; } = null!; // propiedad - no es null

    [StringLength(29, MinimumLength = 10)] // validacion para restringir maximos y minimos de caracteres agregados
    public string Nickname { get; set; } = null!; // propiedad - no es null

    public int IdtipoTrabajador { get; set; } // propiedad - ID

    public int IdestadoTrabajador { get; set; } // propiedad - ID

    public virtual EstadoTrabajador OBestadoTrabajador { get; set; } = null!; // propiedad virtual para manejar la clase del modelo estado

    public virtual TipoTrabajador OBtipoTrabajador { get; set; } = null!; // propiedad virtual para manejar la clase del modelo estado

    //------------------------------------------------------------------------------------------------------------------------

    public virtual ICollection<InfoSolicitante> InfoSolicitantes { get; } = new List<InfoSolicitante>();
}
