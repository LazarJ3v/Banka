using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class DevizniOgranicenje
    {
        public virtual int Id { get; set; }
        public virtual string Ogranicenje { get; set; }
        public virtual int RacunId { get; set; }
        public virtual Racun Racun { get; set; }

        public DevizniOgranicenje() { }
    }
}
