using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class TrabajadorE // clase para vista de carga de datos
    {
        public Trabajador OBtrabajador { get; set; } // objeto de la clase trabajador

        public List<SelectListItem> listaEstado { get; set; } // propiedad lista para select de estado trabajadores

        public List<SelectListItem> listaTipo { get; set; } // propiedad lista para select de tipo trabajadores
    }
}
