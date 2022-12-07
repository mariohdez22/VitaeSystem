using System;
using System.Collections.Generic;
#pragma warning disable

namespace VitaeSystem.Models
{
    public class ListasSolicitantes // objetos tipo lista de clases para vistas
    {

        public List<InfoSolicitante> listaSolicitantes { get; set; } // objeto lista de info solicitante

        //--------------------------------------------------------------

        public List<FormacionProfecional> listaFormaciones { get; set; } // objeto lista de formaciones

        //--------------------------------------------------------------

        public List<Destreza> listaDestrezas { get; set; } // objeto lista de info destrezas

        //--------------------------------------------------------------

        public List<Referencia> listaReferencias { get; set; } // objeto lista de referencias

    }
}
