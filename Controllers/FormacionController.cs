using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitaeSystem.Models.ViewModels;
using VitaeSystem.Models;
using System.Diagnostics;
#pragma warning disable 

namespace VitaeSystem.Controllers
{
    public class FormacionController : Controller
    {
        private readonly VitaeSystemContext _formaciones;

        public FormacionController(VitaeSystemContext formaciones)
        {
            _formaciones = formaciones;
        }

        public IActionResult Index(int IDsolicitante)
        {
            ListasSolicitantes formacion = new ListasSolicitantes()
            {
                listaFormaciones = _formaciones.FormacionProfecionals.Where(x => x.Idsolicitante == IDsolicitante)
                                                                     .Include(x => x.OBsolicitante)
                                                                     .ToList()
            };

            return View(formacion);
        }

        [HttpGet]
        public IActionResult Formacion_Detalle(int Idformacion)
        {

            FormacionProfecionalE oFormacionE = new FormacionProfecionalE()
            {

                OBformacionProfecional = new FormacionProfecional(),
                listaSolicitante = _formaciones.InfoSolicitantes.Select(solicitante => new SelectListItem()
                {

                    Text = solicitante.Nombres,
                    Value = solicitante.Idsolicitante.ToString()

                }).ToList(),

            };

            if (Idformacion != 0)
            {
                oFormacionE.OBformacionProfecional = _formaciones.FormacionProfecionals.Find(Idformacion);
            }

            return View(oFormacionE);
        }

        [HttpPost]
        public IActionResult Formacion_Detalle(FormacionProfecionalE objetoU, int Idsolicitante)
        {
            if (objetoU.OBformacionProfecional.Idformacion == 0)
            {
                _formaciones.FormacionProfecionals.Add(objetoU.OBformacionProfecional);
            }
            else
            {
                _formaciones.FormacionProfecionals.Update(objetoU.OBformacionProfecional);
            }

            _formaciones.SaveChanges();

            if (objetoU.OBformacionProfecional.Idformacion == 0)
            {
                return RedirectToAction("Index", "Solicitante");
            }
            else
            {
                return RedirectToAction("Index", new RouteValueDictionary(new { Controller = "Formacion", Action = "Index", IDsolicitante = Idsolicitante }));
            }
                
        }

        [HttpGet]
        public IActionResult Formaciones(int Idformacion)
        {

            FormacionProfecionalE oFormacionE = new FormacionProfecionalE()
            {

                OBformacionProfecional = new FormacionProfecional(),
                listaSolicitante = _formaciones.InfoSolicitantes.Select(solicitante => new SelectListItem()
                {

                    Text = solicitante.Nombres,
                    Value = solicitante.Idsolicitante.ToString()

                }).ToList(),

            };

            if (Idformacion != 0)
            {
                oFormacionE.OBformacionProfecional = _formaciones.FormacionProfecionals.Find(Idformacion);
            }

            return View(oFormacionE);
        }

        [HttpPost]
        public IActionResult Formaciones(FormacionProfecionalE objetoU, int Idsolicitante)
        {
            if (objetoU.OBformacionProfecional.Idformacion == 0)
            {
                _formaciones.FormacionProfecionals.Add(objetoU.OBformacionProfecional);
            }
            else
            {
                _formaciones.FormacionProfecionals.Update(objetoU.OBformacionProfecional);
            }

            _formaciones.SaveChanges();

            if (objetoU.OBformacionProfecional.Idformacion == 0)
            {
                return RedirectToAction("Index", "Solicitante");
            }
            else
            {
                return RedirectToAction("Index", new RouteValueDictionary(new { Controller = "Formacion", Action = "Index", IDsolicitante = Idsolicitante }));
            }
        }

        [HttpGet]
        public IActionResult Eliminar(int Idformacion)
        {
            FormacionProfecional obFormacion = _formaciones.FormacionProfecionals.Include(x => x.OBsolicitante)
                                                                                 .Where(x => x.Idformacion == Idformacion)
                                                                                 .FirstOrDefault();
            return View(obFormacion);
        }

        [HttpPost]
        public IActionResult Eliminar(FormacionProfecional objetoU)
        {

            if (objetoU.Idformacion == 0)
                _formaciones.FormacionProfecionals.Remove(objetoU);

            _formaciones.SaveChanges();

            return View(objetoU);
        }

    }
}
