using System;
using System.Collections.Generic;

namespace VitaeSystem.Models;

public partial class InfoSolicitante
{
    public int Idsolicitante { get; set; } // ya

    public int Idtrabajador { get; set; } // ya

    public string Nombres { get; set; } = null!; // ya

    public string Apellidos { get; set; } = null!; // ya

    public string Celular { get; set; } = null!; // ya

    public string Email { get; set; } = null!; // ya

    public string DeptoVivienda { get; set; } = null!; // ya

    public string Objetivo { get; set; } = null!; // ya

    public string Foto { get; set; } = null!; // ya

    public int IdestadoSolicitante { get; set; } // ya

    public virtual Trabajador OBtrabajador { get; set; } = null!;

    public virtual EstadoSolicitante OBestadoSolicitante { get; set; } = null!;

//------------------------------------------------------------------------------------------------------------------------

    public virtual ICollection<Destreza> Destrezas { get; } = new List<Destreza>();

    public virtual ICollection<FormacionProfecional> FormacionProfecionals { get; } = new List<FormacionProfecional>();

    public virtual ICollection<Referencia> Referencia { get; } = new List<Referencia>();
}
