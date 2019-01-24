using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mfc.Models;
using Mfc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mfc.Controllers
{
    public class FormsController : Controller
    {
        private readonly CursoService _cursoService;

        private readonly MfcContext _context;

        public FormsController(MfcContext context, CursoService cursoService)
        {
            _context = context;
            _cursoService = cursoService;

        }

        // GET: Forms
        public ActionResult Index()
        {
            return View();
        }


        // GET: Forms/Create
        public ActionResult Create()
        {
            //var cursos = _cursoService.FindAll()

            return View();
        }

        // POST: Forms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Form form)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Help()
        {
            return View();
        }
    }
}