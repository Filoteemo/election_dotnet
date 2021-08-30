using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valgapplikasjon.Models
{
    public class ValgModel
    {
        [Key]
        public int ValgId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Tittel { get; set; }
        public DateTime StartNominering { get; set; }
        public DateTime SluttNominering { get; set; }
        public DateTime StartAvstemming { get; set; }
        public DateTime SluttAvstemming { get; set; }
        public DateTime Kontrollert { get; set; }

        public ICollection <MittKandidaturModel> Kandidat { get; set; }
    }
}

/* Denne klassen er utviklet av Sindre Olsen sist endret 15.05.21 */