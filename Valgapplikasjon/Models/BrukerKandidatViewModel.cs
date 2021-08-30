using Valgapplikasjon.Areas.Identity;

namespace Valgapplikasjon.Models
{
    //Viewmodel som holder et objekt av fire ulike tabeller for å kombinere data fra flere tabeller i ett view
    public class BrukerKandidatViewModel
    {
        public ValgapplikasjonUser usersVm { get; set; }
        public MittKandidaturModel kandidaterVm { get; set; }
        public ValgModel ValgVm { get; set; }

        public KandidatStemmerModel KandidatStemmer {get; set;}
    }
}

/* Denne klassen er utviklet av Sindre Olsen sist endret 03.06.21 */
