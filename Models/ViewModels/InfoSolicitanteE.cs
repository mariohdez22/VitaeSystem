using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class InfoSolicitanteE
    {
        public InfoSolicitante OBinfoSolicitante { get; set; }  

        public List<SelectListItem> listaTrabajador { get; set; } 

        public List<SelectListItem> listaEstado { get; set; } 
    }
}
