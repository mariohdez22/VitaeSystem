using System.ComponentModel.DataAnnotations;

namespace VitaeSystem.Models.ViewModels
{
    public class ModeloFormacion
    {
        public string Titulo { get; set; } // propiedad

        public string InstitucionProcedencia { get; set; } // propiedad

        public string FechaFormacion { get; set; } // propiedad

        public string AreaFormacion { get; set; } // propiedad

        public string CargoOcupacion { get; set; } // propiedad

        public string InstitucionTrabajo { get; set; } // propiedad

        public string FechaTrabajo { get; set; } // propiedad
    }
}
