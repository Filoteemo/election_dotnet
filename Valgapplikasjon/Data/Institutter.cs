using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valgapplikasjon.Data
{
    public class Institutter
    {
        public List<string> Institutt { get; set; }

        public Institutter()
        {
            Institutt = new List<string>()
            {
                {"Helse-, sosial- og velferdsfag"},
                {"Optometri, radiografi og lysdesign"},
                {"Matematikk og naturfag"},
                {"Kultur, religion og samfunnsfag"},
                {"Pedagogikk"},
                {"Språk og litteratur"},
                {"Friluftsliv, idrett og kroppsøving"},
                {"Tradisjonskunst og folkemusikk"},
                {"Elektro, IT og kybernetikk"},
                {"Maritime operasjoner"},
                {"Mikrosystemer"},
                {"Natur, helse og miljø"},
                {"Prosess-, energi- og miljøteknologi"},
                {"Realfag og industrisystemer"},
                {"Økonomi og IT"},
                {"Økonomi, markedsføring og jus"},
                {"Industriell økonomi, strategi og statsvitenskap"},
                {"Økonomi, historie og samfunnsvitenskap"}
            };
        }
    }
}

