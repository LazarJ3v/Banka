using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class DepozitMapiranja: ClassMap<Depozit>
    {
        public DepozitMapiranja()
        {
            Table("DEPOZIT");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.DatumPocetka).Column("DATUMPOCETKA");
            Map(x => x.PeriodOrocenja).Column("PERIODOROCENJA");
            Map(x => x.DatumIsteka).Column("DATUMISTEKA");
            Map(x => x.StatusDepozita).Column("STATUSDEPOZITA");
            Map(x => x.Valuta).Column("VALUTA");
            Map(x => x.Iznos).Column("IZNOS");
            Map(x => x.KamatnaStopa).Column("KAMATNASTOPA");
            Map(x => x.Komentar).Column("KOMENTAR");

            References(x => x.FizickoLice).Column("FIZICKOLICEID");
            References(x => x.PravnoLice).Column("PRAVNOLICEID");
            References(x => x.Racun).Column("RACUNID").Not.Nullable();

            HasMany(x => x.Kamate).KeyColumn("DEPOZITID");

            // OcekivanaKamata je izvedeni atribut - namerno se NE mapira (nema Map poziv za nju)
        }
    }
}
