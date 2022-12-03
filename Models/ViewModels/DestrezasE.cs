using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class DestrezasE // clase para vista de carga de datos
    {
        public Destreza OBdestreza { get; set; } // objeto de la clase destreza

        public List<SelectListItem> listaSolicitante { get; set; } // propiedad lista para select de solicitantes
    }
}
