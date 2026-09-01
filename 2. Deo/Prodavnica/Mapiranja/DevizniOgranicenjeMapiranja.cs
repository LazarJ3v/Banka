using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class DevizniOgranicenjeMapiranja: ClassMap<DevizniOgranicenje>
    {
        public DevizniOgranicenjeMapiranja()
        {
            Table("DEVIZNI_OGRANICENJE");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.Ogranicenje).Column("OGRANICENJE");
            References(x => x.Devizni).Column("RACUNID").Not.Nullable();
        }
    }
}
