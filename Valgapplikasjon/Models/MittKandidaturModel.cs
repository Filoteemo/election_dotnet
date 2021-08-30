using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Valgapplikasjon.Areas.Identity;

namespace Valgapplikasjon.Models
{
    // Klassen representerer tabellen Kandidat i databasen. 
    public class MittKandidaturModel
    {
        [Key]
        public int KandidatId { get; set; }

        public string Id { get; set; }
        public int ValgId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Ansettelse { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Fakultet { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Institutt { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Campus { get; set; }

        [ForeignKey("Id")] // Dataannotation må være rett over ref til parent class som innehar PK
        public ValgapplikasjonUser User { get; set; }

        [ForeignKey("ValgId")]
        public ValgModel Valg { get; set; }


        public KandidatStemmerModel KandidatStemmer { get; set; }

    }
}

/* Denne klassen er utviklet av Sindre Olsen sist endret 15.05.21 */