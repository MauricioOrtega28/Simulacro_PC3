using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro_PC3.Models;
using Simulacro_PC3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Simulacro_PC3.Controllers
{
    public class SolicitudController: Controller
    {
        private readonly ApplicationDbContext _context;

        public SolicitudController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Registro(){

            var Categorias = _context.DataCategorias.ToList();
            
             List<SelectListItem> items = Categorias.ConvertAll(d => {
                return new SelectListItem(){
                    Text = d.Nombre,
                    Value = d.Id.ToString(),
                    Selected = false
                };
            });
          
           ViewBag.items = items;

           return View();
        }

        [HttpPost]
        public IActionResult Registro(Solicitud solicitud, int datos){
            
            if(ModelState.IsValid){
                
                var categoria = _context.DataCategorias.Find(datos);
                solicitud.categoria = categoria;
                _context.Add(solicitud);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(solicitud);
        }

        public IActionResult Listar(){

            var solicitudes = _context.DataContactos.ToList();

            return View(solicitudes);

        }

    }
}