using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class TrabajadorE
    {
        public Trabajador OBtrabajador { get; set; }

        public List<SelectListItem> listaEstado { get; set; }

        public List<SelectListItem> listaTipo { get; set; }
    }
}
