using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica
{
    public partial class PocetnaStranica : Forme.BaseForm
    {
        public PocetnaStranica() : base()
        {
            InitializeComponent();
            StilizujButton(
                btnKlijenti,
                btnRacuni,
                btnTransakcije,
                btnKrediti,
                btnDepoziti,
                btnKamate,
                btnSigurnosneKontrole);
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            Forme.KlijentiPregled forma = new Forme.KlijentiPregled();
            forma.Show();
        }
    }
}
