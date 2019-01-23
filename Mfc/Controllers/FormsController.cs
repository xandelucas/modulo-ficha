using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mfc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mfc.Controllers
{
    public class FormsController : Controller
    {


        // GET: Forms
        public ActionResult Index()
        {
            return View();
        }


        // GET: Forms/Create
        public ActionResult Create()
        {
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