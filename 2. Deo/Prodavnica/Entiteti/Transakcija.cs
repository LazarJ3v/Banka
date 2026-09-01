using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Transakcija
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumIVreme { get; set; }
        public virtual string TipTransakcije { get; set; } // UPLATA, ISPLATA, TRANSFER, PLAĆANJE_RAČUNA, KONVERZIJA
        public virtual string StatusTransakcije { get; set; }
        public virtual string PodaciPrimaoca { get; set; }
        public virtual string Referenca { get; set; }
        public virtual string Valuta { get; set; }
        public virtual decimal Iznos { get; set; }
        public virtual string Opis { get; set; }
        public virtual string Komentar { get; set; }

        public virtual Racun Racun { get; set; }

        public Transakcija() { }
    }
}
