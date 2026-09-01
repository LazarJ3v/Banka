using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Kamata
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumObracuna { get; set; }
        public virtual string PeriodObracuna { get; set; }
        public virtual string TipKamate { get; set; }
        public virtual string StatusKamate { get; set; } // OBRAČUNATO, ISPLAĆENO, KAPITALIZOVANO
        public virtual decimal Iznos { get; set; }

        // Izvor: barem jedan od tri mora biti postavljen (CHK_Kamata_Izvor)
        public virtual Kredit Kredit { get; set; }
        public virtual Depozit Depozit { get; set; }
        public virtual Racun Racun { get; set; }

        public Kamata() { }
    }
}
