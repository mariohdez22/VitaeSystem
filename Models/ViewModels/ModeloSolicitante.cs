using System.ComponentModel.DataAnnotations;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class ModeloSolicitante
    {
        public string Nombres { get; set; } // propiedad

        public string Apellidos { get; set; } // propiedad

        public string Celular { get; set; } // propiedad

        public string Email { get; set; } // propiedad

        public string DeptoVivienda { get; set; } // propiedad

        public string Objetivo { get; set; } // propiedad

        public string Foto { get; set; } // propiedad

        public List<ModeloFormacion> formaciones { get; set; }

        public List<ModeloDestrezas> destrezas { get; set; }

        public List<ModeloReferencias> referencias { get; set; }

    }
}
