using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChatonsBDD_B31.Models;

namespace ChatonsBDD_B31.Controllers
{
    public class VaccinesController : Controller
    {
        private readonly ContexteBDD _context = new ContexteBDD();

        // GET: Vaccines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vaccine.ToListAsync());
        }

        // GET: Vaccines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccine = await _context.Vaccine
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaccine == null)
            {
                return NotFound();
            }

            return View(vaccine);
        }

        // GET: Vaccines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vaccines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,periodicity")] Vaccine vaccine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaccine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaccine);
        }

        // GET: Vaccines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccine = await _context.Vaccine.FindAsync(id);
            if (vaccine == null)
            {
                return NotFound();
            }
            return View(vaccine);
        }

        // POST: Vaccines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,periodicity")] Vaccine vaccine)
        {
            if (id != vaccine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaccine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaccineExists(vaccine.Id))
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
            return View(vaccine);
        }

        // GET: Vaccines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccine = await _context.Vaccine
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vaccine == null)
            {
                return NotFound();
            }

            return View(vaccine);
        }

        // POST: Vaccines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaccine = await _context.Vaccine.FindAsync(id);
            _context.Vaccine.Remove(vaccine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaccineExists(int id)
        {
            return _context.Vaccine.Any(e => e.Id == id);
        }
    }
}
