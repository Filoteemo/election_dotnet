using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Valgapplikasjon.Areas.Identity;
using Valgapplikasjon.Data;
using Valgapplikasjon.Models;

namespace Valgapplikasjon.Controllers
{
    [Authorize]
    public class KandidatController : Controller
    {

        private readonly AuthDbContext _context;
        private readonly UserManager<ValgapplikasjonUser> _userManager;

        //Konstruktørmetode som sørger for tilkobling til db
        public KandidatController(AuthDbContext context, UserManager<ValgapplikasjonUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var valgtid = _context.Valg.FromSqlRaw("Select * from Valg").FirstOrDefault();
            DateTime avstemmingSlutt = valgtid.SluttAvstemming;
            ViewBag.valgtid = avstemmingSlutt;
        }

        //Metoden laster inn index view under mappen Kandidat og returnerer all info om kandidaten
        // GET: BrukerKandidatViewModel/Index
        public ActionResult Index()
        {

            var kandidater = _context.Kandidat.ToList(); // variabel som holder liste med alle kandidater
            var users = _context.Users.ToList(); //variabel som holder liste med alle brukere
            var valg = _context.Valg.ToList(); //variabel som holder liste med alle valg


            //sql join ved bruk av variablene over. 
            var kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join v in valg on k.ValgId equals v.ValgId into userk
                                    from v in userk.DefaultIfEmpty()
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, ValgVm = v };

            return View(kandidatViewModel);
        }

        //Metoden laster inn view for å opprette nytt kandidatur
        // GET: MittKandidatur/Create
        public IActionResult Create()
        {
            List<ValgModel> valgliste = _context.Valg.ToList();
            ViewData["valginfo"] = valgliste;
            return View();
        }

        //Post metode for å opprette nytt kandidatur
        //Metoden kontrollerer for tid slik at en bruker ikke kan registrere seg som kandidat før nominerigsperioden er i gang
        // POST: MittKandidatur/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, ValgId, Ansettelse, Fakultet, Institutt, Campus")] MittKandidaturModel mittKandidaturModel)
        {
            // henter ut data fra rad i databasen hvor id er lik id sendt som argument til metoden
            var valgObjekt = _context.Valg.FromSqlRaw("Select * from Valg where ValgId=" + mittKandidaturModel.ValgId).FirstOrDefault();
            List<ValgModel> valgliste = _context.Valg.ToList();
            ViewData["valginfo"] = valgliste;
            DateTime nomineringStart = valgObjekt.StartNominering; //setter nomineringStart variabelen til verdien av NomineringStart fra felt i databasen
            DateTime nomineringSlutt = valgObjekt.SluttNominering;
            DateTime now = DateTime.Now;
            int compareStart = DateTime.Compare(now, nomineringStart); // sammenlikner en gitt tid med en annen og returnerer -1, 0 eller 1
            int compareEnd = DateTime.Compare(now, nomineringSlutt);

            if (ModelState.IsValid && compareStart >= 0 && compareEnd <= 0) // hvis verdien av compareStart variabel er større enn eller lik 0 og verdien av compareEnd er mindre enn eller lik 0 og resten av argumentene er valide mot modellen gjennomfør registrering av kandidatur
            {
                _context.Add(mittKandidaturModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        //Metode som laster inn view for redigering av kandidatur
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mittKandidaturModel = await _context.Kandidat.FindAsync(id);
            if (mittKandidaturModel == null)
            {
                return NotFound();
            }
            List<ValgModel> valgliste = _context.Valg.ToList();
            ViewData["valginfo"] = valgliste;

            return View(mittKandidaturModel);
        }

        //Post metode som redigerer kandidatur
        // POST: MittKandidatur/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("KandidatId, Id, ValgId, Ansettelse,Fakultet,Institutt,Campus")] MittKandidaturModel mittKandidaturModel)
        {
            // henter ut data fra rad i databasen hvor id er lik id sendt som argument til metoden
            var valgObjekt = _context.Valg.FromSqlRaw("Select * from Valg where ValgId=" + mittKandidaturModel.ValgId).FirstOrDefault();
            List<ValgModel> valgliste = _context.Valg.ToList();
            ViewData["valginfo"] = valgliste;
            DateTime nomineringStart = valgObjekt.StartNominering; //setter nomineringStart variabelen til verdien av NomineringStart fra felt i databasen
            DateTime nomineringSlutt = valgObjekt.SluttNominering;
            DateTime now = DateTime.Now;
            int compareStart = DateTime.Compare(now, nomineringStart); // sammenlikner en gitt tid med en annen og returnerer -1, 0 eller 1
            int compareEnd = DateTime.Compare(now, nomineringSlutt);

            if (ModelState.IsValid && compareStart >= 0 && compareEnd <= 0) // hvis verdien av compareStart variabel er større enn eller lik 0 og verdien av compareEnd er mindre enn eller lik 0 og resten av argumentene er valide mot modellen gjennomfør registrering av kandidatur
            {
                _context.Update(mittKandidaturModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Kandidat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mittKandidaturModel = await _context.Kandidat
                .FirstOrDefaultAsync(m => m.KandidatId == id);
            if (mittKandidaturModel == null)
            {
                return NotFound();
            }

            return View(mittKandidaturModel);
        }

        //Post metode som sletter kandidatur
        // POST: MittKandidatur/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mittKandidaturModel = await _context.Kandidat.FindAsync(id);
            _context.Kandidat.Remove(mittKandidaturModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Metode som henter informasjon fra tre ulike tabeller og utfører ulike sql spørringer som står for logikken ved filtrering av kandidater
        public ActionResult Avstemming(string fakultet, string institutt, string navn, string campus)
        {

            var kandidater = _context.Kandidat.ToList(); // variabel som holder liste med alle kandidater
            var users = _context.Users.ToList(); //variabel som holder liste med alle brukere
            var stemmer = _context.KandidatStemmer.ToList();
            var institutter = new List<string>();
            var campuser = new List<string>();
            var fakulteter = new List<string>();

            //sql join ved bruk av variablene over. 
            var kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty()
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, KandidatStemmer = s };

            //sql join spørring som leter etter kandidater basert på fakultet
            if (!string.IsNullOrEmpty(fakultet))
            {
                kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty()
                                    where k.Fakultet.Equals(fakultet)
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, KandidatStemmer = s };
            }

            //sql join spørring som leter etter kandidater basert på institutt
            else if (!string.IsNullOrEmpty(institutt))
            {
                kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty()
                                    where k.Institutt.Equals(institutt)
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, KandidatStemmer = s };

            }

            //sql join spørring som leter etter kandidater basert på navn i søkefelt
            else if (!string.IsNullOrEmpty(navn))

            {
                kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty()
                                    where u.Fornavn.ToUpper().Contains(navn.ToUpper()) || u.Etternavn.ToUpper().Contains(navn.ToUpper())
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, KandidatStemmer = s };
            }

            //sql join spørring som leter etter kandidater basert på campus
            else if (!string.IsNullOrEmpty(campus))
            {
                kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty()
                                    where k.Campus.Equals(campus)
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, KandidatStemmer = s };
            }

            foreach (var item in kandidater)
            {
                institutter.Add(item.Institutt);
                campuser.Add(item.Campus);
                fakulteter.Add(item.Fakultet);
            }

            ViewBag.selectInstitutter = new SelectList(institutter.Distinct().ToList());
            ViewBag.selectCampuser = new SelectList(campuser.Distinct().ToList());
            ViewBag.selectFakulteter = new SelectList(fakulteter.Distinct().ToList());


            return View(kandidatViewModel);
        }

        //Post metode for å avgi stemmer på en kandidat
        [HttpPost]
        public async Task<IActionResult> Stem(int KandidatStemmeId, int VoteCount)
        {

            var kandidater = _context.Kandidat.ToList(); // variabel som holder liste med alle kandidater
            var users = _context.Users.ToList(); //variabel som holder liste med alle brukere
            var stemmer = _context.KandidatStemmer.ToList();


            //sql join ved bruk av variablene over. 
            var kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty()
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, KandidatStemmer = s };


            var kandidatToUpdate = await _context.KandidatStemmer
                .FirstOrDefaultAsync(s => s.KandidatStemmeId == KandidatStemmeId);

            kandidatToUpdate.VoteCount += VoteCount;


            // Finner innlogget brukenavn
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            // Oppretter bruker-objekt "valgappliskajonUser"
            ValgapplikasjonUser valgapplikasjonUser = await _userManager.FindByIdAsync(userId);
            // Setter "HasVoted" til true
            valgapplikasjonUser.HasVoted = true;

            if (await TryUpdateModelAsync<KandidatStemmerModel>(kandidatToUpdate, "", s => s.KandidatStemmeId, s => s.KandidatId))
            {
                try
                {
                    await _context.SaveChangesAsync();


                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }

            }
            return RedirectToAction(nameof(Avstemming));
        }

        //Metode som laster inn view med detaljer om en spesifikk kandidat
        public ActionResult KandidatDetaljer(int? KandidatId)
        {
            var kandidater = _context.Kandidat.ToList(); // variabel som holder liste med alle kandidater
            var users = _context.Users.ToList(); //variabel som holder liste med alle brukere
            var stemmer = _context.KandidatStemmer.ToList();

            //sql join ved bruk av variablene over. 
            var kandidatViewModel = from k in kandidater
                                    join u in users on k.Id equals u.Id
                                    join s in stemmer on k.KandidatId equals s.KandidatId into userk
                                    from s in userk.DefaultIfEmpty() where k.KandidatId.Equals(KandidatId)
                                    select new BrukerKandidatViewModel { kandidaterVm = k, usersVm = u, KandidatStemmer = s };

            return View(kandidatViewModel);
        }
    }
}

/* Denne klassen er utviklet av Sindre Olsen sist endret 03.06.21 */
/* Denne klassen er utviklet av Alf Almén sist endret 03.06.21 */