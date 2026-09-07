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
    public partial class KlijentDodaj : BaseForm
    {
        public KlijentDodaj() : base()
        {
            InitializeComponent();
            StilizujGroupBox(
                gbTipKlijenta,
                gbPodaciFizickoLice,
                gbPodaciPravnoLice);
            StilizujLabel(
                lblAdresa,
                lblAdresaPravno,
                lblBrojLicneKarte,
                lblDatumRodjenja,
                lblEmail,
                lblEmailPravno,
                lblGrad,
                lblGradPravno,
                lblIme,
                lblJMBG,
                lblKomentar,
                lblKomentarPravno,
                lblPrezime,
                lblTelefon,
                lblTelefonPravno,
                lblNazivFirme,
                lblPIB
                );
            StilizujTextBox(
                tbAdresa,
                tbAdresaPravno,
                tbBrojLicneKarte,
                tbIme,
                tbJMBG,
                tbPrezime,
                tbTelefon,
                tbTelefonPravno,
                tbPrezime,
                tbGrad,
                tbGradPravno,
                tbEmail,
                tbEmailPravno,
                tbNazivFirme,
                tbPIB
                );
            StilizujRadioButton(
                rbFizickoLice,
                rbPravnoLice
                );
            StilizujRichTextBox(
                rtbKomentar,
                rtbKomentarPravno
                );
            StilizujDateTimePicker(
                dtpDatumRodjenja);
            StilizujButton(
                btnSacuvaj);
        }

        private void tbJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBrojLicneKarte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbFizickoLice_CheckedChanged(object sender, EventArgs e)
        {
            gbPodaciFizickoLice.Visible = rbFizickoLice.Checked;
            gbPodaciPravnoLice.Visible = rbPravnoLice.Checked;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (rbFizickoLice.Checked)
            {
                FizickoLiceBasic klijent = new FizickoLiceBasic();
                klijent.Ime = tbIme.Text.Trim();
                klijent.Prezime = tbPrezime.Text.Trim();
                klijent.Jmbg = tbJMBG.Text.Trim();
                klijent.BrojLicneKarte = tbBrojLicneKarte.Text.Trim();
                klijent.DatumRodjenja = dtpDatumRodjenja.Value;
                klijent.Adresa = tbAdresa.Text.Trim();
                klijent.Grad = tbGrad.Text.Trim();
                klijent.Telefon = tbTelefon.Text.Trim();
                klijent.Email = tbEmail.Text.Trim();
                klijent.Status = KlijentStatus.Aktivan.ToString();
                klijent.Komentar = rtbKomentar.Text.Trim();

                try
                {
                    DTOManager.DodajFizickoLice(klijent);
                    MessageBox.Show("Uspešno je dodat klijent");
                    this.Close();
                }
                catch (Exception ex)
                {
                    //handle exception
                }
            }
            else
            {
                PravnoLiceBasic klijent = new PravnoLiceBasic();
                klijent.NazivFirme = tbNazivFirme.Text.Trim();
                klijent.Pib = tbPIB.Text.Trim();
                klijent.Adresa = tbAdresaPravno.Text.Trim();
                klijent.Grad = tbGradPravno.Text.Trim();
                klijent.Telefon = tbTelefonPravno.Text.Trim();
                klijent.Email = tbEmailPravno.Text.Trim();
                klijent.Status = KlijentStatus.Aktivan.ToString();
                klijent.Komentar = rtbKomentarPravno.Text.Trim();

                try
                {
                    DTOManager.DodajPravnoLice(klijent);
                    MessageBox.Show("Uspešno je dodat klijent");
                    this.Close();
                }
                catch (Exception ex)
                {
                    //handle exception
                }
            }
        }
    }
}
