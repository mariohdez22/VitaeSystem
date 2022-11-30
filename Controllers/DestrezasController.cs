using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitaeSystem.Models.ViewModels;
using VitaeSystem.Models;
using System.Diagnostics;
#pragma warning disable 

namespace VitaeSystem.Controllers
{
    public class DestrezasController : Controller
    {

        private readonly VitaeSystemContext _destrezas;

        public DestrezasController(VitaeSystemContext destrezas)
        {
            _destrezas = destrezas;
        }

        public IActionResult Index(int IDsolicitante)
        {
            ListasSolicitantes destreza = new ListasSolicitantes()
            {
                listaDestrezas = _destrezas.Destrezas.Where(x => x.Idsolicitante == IDsolicitante)
                                                     .Include(x => x.OBsolicitante)
                                                     .ToList()
            };

            return View(destreza);
        }

        [HttpGet]
        public IActionResult Destrezas_Detalle(int Idestreza)
        {

            DestrezasE oDestrezaE = new DestrezasE()
            {

                OBdestreza = new Destreza(),
                listaSolicitante = _destrezas.InfoSolicitantes.Select(solicitante => new SelectListItem()
                {

                    Text = solicitante.Nombres,
                    Value = solicitante.Idsolicitante.ToString()

                }).ToList()

            };

            if (Idestreza != 0)
            {
                oDestrezaE.OBdestreza = _destrezas.Destrezas.Find(Idestreza);
            }

            return View(oDestrezaE);
        }

        [HttpPost]
        public IActionResult Destrezas_Detalle(DestrezasE objetoU, int Idsolicitante)
        {
            if (objetoU.OBdestreza.Iddestrezas == 0)
            {
                _destrezas.Destrezas.Add(objetoU.OBdestreza);
            }
            else
            {
                _destrezas.Destrezas.Update(objetoU.OBdestreza);
            }

            _destrezas.SaveChanges();

            if (objetoU.OBdestreza.Iddestrezas == 0)
            {
                return RedirectToAction("Index", "Solicitante");
            }
            else
            {
                return RedirectToAction("Index", new RouteValueDictionary(new { Controller = "Destrezas", Action = "Index", IDsolicitante = Idsolicitante }));
            }
                
        }

    }
}
