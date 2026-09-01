using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class SigurnosnaKontrola
    {
        public virtual int Id { get; set; }
        public virtual string IpAdresa { get; set; }
        public virtual DateTime DatumIVreme { get; set; }
        public virtual string TipDogadjaja { get; set; } // LOGIN, NEUSPELA_AUTENTIFIKACIJA, PROMENA_PINA, BLOKADA_RAČUNA, SUMNJIVA_TRANSAKCIJA
        public virtual string StatusDogadjaja { get; set; }
        public virtual string PodaciUredjaja { get; set; }
        public virtual string Opis { get; set; }

        public virtual Racun Racun { get; set; }

        public SigurnosnaKontrola() { }
    }
}
