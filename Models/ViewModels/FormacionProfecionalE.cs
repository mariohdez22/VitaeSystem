using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class FormacionProfecionalE // clase para vista de carga de datos
    {
        public FormacionProfecional OBformacionProfecional { get; set; } // objeto de la clase formacion

        public List<SelectListItem> listaSolicitante { get; set; } // propiedad lista para select de solicitantes

    }
}
