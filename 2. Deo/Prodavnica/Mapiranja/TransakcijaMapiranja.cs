using FluentNHibernate.Mapping;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Mapiranja
{
    public class TransakcijaMapiranja: ClassMap<Transakcija>
    {
        public TransakcijaMapiranja()
        {
            Table("TRANSAKCIJA");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.DatumIVreme).Column("DATUMIVREME");
            Map(x => x.TipTransakcije).Column("TIPTRANSAKCIJE");
            Map(x => x.StatusTransakcije).Column("STATUSTRANSAKCIJE");
            Map(x => x.PodaciPrimaoca).Column("PODACIPRIMAOCA");
            Map(x => x.Referenca).Column("REFERENCA");
            Map(x => x.Valuta).Column("VALUTA");
            Map(x => x.Iznos).Column("IZNOS");
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.Komentar).Column("KOMENTAR");

            References(x => x.Racun).Column("RACUNID").Not.Nullable();
        }
    }
}
