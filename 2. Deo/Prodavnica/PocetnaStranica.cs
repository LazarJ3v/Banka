using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;

namespace Prodavnica
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                int pl = s.QueryOver<Entiteti.PravnoLice>().RowCount();
                int fl = s.QueryOver<Entiteti.FizickoLice>().RowCount();
                infoKlijenti.Text = (pl + fl).ToString();
                infoRacuni.Text = s.QueryOver<Entiteti.Racun>().RowCount().ToString();
                infoTransakcije.Text = s.QueryOver<Entiteti.Transakcija>().RowCount().ToString();
                infoKrediti.Text = s.QueryOver<Entiteti.Kredit>().RowCount().ToString();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            Forme.KlijentiPregled forma = new Forme.KlijentiPregled();
            forma.Show();
        }
    }
}
