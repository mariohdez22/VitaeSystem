using System;
using System.Collections.Generic;
#pragma warning disable

namespace VitaeSystem.Models
{
    public class ListasSolicitantes
    {

        public List<InfoSolicitante> listaSolicitantes { get; set; }

        //--------------------------------------------------------------

        public List<FormacionProfecional> listaFormaciones { get; set; }

        public FormacionProfecional ObjetoFormacion { get; set; }

        //--------------------------------------------------------------

        public List<Destreza> listaDestrezas { get; set; }

        //--------------------------------------------------------------

        public List<Referencia> listaReferencias { get; set; }

    }
}
