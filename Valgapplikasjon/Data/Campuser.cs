using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valgapplikasjon.Data
{
    public class Campuser
    {
        public List<string> Campus { get; set; }

        public Campuser()
        {
            Campus = new List<string>()
            {
                {"Vestfold"},
                {"Ringerike"},
                {"Kongsberg"},
                {"Notodden"},
                {"Drammen"},
                {"Porsgrunn"},
                {"Rauland"}
            };
        }
    }
}