using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class ReferenciaE
    {
        public Referencia OBreferencia { get; set; }

        public List<SelectListItem> listaSolicitante { get; set; }
    }
}
