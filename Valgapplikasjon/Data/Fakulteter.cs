using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valgapplikasjon.Data
{
    public class Fakulteter
    {
        public List<string> Fakultet { get; set; }

        public Fakulteter()
        {
            Fakultet = new List<string>()
            {
                {"Teknologi, naturvitenskap og maritime fag"},
                {"Helse - og sosialvitenskap"},
                {"Humaniora, idrett - og utdanningsvitenskap"},
                {"USN Handelshøyskolen"}
            };
        }
    }
}