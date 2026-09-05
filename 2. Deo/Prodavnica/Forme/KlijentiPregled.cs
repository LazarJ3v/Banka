using NHibernate;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica.Forme
{
    public partial class KlijentiPregled : Form
    {
        public KlijentiPregled()
        {
            InitializeComponent();
        }

        private void KlijentiPregled_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                List<FizickoLice> fizickaLica = s.Query<FizickoLice>().ToList();
                List<PravnoLice> pravnaLica = s.Query<PravnoLice>().ToList();

                // ==========================================
                // FIZIČKA LICA - povezujemo postojeće kolone
                // ==========================================
                List<FizickoLicePregled> fizickoPregled = fizickaLica.Select(fl => new FizickoLicePregled(
                    fl.Id,
                    fl.Ime,
                    fl.Prezime,
                    fl.Jmbg,
                    fl.BrojLicneKarte,
                    fl.DatumRodjenja,
                    fl.Adresa,
                    fl.Grad,
                    fl.Telefon,
                    fl.Email,
                    fl.Status,
                    fl.Komentar
                )).ToList();

                // Isključujemo automatsko generisanje kolona
                dgvFizickaLica.AutoGenerateColumns = false;

                // Povezujemo postojeće kolone sa property-jima
                dgvFizickaLica.Columns["colIme"].DataPropertyName = "Ime";
                dgvFizickaLica.Columns["colPrezime"].DataPropertyName = "Prezime";
                dgvFizickaLica.Columns["colJmbg"].DataPropertyName = "Jmbg";
                dgvFizickaLica.Columns["colBrLicne"].DataPropertyName = "BrojLicneKarte";
                dgvFizickaLica.Columns["colGrad"].DataPropertyName = "Grad";
                dgvFizickaLica.Columns["colTelefon"].DataPropertyName = "Telefon";
                dgvFizickaLica.Columns["colEmail"].DataPropertyName = "Email";
                dgvFizickaLica.Columns["colStatus"].DataPropertyName = "Status";

                // Bindujemo podatke
                dgvFizickaLica.DataSource = null;
                dgvFizickaLica.DataSource = fizickoPregled;

                // ==========================================
                // PRAVNA LICA - povezujemo postojeće kolone
                // ==========================================
                List<PravnoLicePregled> pravnoPregled = pravnaLica.Select(pl => new PravnoLicePregled(
                    pl.Id,
                    pl.NazivFirme,
                    pl.Pib,
                    pl.Adresa,
                    pl.Grad,
                    pl.Telefon,
                    pl.Email,
                    pl.Status,
                    pl.Komentar
                )).ToList();

                // Isključujemo automatsko generisanje kolona
                dgvPravnaLica.AutoGenerateColumns = false;

                // Povezujemo postojeće kolone sa property-jima
                dgvPravnaLica.Columns["colNazivFirme"].DataPropertyName = "NazivFirme";
                dgvPravnaLica.Columns["colPib"].DataPropertyName = "Pib";
                dgvPravnaLica.Columns["colAdresa"].DataPropertyName = "Adresa";
                dgvPravnaLica.Columns["colGrad2"].DataPropertyName = "Grad";
                dgvPravnaLica.Columns["colTelefon2"].DataPropertyName = "Telefon";
                dgvPravnaLica.Columns["colEmail2"].DataPropertyName = "Email";
                dgvPravnaLica.Columns["colStatus2"].DataPropertyName = "Status";

                // Bindujemo podatke
                dgvPravnaLica.DataSource = null;
                dgvPravnaLica.DataSource = pravnoPregled;

                // ==========================================
                // AUTOMATSKI RESIZE
                // ==========================================
                dgvFizickaLica.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvPravnaLica.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // ==========================================
                // PRIKAZ BROJA KLIJENATA
                // ==========================================
                lblInfo.Text = (fizickoPregled.Count + pravnoPregled.Count).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka: {ex.Message}", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                s.Close();
            }
        }
    }
}
