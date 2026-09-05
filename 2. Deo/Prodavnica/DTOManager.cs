using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using Prodavnica.Entiteti;
using System.Windows.Forms;
using NHibernate.Proxy;

namespace Prodavnica
{
    public class DTOManager {

        #region FizickaLica
        public static void DodajFizickoLice(FizickoLiceBasic fl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.FizickoLice f = new Prodavnica.Entiteti.FizickoLice();

                f.Ime = fl.Ime;
                f.Prezime = fl.Prezime;
                f.Jmbg = fl.Jmbg;
                f.BrojLicneKarte = fl.BrojLicneKarte;
                f.DatumRodjenja = fl.DatumRodjenja;
                f.Adresa = fl.Adresa;
                f.Grad = fl.Grad;
                f.Telefon = fl.Telefon;
                f.Email = fl.Email;
                f.Status = fl.Status;
                f.Komentar = fl.Komentar;

                s.Save(f);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static FizickoLiceBasic VratiFizickoLice(int id)
        {
            FizickoLiceBasic fl = new FizickoLiceBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.FizickoLice f = s.Load<Prodavnica.Entiteti.FizickoLice>(id);
                fl = new FizickoLiceBasic
                {
                    Id = f.Id,
                    Ime = f.Ime,
                    Prezime = f.Prezime,
                    Jmbg = f.Jmbg,
                    BrojLicneKarte = f.BrojLicneKarte,
                    DatumRodjenja = f.DatumRodjenja,
                    Adresa = f.Adresa,
                    Grad = f.Grad,
                    Telefon = f.Telefon,
                    Email = f.Email,
                    Status = f.Status,
                    Komentar = f.Komentar
                };

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return fl;
        }
        public static FizickoLiceBasic AzurirajFizickoLice(FizickoLiceBasic fl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.FizickoLice f = s.Load<Prodavnica.Entiteti.FizickoLice>(fl.Id);

                f.Ime = fl.Ime;
                f.Prezime = fl.Prezime;
                f.Jmbg = fl.Jmbg;
                f.BrojLicneKarte = fl.BrojLicneKarte;
                f.DatumRodjenja = fl.DatumRodjenja;
                f.Adresa = fl.Adresa;
                f.Grad = fl.Grad;
                f.Telefon = fl.Telefon;
                f.Email = fl.Email;
                f.Status = fl.Status;
                f.Komentar = fl.Komentar;

                s.Update(f);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return fl;
        }
        public static void ObrisiFizickoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.FizickoLice f = s.Load<Prodavnica.Entiteti.FizickoLice>(id);

                s.Delete(f);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        #endregion

        #region PravnaLica
        public static void DodajPravnoLice(PravnoLiceBasic pl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.PravnoLice p = new Prodavnica.Entiteti.PravnoLice();

                p.NazivFirme = pl.NazivFirme;
                p.Pib = pl.Pib;
                p.Adresa = pl.Adresa;
                p.Grad = pl.Grad;
                p.Telefon = pl.Telefon;
                p.Email = pl.Email;
                p.Status = pl.Status;
                p.Komentar = pl.Komentar;

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static PravnoLiceBasic VratiPravnoLice(int id)
        {
            PravnoLiceBasic pl = new PravnoLiceBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.PravnoLice p = s.Load<Prodavnica.Entiteti.PravnoLice>(id);
                pl = new PravnoLiceBasic
                {
                    Id = p.Id,
                    NazivFirme = p.NazivFirme,
                    Pib = p.Pib,
                    Adresa = p.Adresa,
                    Grad = p.Grad,
                    Telefon = p.Telefon,
                    Email = p.Email,
                    Status = p.Status,
                    Komentar = p.Komentar
                };

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pl;
        }
        public static PravnoLiceBasic AzurirajPravnoLice(PravnoLiceBasic pl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.PravnoLice p = s.Load<Prodavnica.Entiteti.PravnoLice>(pl.Id);

                p.NazivFirme = pl.NazivFirme;
                p.Pib = pl.Pib;
                p.Adresa = pl.Adresa;
                p.Grad = pl.Grad;
                p.Telefon = pl.Telefon;
                p.Email = pl.Email;
                p.Status = pl.Status;
                p.Komentar = pl.Komentar;

                s.Update(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pl;
        }
        public static void ObrisiPravnoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.PravnoLice p = s.Load<Prodavnica.Entiteti.PravnoLice>(id);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        #endregion

        #region Racuni
        public static void DodajRacun(RacunBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.Racun racun = new Prodavnica.Entiteti.Racun();

                racun.BrojRacuna = r.BrojRacuna;
                racun.Valuta = r.Valuta;
                racun.TrenutnoStanje = r.TrenutnoStanje;
                racun.DatumOtvaranja = r.DatumOtvaranja;
                racun.Status = r.Status;
                racun.DozvoljeniMinus = r.DozvoljeniMinus;
                racun.Komentar = r.Komentar;
                racun.TipRacuna = r.TipRacuna;
                racun.KamatnaStopa = r.KamatnaStopa;
                if(r.FizickoLice != null)
                    racun.FizickoLice = s.Load<Prodavnica.Entiteti.FizickoLice>(r.FizickoLice.Id);
                else if(r.PravnoLice != null)
                    racun.PravnoLice = s.Load<Prodavnica.Entiteti.PravnoLice>(r.PravnoLice.Id);

                s.Save(racun);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static RacunBasic VratiRacun(int id)
        {
            RacunBasic r = new RacunBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Prodavnica.Entiteti.Racun racun = s.Load<Prodavnica.Entiteti.Racun>(id);

                r = new RacunBasic
                {
                    Id = racun.Id,
                    BrojRacuna = racun.BrojRacuna,
                    Valuta = racun.Valuta,
                    TrenutnoStanje = racun.TrenutnoStanje,
                    DatumOtvaranja = racun.DatumOtvaranja,
                    Status = racun.Status,
                    DozvoljeniMinus = racun.DozvoljeniMinus,
                    Komentar = racun.Komentar,
                    TipRacuna = racun.TipRacuna,
                    KamatnaStopa = racun.KamatnaStopa,

                    FizickoLice = racun.FizickoLice != null
                        ? new FizickoLiceBasic
                        (
                            racun.FizickoLice.Id,
                            racun.FizickoLice.Ime,
                            racun.FizickoLice.Prezime,
                            racun.FizickoLice.Jmbg,
                            racun.FizickoLice.BrojLicneKarte,
                            racun.FizickoLice.DatumRodjenja,
                            racun.FizickoLice.Adresa,
                            racun.FizickoLice.Grad,
                            racun.FizickoLice.Telefon,
                            racun.FizickoLice.Email,
                            racun.FizickoLice.Status,
                            racun.FizickoLice.Komentar
                        )
                        : null,

                    PravnoLice = racun.PravnoLice != null
                        ? new PravnoLiceBasic
                        (
                            racun.PravnoLice.Id,
                            racun.PravnoLice.NazivFirme,
                            racun.PravnoLice.Pib,
                            racun.PravnoLice.Adresa,
                            racun.PravnoLice.Grad,
                            racun.PravnoLice.Telefon,
                            racun.PravnoLice.Email,
                            racun.PravnoLice.Status,
                            racun.PravnoLice.Komentar
                        )
                        : null
                };

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return r;
        }
        #endregion
    }
}
