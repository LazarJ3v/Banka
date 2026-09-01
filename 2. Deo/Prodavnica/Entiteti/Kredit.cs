using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Kredit
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumDospeca { get; set; }
        public virtual DateTime DatumOdobrenja { get; set; }
        public virtual decimal Iznos { get; set; }
        public virtual string Valuta { get; set; }
        public virtual string StatusKredita { get; set; }
        public virtual decimal MesecnaRata { get; set; }
        public virtual int RokOtplate { get; set; } // u mesecima
        public virtual string Namena { get; set; }
        public virtual decimal KamatnaStopa { get; set; }
        public virtual string Komentar { get; set; }

        public virtual FizickoLice FizickoLice { get; set; }
        public virtual PravnoLice PravnoLice { get; set; }
        public virtual Racun Racun { get; set; }

        public virtual ICollection<Kamata> Kamate { get; set; } = new List<Kamata>();

        public Kredit() { }
    }
}
