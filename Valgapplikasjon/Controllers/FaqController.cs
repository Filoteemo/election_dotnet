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
    public class FaqController : Controller
    {
        // dbcontext som _context. Connection til databasen
        private readonly AuthDbContext _context;

        public FaqController(AuthDbContext context)
        {
            _context = context;
        }

        // GET: Faq
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.FAQ.ToListAsync());
        }
        //Endring av FAQ innlegg
        // GET: Faq/Details/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqModel = await _context.FAQ
                .FirstOrDefaultAsync(m => m.FaqId == id);
            if (faqModel == null)
            {
                return NotFound();
            }

            return View(faqModel);
        }
        //View for create metoden. For oppretting av faq innlegg
        // GET: Faq/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        // Binder modellen med viewet og bruker feltene i faqModel
        // POST: Faq/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("FaqId,FaqSporsmal,FaqSvar")] FaqModel faqModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faqModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faqModel);
        }
        
        // GET: Faq/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqModel = await _context.FAQ.FindAsync(id);
            if (faqModel == null)
            {
                return NotFound();
            }
            return View(faqModel);
        }
        // Edit funksjon for et innlegg. Lagrer endringer i tabellen.
        // POST: Faq/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FaqId,FaqSporsmal,FaqSvar")] FaqModel faqModel)
        {
            if (id != faqModel.FaqId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faqModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaqModelExists(faqModel.FaqId))
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
            return View(faqModel);
        }

        // GET: Faq/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faqModel = await _context.FAQ
                .FirstOrDefaultAsync(m => m.FaqId == id);
            if (faqModel == null)
            {
                return NotFound();
            }

            return View(faqModel);
        }
        // Sletting av innlegg 
        // POST: Faq/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faqModel = await _context.FAQ.FindAsync(id);
            _context.FAQ.Remove(faqModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaqModelExists(int id)
        {
            return _context.FAQ.Any(e => e.FaqId == id);
        }
    }
}

// Sist endret av Redjo husanovic 04.06.2021
