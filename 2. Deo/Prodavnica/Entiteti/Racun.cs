using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Racun
    {
        public virtual int Id { get; set; }
        public virtual string BrojRacuna { get; set; }
        public virtual string Valuta { get; set; }
        public virtual decimal TrenutnoStanje { get; set; }
        public virtual DateTime DatumOtvaranja { get; set; }
        public virtual string Status { get; set; }
        public virtual decimal DozvoljeniMinus { get; set; }
        public virtual string Komentar { get; set; }
        public virtual string TipRacuna { get; set; }
        public virtual decimal? KamatnaStopa { get; set; }

        public virtual FizickoLice FizickoLice { get; set; }
        public virtual PravnoLice PravnoLice { get; set; }

        public virtual Tekuci Tekuci { get; set; }
        public virtual Stedni Stedni { get; set; }
        public virtual Devizni Devizni { get; set; }
        public virtual Ziro Ziro { get; set; }

        public virtual ICollection<Depozit> Depoziti { get; set; } = new List<Depozit>();
        public virtual ICollection<Kredit> Krediti { get; set; } = new List<Kredit>();
        public virtual ICollection<Transakcija> Transakcije { get; set; } = new List<Transakcija>();
        public virtual ICollection<Kamata> Kamate { get; set; } = new List<Kamata>();
        public virtual ICollection<SigurnosnaKontrola> SigurnosneKontrole { get; set; } = new List<SigurnosnaKontrola>();

        public Racun() { }

    }
}
