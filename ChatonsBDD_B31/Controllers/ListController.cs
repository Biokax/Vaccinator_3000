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
    public class ListController : Controller
    {
        private readonly ContexteBDD _context = new ContexteBDD();

        // GET: Index
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: ListeGrippe
        public async Task<IActionResult> ListeGrippe()
        {

            DateTime past = DateTime.Now.AddYears(-1);

            // Retrieve users that are vaccinated from the 'Grippe'
            var injections = _context.Injection
                .Include(i => i.vaccine)
                .Include(i => i.user)
                .Where(i => i.vaccine.name.Equals("Grippe") && i.date >= past)
                .ToList();

            var users = _context.User.ToList();

            for (int i = 0; i < injections.Count(); i++)
            {
                Injection actualInjection = injections[i];
                User userFound = users.Find(x => x.Id.Equals(actualInjection.user.Id));
                // If we found a vaccinated user, we remove him
                if (userFound != null)
                {
                    users.Remove(userFound);
                }
            }
            return View(users);
        }

        // GET: ListeCovid
        public async Task<IActionResult> ListeCovid()
        {
            var injections = _context.Injection
                .Include(i => i.vaccine)
                .Include(i => i.user)
                .Where(i => i.vaccine.name.Equals("Covid"))
                .ToList();


            List<Injection> lastInjections = new List<Injection>();

            // Filter to get only the latest injection if it exist
            for (int i = 0; i < injections.Count(); i++)
            {
                Injection actualInjection = injections[i];
                Injection injectionFound = lastInjections.Find(x => x.user.Id.Equals(actualInjection.user.Id) && x.vaccine.Id.Equals(actualInjection.vaccine.Id));
                // If we found an existing injection
                if (injectionFound != null)
                {
                    // If it's a later one, change it
                    if (actualInjection.recall > injectionFound.recall)
                    {
                        lastInjections.Remove(injectionFound);
                        lastInjections.Add(actualInjection);
                    }
                    //Else do nothing
                }
                else // Else if we found no existing injection, add it
                {
                    lastInjections.Add(actualInjection);
                }
            }
            return View(lastInjections);
        }

        // GET: ListeRetard
        public async Task<IActionResult> ListeRetard()
        {

            var injections = _context.Injection
                .Include(i => i.vaccine)
                .Include(i => i.user)
                .ToList();

            List<Injection> lastInjections = new List<Injection>();

            // Filter to get only the last injection for each vaccine
            for (int i = 0; i < injections.Count(); i++)
            {
                Injection actualInjection = injections[i];
                Injection injectionFound = lastInjections.Find(x => x.user.Id.Equals(actualInjection.user.Id) && x.vaccine.Id.Equals(actualInjection.vaccine.Id));
                // If we found an existing injection
                if (injectionFound != null )
                {
                    // If it's a later one, change it
                    if (actualInjection.recall > injectionFound.recall)
                    {
                        lastInjections.Remove(injectionFound);
                        lastInjections.Add(actualInjection);
                    }
                    //Else do nothing
                } else // Else if we found no existing injection, add it
                {
                    lastInjections.Add(actualInjection);
                }
            }

            DateTime now = DateTime.Now;
            return View(lastInjections.Where(i => i.recall < now));
        }

    }
}
