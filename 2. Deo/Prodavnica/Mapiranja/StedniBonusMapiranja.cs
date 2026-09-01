using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class StedniBonusMapiranja: ClassMap<StedniBonus>
    {
        public StedniBonusMapiranja()
        {
            Table("STEDNI_BONUS");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.Bonus).Column("BONUS");
            References(x => x.Stedni).Column("RACUNID").Not.Nullable();
        }
    }
}
