using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class KreditMapiranja: ClassMap<Kredit>
    {
        public KreditMapiranja()
        {
            Table("KREDIT");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.DatumDospeca).Column("DATUMDOSPECA");
            Map(x => x.DatumOdobrenja).Column("DATUMODOBRENJA");
            Map(x => x.Iznos).Column("IZNOS");
            Map(x => x.Valuta).Column("VALUTA");
            Map(x => x.StatusKredita).Column("STATUSKREDITA");
            Map(x => x.MesecnaRata).Column("MESECNARATA");
            Map(x => x.RokOtplate).Column("ROKOTPLATE");
            Map(x => x.Namena).Column("NAMENA");
            Map(x => x.KamatnaStopa).Column("KAMATNASTOPA");
            Map(x => x.Komentar).Column("KOMENTAR");

            References(x => x.FizickoLice).Column("FIZICKOLICEID");
            References(x => x.PravnoLice).Column("PRAVNOLICEID");
            References(x => x.Racun).Column("RACUNID").Not.Nullable();

            HasMany(x => x.Kamate).KeyColumn("KREDITID");
        }
    }
}
