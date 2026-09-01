using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class DevizniMapiranja: SubclassMap<Devizni>
    {
        public DevizniMapiranja()
        {
            Table("DEVIZNI");
            KeyColumn("RACUNID");

            Map(x => x.Namena).Column("NAMENA");
            Map(x => x.KursnaRazlika).Column("KURSNARAZLIKA");

            HasMany(x => x.DevizniOgranicenja).KeyColumn("RACUNID").Cascade.All();
            HasMany(x => x.DevizniValute).KeyColumn("RACUNID").Cascade.All();
        }
    }
}
