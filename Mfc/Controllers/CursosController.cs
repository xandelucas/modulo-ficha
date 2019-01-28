using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mfc.Models;
using Mfc.Models.ViewModels;
using Mfc.Services;

namespace Mfc.Controllers
{
    public class CursosController : Controller
    {
        private readonly TrabalhoService _trabalhoService;

        private readonly CursoService _cursoService;

        private readonly MfcContext _context;

        public CursosController(MfcContext context, TrabalhoService trabalhoService, CursoService cursoService)
        {
            _context = context;
            _trabalhoService = trabalhoService;
            _cursoService = cursoService;
        }

        // GET: Cursos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Curso.ToListAsync());
        }

        // GET: Cursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursos = await _context.Curso
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursos == null)
            {
                return NotFound();
            }

            return View(cursos);
        }

        // GET: Cursos/Create
        public async Task<IActionResult> CreateAsync()
        {
            var trabalhos = await _trabalhoService.FindAllSync();
            var viewModel = new CursosViewModel { Trabalhos = trabalhos };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(Curso curso)
        {
            await _cursoService.InsertAsync(curso);
            return  RedirectToAction(nameof(Index));
        }

        // GET: Cursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursos = await _context.Curso.FindAsync(id);
            if (cursos == null)
            {
                return NotFound();
            }
            return View(cursos);
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCurso,Descricao,Trabalho")] Curso cursos)
        {
            if (id != cursos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cursos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursosExists(cursos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cursos);
        }

        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursos = await _context.Curso
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursos == null)
            {
                return NotFound();
            }

            return View(cursos);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cursos = await _context.Curso.FindAsync(id);
            _context.Curso.Remove(cursos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursosExists(int id)
        {
            return _context.Curso.Any(e => e.Id == id);
        }
    }
}
