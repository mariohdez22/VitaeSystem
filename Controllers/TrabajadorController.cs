using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitaeSystem.Models.ViewModels;
using VitaeSystem.Models;
using System.Diagnostics;
using Rotativa.AspNetCore;
#pragma warning disable 

namespace VitaeSystem.Controllers
{
    public class TrabajadorController : Controller
    {

        private readonly VitaeSystemContext _trabajadores;

        public TrabajadorController(VitaeSystemContext trabajadores)
        {
            _trabajadores = trabajadores;
        }

        public IActionResult Index(string buscar)
        {
            List<Trabajador> trabajadors = _trabajadores.Trabajadors.Include(x => x.OBestadoTrabajador)
                                                                    .Include(x => x.OBtipoTrabajador)
                                                                    .ToList();

            if (!String.IsNullOrEmpty(buscar))
            {
                trabajadors = _trabajadores.Trabajadors.Where( 
                    
                               b => b.Nombre!.Contains(buscar)   || 
                                    b.Nickname!.Contains(buscar) || 
                                    b.Telefono!.Contains(buscar) ||
                                    b.OBestadoTrabajador.EstadoTrabajador1!.Contains(buscar) ||
                                    b.Email!.Contains(buscar) ||
                                    b.OBtipoTrabajador.TipoTrabajador1!.Contains(buscar)

                               ).ToList();
            }

            return View(trabajadors);
        }

        [HttpGet]
        public IActionResult Trabajador_Detalle(int Idtrabajador)
        {
            TrabajadorE oTrabajadorE = new TrabajadorE()
            {

                OBtrabajador = new Trabajador(),
                listaEstado = _trabajadores.EstadoTrabajadors.Select(estado => new SelectListItem()
                {

                    Text = estado.EstadoTrabajador1,
                    Value = estado.IdestadoTrabajador.ToString()

                }).ToList(),
                listaTipo = _trabajadores.TipoTrabajadors.Select(tipo => new SelectListItem()
                {

                    Text = tipo.TipoTrabajador1,
                    Value = tipo.IdtipoTrabajador.ToString()

                }).ToList()

            };

            if (Idtrabajador != 0)
            {
                oTrabajadorE.OBtrabajador = _trabajadores.Trabajadors.Find(Idtrabajador);
            }

            return View(oTrabajadorE);

        }

        [HttpPost]
        public IActionResult Trabajador_Detalle(TrabajadorE objetoU)
        {
            if (objetoU.OBtrabajador.Idtrabajador == 0)
            {
                _trabajadores.Trabajadors.Add(objetoU.OBtrabajador);
            }
            else
            {
                _trabajadores.Trabajadors.Update(objetoU.OBtrabajador);
            }

            _trabajadores.SaveChanges();

            return RedirectToAction("Index", "Trabajador");
        }

        [HttpGet]
        public IActionResult Eliminar(int Idtrabajador)
        {
            Trabajador obTrabajador = _trabajadores.Trabajadors.Include(x => x.OBestadoTrabajador)
                                                               .Where(x => x.Idtrabajador == Idtrabajador)
                                                               .Include(x => x.OBtipoTrabajador)
                                                               .Where(x => x.Idtrabajador == Idtrabajador)
                                                               .FirstOrDefault();
            return View(obTrabajador);
        }

        [HttpPost]
        public IActionResult Eliminar(Trabajador objetoU)
        {

            if (objetoU.Idtrabajador == 0)
                _trabajadores.Trabajadors.Remove(objetoU);

            _trabajadores.SaveChanges();

            return View(objetoU);
        }
        // metodos para la creacion de reportes

        public IActionResult ReporteCurriculum()
        {
            List<ModeloTrabajadorcs> modelo = _trabajadores.Trabajadors.Select
            (t => new ModeloTrabajadorcs()
            {
                Nombre = t.Nombre,
                Telefono = t.Telefono,
                Email = t.Email,
                Nickname = t.Nickname
            }).ToList();

            return new ViewAsPdf("ReporteCurriculum", modelo)
             {
                 FileName = $"Trabajadores.pdf",
                 PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                 PageSize = Rotativa.AspNetCore.Options.Size.A4
             };
        }
  
     }
    
    
}
