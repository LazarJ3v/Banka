using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prodavnica.Entiteti;
using FluentNHibernate.Mapping;

namespace Prodavnica.Mapiranja
{
    public class RacunMapiranja: ClassMap<Racun>
    {
        public RacunMapiranja()
        {
            Table("RACUN");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.BrojRacuna).Column("BROJRACUNA");
            Map(x => x.Valuta).Column("VALUTA");
            Map(x => x.TrenutnoStanje).Column("TRENUTNOSTANJE");
            Map(x => x.DatumOtvaranja).Column("DATUMOTVARANJA");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.DozvoljeniMinus).Column("DOZVOLJENIMINUS");
            Map(x => x.Komentar).Column("KOMENTAR");
            Map(x => x.TipRacuna).Column("TIPRACUNA");
            Map(x => x.KamatnaStopa).Column("KAMATNASTOPA");

            References(x => x.FizickoLice).Column("FIZICKOLICEID");
            References(x => x.PravnoLice).Column("PRAVNOLICEID");

            // Zajedničko za sve tipove računa - bez kaskadnog brisanja
            // (finansijski zapisi ne treba automatski da se brišu sa računom)
            HasMany(x => x.Depoziti).KeyColumn("RACUNID");
            HasMany(x => x.Krediti).KeyColumn("RACUNID");
            HasMany(x => x.Transakcije).KeyColumn("RACUNID").Cascade.All();
            HasMany(x => x.Kamate).KeyColumn("RACUNID");
            HasMany(x => x.SigurnosneKontrole).KeyColumn("RACUNID").Cascade.All();
        }
    }
}
