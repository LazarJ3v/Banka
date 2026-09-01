using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class SigurnosnaKontrolaMapiranja: ClassMap<SigurnosnaKontrola>
    {
        public SigurnosnaKontrolaMapiranja()
        {
            Table("SIGURNOSNA_KONTROLA");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.IpAdresa).Column("IPADRESA");
            Map(x => x.DatumIVreme).Column("DATUMIVREME");
            Map(x => x.TipDogadjaja).Column("TIPDOGADJAJA");
            Map(x => x.StatusDogadjaja).Column("STATUSDOGADJAJA");
            Map(x => x.PodaciUredjaja).Column("PODACIUREDJAJA");
            Map(x => x.Opis).Column("OPIS");

            References(x => x.Racun).Column("RACUNID").Not.Nullable();
        }
    }
}
