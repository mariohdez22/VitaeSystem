using Microsoft.AspNetCore.Mvc.Rendering;
#pragma warning disable 

namespace VitaeSystem.Models.ViewModels
{
    public class FormacionProfecionalE
    {

        public FormacionProfecional OBformacionProfecional { get; set; }

        public List<SelectListItem> listaSolicitante { get; set; }

    }
}
