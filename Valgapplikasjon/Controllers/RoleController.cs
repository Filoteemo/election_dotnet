using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Valgapplikasjon.Models;
using Valgapplikasjon.Areas.Identity;


namespace Valgapplikasjon.Controllers
{
	public class RoleController : Controller
	{
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ValgapplikasjonUser> userManager;

        //Konstruktørmetode som sørger for tilkobling til db
        public RoleController(RoleManager<IdentityRole> roleMgr, UserManager<ValgapplikasjonUser> userMrg)
        {
            roleManager = roleMgr;
            userManager = userMrg;
        }

        // Metoden laster inn index view under mappen Role og returnerer alle rollene
        // GET: Role/Index
        public ViewResult Index() => View(roleManager.Roles);

        //Metoden laster inn view for å opprette nytt kandidatur
        // GET: Role/Create
        public IActionResult Create() => View();


        //Post-metode for å opprette nye roller
        // POST: Role/Create
        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            return View(name);
        }

        //Post-metode for å opprette slette roller
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "No role found");
            return View("Index", roleManager.Roles);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
