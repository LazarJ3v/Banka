using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class StedniUsloviPodizanjaMapiranja: ClassMap<StedniUsloviPodizanja>
    {
        public StedniUsloviPodizanjaMapiranja()
        {
            Table("STEDNI_USLOVI_PODIZANJA");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.UslovPodizanja).Column("USLOVPODIZANJA");
            References(x => x.Stedni).Column("RACUNID").Not.Nullable();
        }
    }
}
