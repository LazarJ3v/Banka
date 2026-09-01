using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class TekuciPaketMapiranja: ClassMap<TekuciPaket>
    {
        public TekuciPaketMapiranja()
        {
            Table("TEKUCI_PAKET");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.Paket).Column("PAKET");
            References(x => x.Tekuci).Column("RACUNID").Not.Nullable();
        }
    }
}
