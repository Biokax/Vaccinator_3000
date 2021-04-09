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
    public class InjectionsController : Controller
    {
        /*private readonly ContexteBDD _context = new ContexteBDD();

        // GET: Injections
        public async Task<IActionResult> Index()
        {
            return View(await _context.Injection
                .Include(injection => injection.user)
                .Include(injection => injection.vaccine)
                .ToListAsync());
        }

        // GET: Injections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injection
                .Include(injection => injection.user)
                .Include(injection => injection.vaccine)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (injection == null)
            {
                return NotFound();
            }
           
            return View(injection);
        }

        // GET: Injections/Create
        /*public IActionResult AddInjection()
        {
            ViewData["users"] = new SelectList(_context.User, "Id", dataTextField: "firstName", "lastName", dataGroupField: "category");
            ViewData["vaccines"] = new SelectList(_context.Vaccine, "Id", "name");
            return View();
        }*/

        // POST: Injections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,date,recall,brand,lot")] Injection injection, int User, int Vaccine)
        {
            var user = await _context.User.FindAsync(User);
            var vaccine = await _context.Vaccine.FindAsync(Vaccine);

            injection.user = user;
            injection.vaccine = vaccine;

            ModelState.Clear();
            TryValidateModel(injection);

            if (ModelState.IsValid)
            {
                _context.Add(injection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["users"] = new SelectList(_context.User, "Id", "firstName", "lastName");
            ViewData["vaccines"] = new SelectList(_context.Vaccine, "Id", "name");

            return View(injection);
        }

        // GET: Injections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injection.FirstOrDefaultAsync(m => m.Id == id);
            if (injection == null)
            {
                return NotFound();
            }
            return View(injection);
        }

        // POST: Injections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,date,recall,brand,lot")] Injection injection)
        {
            if (id != injection.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(injection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InjectionExists(injection.Id))
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
            return View(injection);
        }

        // GET: Injections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var injection = await _context.Injection
                .Include(injection => injection.user)
                .Include(injection => injection.vaccine)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (injection == null)
            {
                return NotFound();
            }

            return View(injection);
        }

        // POST: Injections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var injection = await _context.Injection.FindAsync(id);
            _context.Injection.Remove(injection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InjectionExists(int id)
        {
            return _context.Injection.Any(e => e.Id == id);
        }*/
    }
}
