using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Stedni : Racun
    {
        public virtual int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual decimal? MinimalniIznosOtvaranja { get; set; }
        public virtual int FrekvKapitalizKamate { get; set; } // 365, 12, 4, 2, 1

        public virtual ICollection<StedniUsloviPodizanja> StedniUsloviPodizanja { get; set; } = new List<StedniUsloviPodizanja>();
        public virtual ICollection<StedniBonus> StedniBonusi { get; set; } = new List<StedniBonus>();

        public Stedni() { }
    }
}
