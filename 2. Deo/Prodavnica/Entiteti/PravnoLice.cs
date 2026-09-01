using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Entiteti
{
    public class PravnoLice
    {
        public virtual int Id { get; set; }
        public virtual string NazivFirme { get; set; }
        public virtual string Pib { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string Status { get; set; }
        public virtual string Komentar { get; set; }

        public virtual ICollection<Racun> Racuni { get; set; } = new List<Racun>();
        public virtual ICollection<Depozit> Depoziti { get; set; } = new List<Depozit>();
        public virtual ICollection<Kredit> Krediti { get; set; } = new List<Kredit>();

        public PravnoLice() { }
    }
}
