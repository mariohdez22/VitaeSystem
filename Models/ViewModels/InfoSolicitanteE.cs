using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class InfoSolicitanteE // clase para vista de carga de datos
    {
        public InfoSolicitante OBinfoSolicitante { get; set; } // objeto de la clase solicitantes

        public List<SelectListItem> listaTrabajador { get; set; } // propiedad lista para select de trabajadores

        public List<SelectListItem> listaEstado { get; set; } // propiedad lista para select de estado solicitantes
    }
}
