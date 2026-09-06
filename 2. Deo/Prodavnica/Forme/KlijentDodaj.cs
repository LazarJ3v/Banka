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
                gbPodaci);
            StilizujLabel(
                lblAdresa,
                lblBrojLicneKarte,
                lblDatumRodjenja,
                lblEmail,
                lblGrad,
                lblIme,
                lblJMBG,
                lblKomentar,
                lblPrezime,
                lblTelefon);
            StilizujTextBox(
                tbAdresa,
                tbBrojLicneKarte,
                tbIme,
                tbJMBG,
                tbPrezime,
                tbTelefon,
                tbPrezime,
                tbGrad,
                tbEmail
                );
            StilizujRadioButton(
                rbFizickoLice,
                rbPravnoLice
                );
            StilizujRichTextBox(
                rtbKomentar);
            StilizujDateTimePicker(
                dtpDatumRodjenja);
            StilizujButton(
                btnSacuvaj);
        }

        private void tbJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBrojLicneKarte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
