using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prodavnica.Entiteti;
using FluentNHibernate.Mapping;

namespace Prodavnica.Mapiranja
{
    public class TekuciMapiranja: SubclassMap<Tekuci>
    {
        public TekuciMapiranja()
        {
            Table("TEKUCI");
            KeyColumn("RACUNID");

            Map(x => x.PlatnaKartica).Column("PLATNAKARTICA");
            Map(x => x.MesecniLimit).Column("MESECNILIMIT");

            HasMany(x => x.TekuciPaketi).KeyColumn("RACUNID").Cascade.All();
        }
    }
}
