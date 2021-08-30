using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Valgapplikasjon.Areas.Identity;
using Valgapplikasjon.Models;

namespace Valgapplikasjon.Data
{
    public class AuthDbContext : IdentityDbContext<ValgapplikasjonUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
        }

        //setter Kandidat tabell i db
        public DbSet <MittKandidaturModel> Kandidat { get; set; }

        //setter Valg tabell i db
        public DbSet<ValgModel> Valg { get; set; }

        //setter KandidatStemmer tabell i db
        public DbSet<KandidatStemmerModel> KandidatStemmer { get; set; }

        //setter Faq tabell i db
        public DbSet<FaqModel> FAQ { get; set; }
    }
}
/* Denne klassen er utviklet av Sindre Olsen sist endret 15.04.21 */