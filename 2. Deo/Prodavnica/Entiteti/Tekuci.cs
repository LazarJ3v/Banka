using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Tekuci
    {
        public virtual int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual bool PlatnaKartica { get; set; }
        public virtual decimal? MesecniLimit { get; set; }

        public Tekuci() { }
    }
}
