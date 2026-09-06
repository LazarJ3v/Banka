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
    public partial class FizickoLiceIzmena : BaseForm
    {
        private FizickoLicePregled fizickoLice;
        
        enum Status
        {
            Aktivan,
            Neaktivan
        }
        public FizickoLiceIzmena(FizickoLicePregled _fizickoLice) : base()
        {
            InitializeComponent();
            fizickoLice = _fizickoLice;
            StilizujLabel(
                lblIme,
                lblPrezime,
                lblJmbg,
                lblBrLicneKarte,
                lblAdresa,
                lblGrad,
                lblTelefon,
                lblEmail,
                lblStatus,
                lblKomentar);
            StilizujComboBox(
                cbStatus);
            StilizujTextBox(
                tbIme,
                tbPrezime,
                tbJmbg,
                tbBrojLicneKarte,
                tbAdresa,
                tbGrad,
                tbTelefon,
                tbEmail,
                tbKomentar);
            StilizujButton(btnSacuvajIzmene);
        }

        private void FizickoLiceIzmeni_Load(object sender, EventArgs e)
        {
            tbIme.Text = fizickoLice.Ime;
            tbPrezime.Text = fizickoLice.Prezime;
            tbJmbg.Text = fizickoLice.Jmbg;
            tbBrojLicneKarte.Text = fizickoLice.BrojLicneKarte;
            tbAdresa.Text = fizickoLice.Adresa;
            tbGrad.Text = fizickoLice.Grad;
            tbTelefon.Text = fizickoLice.Telefon;
            tbEmail.Text = fizickoLice.Email;
            cbStatus.Items.Add(Status.Aktivan);
            cbStatus.Items.Add(Status.Neaktivan);
            cbStatus.Text = fizickoLice.Status;
            tbKomentar.Text = fizickoLice.Komentar;
            dtpDatumRodjenja.Text = fizickoLice.DatumRodjenja.ToString();
        }
    }
}
