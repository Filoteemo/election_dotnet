using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Valgapplikasjon;
using Valgapplikasjon.Models;
using Valgapplikasjon.Data;
using Microsoft.EntityFrameworkCore;
using Valgapplikasjon.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System;

namespace ValgApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly AuthDbContext _context;

        public HomeController(AuthDbContext context)
        {
            _context = context;
        }

        //Metode som kjører hver gang siden lastes inn. Nødvendig for å kontrollere tider ved valget. 
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var valgtid = _context.Valg.FromSqlRaw("Select * from Valg").FirstOrDefault();
            DateTime avstemmingSlutt = valgtid.SluttAvstemming;
            ViewBag.valgtid = avstemmingSlutt;
        }

        //Metode som laster inn Index under mappen Home
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        //Metode som laster inn feilmelding hvis brukeren gjør en handling som ikke er tillatt
        public IActionResult Error()
        {
            return View();
        }
    }
}
