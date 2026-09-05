using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class Devizni : Racun
    {
        public virtual int RacunId { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual string Namena { get; set; } // 'ŠTEDNJA' ili 'POSLOVANJE'
        public virtual decimal? KursnaRazlika { get; set; }

        public virtual ICollection<DevizniOgranicenje> DevizniOgranicenja { get; set; } = new List<DevizniOgranicenje>();
        public virtual ICollection<DevizniValuta> DevizniValute { get; set; } = new List<DevizniValuta>();

        public Devizni() { }
    }
}
