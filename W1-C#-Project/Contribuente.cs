using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_C__Project
{
    public class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public double RedditoAnnuale { get; set; }
        

        public Contribuente() { }

        public Contribuente ( string nome, string cognome, string dataNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale) 
        {
            nome = Nome;
            cognome = Cognome;
            dataNascita= DataNascita;
            codiceFiscale = CodiceFiscale;
            sesso = Sesso;
            comuneResidenza = ComuneResidenza;
            redditoAnnuale = RedditoAnnuale;
        }


    }
}
