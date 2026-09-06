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
    public partial class KlijentiPregled : BaseForm
    {
        public KlijentiPregled()
        {
            InitializeComponent();
            StilizujButton([
                btnDetalji,
                btnDodajKlijenta,
                btnIzmeniKorisnika,
                btnObrisiKorisnika,
                btnOsvezi,
                btnPretrazi
                ]);
            StilizujGroupBox([
                groupBox1,
                groupBox2,
                groupBoxPretraga
                ]);
            StilizujDataGridView([
                dgvFizickaLica,
                dgvPravnaLica
                ]);
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

                dgvFizickaLica.AutoGenerateColumns = false;
                dgvFizickaLica.DataSource = null;
                dgvFizickaLica.Rows.Clear();

                foreach (var fl in fizickoPregled)
                {
                    int rowIndex = dgvFizickaLica.Rows.Add();
                    var row = dgvFizickaLica.Rows[rowIndex];

                    row.Cells["colIme"].Value = fl.ToString();
                    row.Cells["colJmbg"].Value = fl.Jmbg;
                    row.Cells["colBrLicne"].Value = fl.BrojLicneKarte;
                    row.Cells["colGrad"].Value = fl.Grad;
                    row.Cells["colTelefon"].Value = fl.Telefon;
                    row.Cells["colEmail"].Value = fl.Email;
                    row.Cells["colStatus"].Value = fl.Status;

                    row.Tag = fl; // omogućava kasniji pristup celom objektu preko reda
                }

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

                dgvPravnaLica.AutoGenerateColumns = false;
                dgvPravnaLica.DataSource = null;
                dgvPravnaLica.Rows.Clear();

                foreach (var pl in pravnoPregled)
                {
                    int rowIndex = dgvPravnaLica.Rows.Add();
                    var row = dgvPravnaLica.Rows[rowIndex];

                    row.Cells["colNazivFirme"].Value = pl.NazivFirme;
                    row.Cells["colPib"].Value = pl.Pib;
                    row.Cells["colAdresa"].Value = pl.Adresa;
                    row.Cells["colGrad2"].Value = pl.Grad;
                    row.Cells["colTelefon2"].Value = pl.Telefon;
                    row.Cells["colEmail2"].Value = pl.Email;
                    row.Cells["colStatus2"].Value = pl.Status;

                    row.Tag = pl;
                }

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
