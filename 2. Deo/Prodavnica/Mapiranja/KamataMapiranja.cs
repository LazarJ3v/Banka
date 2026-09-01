using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class KamataMapiranja: ClassMap<Kamata>
    {
        public KamataMapiranja()
        {
            Table("KAMATA");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.DatumObracuna).Column("DATUMOBRACUNA");
            Map(x => x.PeriodObracuna).Column("PERIODOBRACUNA");
            Map(x => x.TipKamate).Column("TIPKAMATE");
            Map(x => x.StatusKamate).Column("STATUSKAMATE");
            Map(x => x.Iznos).Column("IZNOS");

            References(x => x.Kredit).Column("KREDITID");
            References(x => x.Depozit).Column("DEPOZITID");
            References(x => x.Racun).Column("RACUNID");
        }
    }
}
