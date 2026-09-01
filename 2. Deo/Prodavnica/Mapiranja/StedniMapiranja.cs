using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class StedniMapiranja: SubclassMap<Stedni>
    {
        public StedniMapiranja()
        {
            Table("STEDNI");
            KeyColumn("RACUNID");

            Map(x => x.MinimalniIznosOtvaranja).Column("MINIMALNIIZNOSOTVARANJA");
            Map(x => x.FrekvKapitalizKamate).Column("FREKVKAPITALIZKAMATE");

            HasMany(x => x.StedniUsloviPodizanja).KeyColumn("RACUNID").Cascade.All();
            HasMany(x => x.StedniBonusi).KeyColumn("RACUNID").Cascade.All();
        }
    }
}
