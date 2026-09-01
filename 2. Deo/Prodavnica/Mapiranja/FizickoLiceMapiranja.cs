using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prodavnica.Entiteti;
using FluentNHibernate.Mapping;

namespace Prodavnica.Mapiranja
{
    public class FizickoLiceMapiranja: ClassMap<FizickoLice>
    {
        public FizickoLiceMapiranja()
        {
            Table("FIZICKO_LICE");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Jmbg).Column("JMBG");
            Map(x => x.BrojLicneKarte).Column("BROJLICNEKARTE");
            Map(x => x.DatumRodjenja).Column("DATUMRODJENJA");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Grad).Column("GRAD");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.Komentar).Column("KOMENTAR");

            HasMany(x => x.Racuni).KeyColumn("FIZICKOLICEID");
            HasMany(x => x.Depoziti).KeyColumn("FIZICKOLICEID");
            HasMany(x => x.Krediti).KeyColumn("FIZICKOLICEID");
        }
    }
}
