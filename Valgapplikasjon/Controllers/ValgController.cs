using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Valgapplikasjon.Data;
using Valgapplikasjon.Models;

namespace Valgapplikasjon.Controllers
{
    [Authorize]
    public class ValgController : Controller
    {
        private readonly AuthDbContext _context;

        public ValgController(AuthDbContext context)
        {
            _context = context;
        }

        //GET metode som laster inn index view under mappen Valg
        // GET: Valg
        public async Task<IActionResult> Index()
        {
            return View(await _context.Valg.ToListAsync());
        }

        // GET: Valg/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valgModel = await _context.Valg
                .FirstOrDefaultAsync(m => m.ValgId == id);
            if (valgModel == null)
            {
                return NotFound();
            }

            return View(valgModel);
        }

        //Metoden laster inn view for å opprette nytt valg
        // GET: Valg/Create
        public IActionResult Create()
        {
            return View();
        }

        //Post metode som oppretter nytt valg i tabellen Valg
        // POST: Valg/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ValgId,Tittel,StartNominering,SluttNominering,StartAvstemming,SluttAvstemming,Kontrollert")] ValgModel valgModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(valgModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(valgModel);
        }

        // GET: Valg/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valgModel = await _context.Valg.FindAsync(id);
            if (valgModel == null)
            {
                return NotFound();
            }
            return View(valgModel);
        }

        //Post metode som endrer eksisterende valg
        // POST: Valg/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ValgId,Tittel,StartNominering,SluttNominering,StartAvstemming,SluttAvstemming,Kontrollert")] ValgModel valgModel)
        {
            if (id != valgModel.ValgId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(valgModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValgModelExists(valgModel.ValgId))
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
            return View(valgModel);
        }

        // GET: Valg/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valgModel = await _context.Valg
                .FirstOrDefaultAsync(m => m.ValgId == id);
            if (valgModel == null)
            {
                return NotFound();
            }

            return View(valgModel);
        }

        // POST: Valg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var valgModel = await _context.Valg.FindAsync(id);
            _context.Valg.Remove(valgModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ValgModelExists(int id)
        {
            return _context.Valg.Any(e => e.ValgId == id);
        }

        //Metode som laster inn view for Valgresultat der alle kandidater deltatt på valget vises med en utnevnt vinner
        public ActionResult Valgresultat()
        {

            var kandidater = _context.Kandidat.ToList(); // variabel som holder liste med alle kandidater
            var users = _context.Users.ToList(); //variabel som holder liste med alle brukere
            var valg = _context.Valg.ToList();
            var stemmer = _context.KandidatStemmer.ToList();
            var valgtid = _context.Valg.FromSqlRaw("Select * from Valg").FirstOrDefault();
            DateTime now = DateTime.Now;
            DateTime avstemmingSlutt = valgtid.SluttAvstemming;
            int sammenliknTider = DateTime.Compare(now, avstemmingSlutt);
            ViewBag.valgtid = avstemmingSlutt;



            //sql join ved bruk av variablene over. 
            var kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join v in valg on k.ValgId equals v.ValgId 
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty() orderby s.VoteCount descending
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, ValgVm = v, KandidatStemmer = s };

            ViewBag.voteCountMax = stemmer.Max(x => x.VoteCount);

            if (sammenliknTider >= 0)
            {
                return View(kandidatViewModel);
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
