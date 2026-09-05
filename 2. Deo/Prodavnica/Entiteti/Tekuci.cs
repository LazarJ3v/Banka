using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Tekuci : Racun
    {
        public virtual int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual bool PlatnaKartica { get; set; }
        public virtual decimal? MesecniLimit { get; set; }

        public virtual ICollection<TekuciPaket> TekuciPaketi { get; set; } = new List<TekuciPaket>();

        public Tekuci() { }
    }
}
