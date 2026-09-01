using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Stedni
    {
        public virtual int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual decimal? MinimalniIznosOtvaranja { get; set; }
        public virtual int FrekvKapitalizKamate { get; set; } // 365, 12, 4, 2, 1

        public Stedni() { }
    }
}
