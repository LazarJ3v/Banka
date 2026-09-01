using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Depozit
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual int PeriodOrocenja { get; set; } // u mesecima
        public virtual DateTime DatumIsteka { get; set; }
        public virtual string StatusDepozita { get; set; }
        public virtual string Valuta { get; set; }
        public virtual decimal Iznos { get; set; }
        public virtual decimal KamatnaStopa { get; set; }
        public virtual string Komentar { get; set; }

        public virtual FizickoLice FizickoLice { get; set; }
        public virtual PravnoLice PravnoLice { get; set; }
        public virtual Racun Racun { get; set; }

        public virtual ICollection<Kamata> Kamate { get; set; } = new List<Kamata>();

        // Izvedeni atribut (ne mapira se u bazu): Iznos * (KamatnaStopa/100) * (PeriodOrocenja/12)
        public virtual decimal OcekivanaKamata => Iznos * (KamatnaStopa / 100m) * (PeriodOrocenja / 12m);

        public Depozit() { }
    }
}
