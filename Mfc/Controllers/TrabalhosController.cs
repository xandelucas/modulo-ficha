using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mfc.Models;

namespace Mfc.Controllers
{
    public class TrabalhosController : Controller
    {
        private readonly MfcContext _context;

        public TrabalhosController(MfcContext context)
        {
            _context = context;
        }

        // GET: Trabalhos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trabalho.ToListAsync());
        }

        // GET: Trabalhos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabalho = await _context.Trabalho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trabalho == null)
            {
                return NotFound();
            }

            return View(trabalho);
        }

        // GET: Trabalhos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trabalhos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeTrabalho")] Trabalho trabalho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trabalho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trabalho);
        }

        // GET: Trabalhos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabalho = await _context.Trabalho.FindAsync(id);
            if (trabalho == null)
            {
                return NotFound();
            }
            return View(trabalho);
        }

        // POST: Trabalhos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeTrabalho")] Trabalho trabalho)
        {
            if (id != trabalho.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trabalho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrabalhoExists(trabalho.Id))
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
            return View(trabalho);
        }

        // GET: Trabalhos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trabalho = await _context.Trabalho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trabalho == null)
            {
                return NotFound();
            }

            return View(trabalho);
        }

        // POST: Trabalhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trabalho = await _context.Trabalho.FindAsync(id);
            _context.Trabalho.Remove(trabalho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrabalhoExists(int id)
        {
            return _context.Trabalho.Any(e => e.Id == id);
        }
    }
}
