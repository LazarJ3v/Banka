using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Ziro
    {
        public virtual int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual string Namena { get; set; }
        public virtual bool ElektronskoBankarstvo { get; set; }
        public virtual decimal? LimitZaMasovnaPlacanja { get; set; }
        public virtual string IntegracijaSaSistemima { get; set; }

        public Ziro() { }
    }
}
