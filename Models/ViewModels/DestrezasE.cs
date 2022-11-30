using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class DestrezasE
    {
        public Destreza OBdestreza { get; set; }

        public List<SelectListItem> listaSolicitante { get; set; }
    }
}
