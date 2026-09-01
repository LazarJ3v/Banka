using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class ZiroMapiranja: SubclassMap<Ziro>
    {
        public ZiroMapiranja()
        {
            Table("ZIRO");
            KeyColumn("RACUNID");

            Map(x => x.Namena).Column("NAMENA");
            Map(x => x.ElektronskoBankarstvo).Column("ELEKTRONSKOBANKARSTVO");
            Map(x => x.LimitZaMasovnaPlacanja).Column("LIMITZAMASOVNAPLACANJA");
            Map(x => x.IntegracijaSaSistemima).Column("INTEGRACIJASASISTEMIMA");
        }
    }
}
