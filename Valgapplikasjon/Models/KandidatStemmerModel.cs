using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Valgapplikasjon.Models
{
    public class KandidatStemmerModel
    {
        [Key]
        public int KandidatStemmeId { get; set; }


        public int KandidatId { get; set; }


        
        public int? VoteCount { get; set; }

        [ForeignKey("KandidatId")]
        public MittKandidaturModel MittKandidaturModel { get; set; }

    }
}
