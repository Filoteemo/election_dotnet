using Microsoft.AspNetCore.Mvc;
using Valgapplikasjon.Areas.Identity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Valgapplikasjon.Controllers
{
	public class AdminController : Controller
	{
		private UserManager<ValgapplikasjonUser> userManager;
        private IPasswordHasher<ValgapplikasjonUser> passwordHasher;

        //Konstruktørmetode som sørger for tilkobling til db
        public AdminController(UserManager<ValgapplikasjonUser> usrMgr, IPasswordHasher<ValgapplikasjonUser> passwordHash)
		{
			userManager = usrMgr;
            passwordHasher = passwordHash;
        }

        //Metoden laster inn index view under mappen Admin og returnerer en liste med alle brukere
        // GET: BrukerKandidatViewModel/Index
        public IActionResult Index()
		{
            return View(userManager.Users);
        }


        // Metoden kalles på når en bruker klikke på "Slett" i Viewet 
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            ValgapplikasjonUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", userManager.Users);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
