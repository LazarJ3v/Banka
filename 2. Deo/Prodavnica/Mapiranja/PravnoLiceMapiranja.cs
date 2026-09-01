using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prodavnica.Entiteti;
using FluentNHibernate.Mapping;

namespace Prodavnica.Mapiranja
{
    public class PravnoLiceMapiranja: ClassMap<PravnoLice>
    {
        public PravnoLiceMapiranja()
        {
            Table("PRAVNO_LICE");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.NazivFirme).Column("NAZIVFIRME");
            Map(x => x.Pib).Column("PIB");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Grad).Column("GRAD");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.Komentar).Column("KOMENTAR");

            HasMany(x => x.Racuni).KeyColumn("PRAVNOLICEID");
            HasMany(x => x.Depoziti).KeyColumn("PRAVNOLICEID");
            HasMany(x => x.Krediti).KeyColumn("PRAVNOLICEID");
        }
    }
}
