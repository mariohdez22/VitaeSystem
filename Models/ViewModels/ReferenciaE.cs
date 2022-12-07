using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class ReferenciaE // clase para vista de carga de datos
    {
        public Referencia OBreferencia { get; set; } // objeto de la clase referencias

        public List<SelectListItem> listaSolicitante { get; set; } // propiedad lista para select de solicitantes
    }
}
