using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class DevizniValutaMapiranja: ClassMap<DevizniValuta>
    {
        public DevizniValutaMapiranja()
        {
            Table("DEVIZNI_VALUTA");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.DozvoljenaValuta).Column("DOZVOLJENAVALUTA");
            References(x => x.Devizni).Column("RACUNID").Not.Nullable();
        }
    }
}
