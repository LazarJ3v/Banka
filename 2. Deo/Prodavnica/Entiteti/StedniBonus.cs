using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class StedniBonus
    {
        public virtual int Id { get; set; }
        public virtual string Bonus { get; set; }
        public virtual int RacunId { get; set; }
        public virtual Stedni Stedni { get; set; }

        public StedniBonus() { }
    }
}
