using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitaeSystem.Models.ViewModels;
using VitaeSystem.Models;
using System.Diagnostics;
#pragma warning disable 

namespace VitaeSystem.Controllers
{
    public class ReferenciasController : Controller
    {
        private readonly VitaeSystemContext _referencias;
        public ReferenciasController(VitaeSystemContext referencias)
        {
            _referencias = referencias;
        }

        public IActionResult Index(int IDsolicitante)
        {
            ListasSolicitantes referencias = new ListasSolicitantes()
            {
                listaReferencias = _referencias.Referencias.Where(x => x.Idsolicitante == IDsolicitante)
                                                           .Include(x => x.OBsolicitante)
                                                           .ToList()
            };

            return View(referencias);
        }

        [HttpGet]
        public IActionResult Referencias_Detalle(int Idreferencia)
        {

            ReferenciaE oReferenciaE = new ReferenciaE()
            {

                OBreferencia = new Referencia(),
                listaSolicitante = _referencias.InfoSolicitantes.Select(solicitante => new SelectListItem()
                {

                    Text = solicitante.Nombres,
                    Value = solicitante.Idsolicitante.ToString()

                }).ToList(),

            };

            if (Idreferencia != 0)
            {
                oReferenciaE.OBreferencia = _referencias.Referencias.Find(Idreferencia);
            }

            return View(oReferenciaE);
        }

        [HttpPost]
        public IActionResult Referencias_Detalle(ReferenciaE objetoU, int Idsolicitante)
        {
            if (objetoU.OBreferencia.Idreferencias == 0)
            {
                _referencias.Referencias.Add(objetoU.OBreferencia);
            }
            else
            {
                _referencias.Referencias.Update(objetoU.OBreferencia);
            }

            _referencias.SaveChanges();

            if (objetoU.OBreferencia.Idreferencias == 0)
            {
                return RedirectToAction("Index", "Solicitante");
            }
            else
            {
                return RedirectToAction("Index", new RouteValueDictionary(new { Controller = "Referencias", Action = "Index", IDsolicitante = Idsolicitante }));
            }

        }

        [HttpPost]
        public IActionResult Referencias_Detalle_Auto(ReferenciaE objetoU)
        {
            if (objetoU.OBreferencia.Idreferencias == 0)
            {
                _referencias.Referencias.Add(objetoU.OBreferencia);
            }
            else
            {
                _referencias.Referencias.Update(objetoU.OBreferencia);
            }

            _referencias.SaveChanges();

            return RedirectToAction("Index", "Solicitante");
        }

    }

}

