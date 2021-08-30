using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Valgapplikasjon.Models
{
    public class FaqModel
    {
        [Key]
        public int FaqId { get; set; }
        public string FaqSporsmal { get; set; }
        public string FaqSvar { get; set; }
    }
}

// Sist endret av Redjo husanovic 25.05.2021