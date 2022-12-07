using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitaeSystem.Models.ViewModels;
using VitaeSystem.Models;
using System.Diagnostics;
#pragma warning disable 

namespace VitaeSystem.Controllers
{
    public class SolicitanteController : Controller
    {
        private readonly VitaeSystemContext _solicitantes;
        
        public SolicitanteController(VitaeSystemContext solicitantes)
        {
            _solicitantes = solicitantes;
        }

        public IActionResult Index(string buscar)
        {
            List<InfoSolicitante> solicitante = _solicitantes.InfoSolicitantes.Where(x => x.IdestadoSolicitante == 1)
                                                                              .Include(x => x.OBtrabajador)
                                                                              .Include(x => x.OBestadoSolicitante)
                                                                              .ToList();

            if (!String.IsNullOrEmpty(buscar))
            {
                solicitante = _solicitantes.InfoSolicitantes.Where(x => x.IdestadoSolicitante == 1)
                              .Where( b => b.OBtrabajador.Nickname!.Contains(buscar) ||
                                           b.Nombres!.Contains(buscar) ||
                                           b.Apellidos!.Contains(buscar) ||
                                           b.Celular!.Contains(buscar) ||
                                           b.Email!.Contains(buscar) ||
                                           b.DeptoVivienda!.Contains(buscar) ||
                                           b.Objetivo!.Contains(buscar)
                                           ).ToList();
            }

            return View(solicitante);
        }

        [HttpGet]
        public IActionResult Solicitante_Detalle(int Idsolicitante) 
        {

            InfoSolicitanteE oSolicitanteE = new InfoSolicitanteE()
            {

                OBinfoSolicitante = new InfoSolicitante(),
                listaTrabajador = _solicitantes.Trabajadors.Select(trabajador => new SelectListItem()
                {
                    
                    Text = trabajador.Nickname,
                    Value = trabajador.Idtrabajador.ToString()

                }).ToList(),
                listaEstado = _solicitantes.EstadoSolicitantes.Select(estado => new SelectListItem()
                {

                    Text = estado.EstadoSolicitante1,
                    Value = estado.IdestadoSolicitante.ToString()

                }).ToList(),

            };

            if (Idsolicitante != 0)
            {
                oSolicitanteE.OBinfoSolicitante = _solicitantes.InfoSolicitantes.Find(Idsolicitante);
            }

            return View(oSolicitanteE);
        }

        [HttpPost]
        public IActionResult Solicitante_Detalle(InfoSolicitanteE objetoU)
        {
            if (objetoU.OBinfoSolicitante.Idsolicitante == 0)
            {
                _solicitantes.InfoSolicitantes.Add(objetoU.OBinfoSolicitante);
            }
            else
            {
                _solicitantes.InfoSolicitantes.Update(objetoU.OBinfoSolicitante);
            }

            _solicitantes.SaveChanges();

            return RedirectToAction("Index", "Solicitante");
        }

        /*------------------------------------------------------------------------------------------------------*/
        // metodos para los solicitantes aceptados
        public IActionResult Aceptados(string buscar)
        {
            List<InfoSolicitante> solicitante = _solicitantes.InfoSolicitantes.Where(x => x.IdestadoSolicitante == 2)
                                                                              .Include(x => x.OBtrabajador)
                                                                              .Include(x => x.OBestadoSolicitante)
                                                                              .ToList();

            if (!String.IsNullOrEmpty(buscar))
            {
                solicitante = _solicitantes.InfoSolicitantes.Where(x => x.IdestadoSolicitante == 2)
                              .Where( b => b.OBtrabajador.Nombre!.Contains(buscar) ||
                                      b.Nombres!.Contains(buscar) ||
                                      b.Apellidos!.Contains(buscar) ||
                                      b.Celular!.Contains(buscar) ||
                                      b.Email!.Contains(buscar) ||
                                      b.DeptoVivienda!.Contains(buscar) ||
                                      b.Objetivo!.Contains(buscar)
                                      ).ToList();
            }

            return View(solicitante);
        }

        [HttpGet]
        public IActionResult Solicitante_Aceptado(int Idsolicitante)
        {

            InfoSolicitanteE oSolicitanteE = new InfoSolicitanteE()
            {

                OBinfoSolicitante = new InfoSolicitante(),
                listaTrabajador = _solicitantes.Trabajadors.Select(trabajador => new SelectListItem()
                {

                    Text = trabajador.Nickname,
                    Value = trabajador.Idtrabajador.ToString()

                }).ToList(),
                listaEstado = _solicitantes.EstadoSolicitantes.Select(estado => new SelectListItem()
                {

                    Text = estado.EstadoSolicitante1,
                    Value = estado.IdestadoSolicitante.ToString()

                }).ToList(),

            };

            if (Idsolicitante != 0)
            {
                oSolicitanteE.OBinfoSolicitante = _solicitantes.InfoSolicitantes.Find(Idsolicitante);
            }

            return View(oSolicitanteE);
        }

        [HttpPost]
        public IActionResult Solicitante_Aceptado(InfoSolicitanteE objetoU)
        {
            if (objetoU.OBinfoSolicitante.Idsolicitante == 0)
            {
                _solicitantes.InfoSolicitantes.Add(objetoU.OBinfoSolicitante);
            }
            else
            {
                _solicitantes.InfoSolicitantes.Update(objetoU.OBinfoSolicitante);
            }

            _solicitantes.SaveChanges();

            return RedirectToAction("Aceptados", "Solicitante");
        }

        /*------------------------------------------------------------------------------------------------------*/
        // metodos para los solicitantes rechazados

        public IActionResult Rechazados(string buscar)
        {
            List<InfoSolicitante> solicitante = _solicitantes.InfoSolicitantes.Where(x => x.IdestadoSolicitante == 3)
                                                                              .Include(x => x.OBtrabajador)
                                                                              .Include(x => x.OBestadoSolicitante)
                                                                              .ToList();

            if (!String.IsNullOrEmpty(buscar))
            {
                solicitante = _solicitantes.InfoSolicitantes.Where(x => x.IdestadoSolicitante == 3)
                              .Where( b => b.OBtrabajador.Nombre!.Contains(buscar) ||
                                      b.Nombres!.Contains(buscar) ||
                                      b.Apellidos!.Contains(buscar) ||
                                      b.Celular!.Contains(buscar) ||
                                      b.Email!.Contains(buscar) ||
                                      b.DeptoVivienda!.Contains(buscar) ||
                                      b.Objetivo!.Contains(buscar)
                                      ).ToList();
            }

            return View(solicitante);
        }

        [HttpGet]
        public IActionResult Solicitante_Rechazado(int Idsolicitante)
        {

            InfoSolicitanteE oSolicitanteE = new InfoSolicitanteE()
            {

                OBinfoSolicitante = new InfoSolicitante(),
                listaTrabajador = _solicitantes.Trabajadors.Select(trabajador => new SelectListItem()
                {

                    Text = trabajador.Nickname,
                    Value = trabajador.Idtrabajador.ToString()

                }).ToList(),
                listaEstado = _solicitantes.EstadoSolicitantes.Select(estado => new SelectListItem()
                {

                    Text = estado.EstadoSolicitante1,
                    Value = estado.IdestadoSolicitante.ToString()

                }).ToList(),

            };

            if (Idsolicitante != 0)
            {
                oSolicitanteE.OBinfoSolicitante = _solicitantes.InfoSolicitantes.Find(Idsolicitante);
            }

            return View(oSolicitanteE);
        }

        [HttpPost]
        public IActionResult Solicitante_Rechazado(InfoSolicitanteE objetoU)
        {
            if (objetoU.OBinfoSolicitante.Idsolicitante == 0)
            {
                _solicitantes.InfoSolicitantes.Add(objetoU.OBinfoSolicitante);
            }
            else
            {
                _solicitantes.InfoSolicitantes.Update(objetoU.OBinfoSolicitante);
            }

            _solicitantes.SaveChanges();

            return RedirectToAction("Rechazados", "Solicitante");
        }

    }
}












/*
 
        [HttpGet]
        public IActionResult Eliminar(int Idsolicitante)
        {
            InfoSolicitante obSolicitante = _solicitantes.InfoSolicitantes.Include(x => x.OBtrabajador)
                                                                          .Where(x => x.Idsolicitante == Idsolicitante)
                                                                          .Include(x => x.OBestadoSolicitante)
                                                                          .Where(x => x.Idsolicitante == Idsolicitante)
                                                                          .FirstOrDefault();
            return View(obSolicitante);
        }

        [HttpPost]
        public IActionResult Eliminar(InfoSolicitante objetoU)
        {

            if (objetoU.Idsolicitante == 0)
                _solicitantes.InfoSolicitantes.Remove(objetoU);

            _solicitantes.SaveChanges();

            return View(objetoU);
        } 

 */