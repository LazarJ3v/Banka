namespace Prodavnica.Forme
{
    partial class KlijentDodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbTipKlijenta = new GroupBox();
            rbPravnoLice = new RadioButton();
            rbFizickoLice = new RadioButton();
            gbPodaciFizickoLice = new GroupBox();
            rtbKomentar = new RichTextBox();
            lblKomentar = new Label();
            tbEmail = new TextBox();
            lblEmail = new Label();
            tbTelefon = new TextBox();
            lblTelefon = new Label();
            tbGrad = new TextBox();
            lblGrad = new Label();
            tbAdresa = new TextBox();
            lblAdresa = new Label();
            lblDatumRodjenja = new Label();
            dtpDatumRodjenja = new DateTimePicker();
            tbBrojLicneKarte = new TextBox();
            lblBrojLicneKarte = new Label();
            tbJMBG = new TextBox();
            lblJMBG = new Label();
            tbPrezime = new TextBox();
            lblPrezime = new Label();
            tbIme = new TextBox();
            lblIme = new Label();
            gbPodaciPravnoLice = new GroupBox();
            lblPIB = new Label();
            rtbKomentarPravno = new RichTextBox();
            lblKomentarPravno = new Label();
            tbEmailPravno = new TextBox();
            lblEmailPravno = new Label();
            tbTelefonPravno = new TextBox();
            lblTelefonPravno = new Label();
            tbGradPravno = new TextBox();
            lblGradPravno = new Label();
            tbAdresaPravno = new TextBox();
            lblAdresaPravno = new Label();
            tbPIB = new TextBox();
            tbNazivFirme = new TextBox();
            lblNazivFirme = new Label();
            btnSacuvaj = new Button();
            gbTipKlijenta.SuspendLayout();
            gbPodaciFizickoLice.SuspendLayout();
            gbPodaciPravnoLice.SuspendLayout();
            SuspendLayout();
            // 
            // gbTipKlijenta
            // 
            gbTipKlijenta.Controls.Add(rbPravnoLice);
            gbTipKlijenta.Controls.Add(rbFizickoLice);
            gbTipKlijenta.Location = new Point(17, 20);
            gbTipKlijenta.Margin = new Padding(4, 5, 4, 5);
            gbTipKlijenta.Name = "gbTipKlijenta";
            gbTipKlijenta.Padding = new Padding(4, 5, 4, 5);
            gbTipKlijenta.Size = new Size(816, 87);
            gbTipKlijenta.TabIndex = 0;
            gbTipKlijenta.TabStop = false;
            gbTipKlijenta.Text = "Tip klijenta";
            // 
            // rbPravnoLice
            // 
            rbPravnoLice.AutoSize = true;
            rbPravnoLice.Location = new Point(681, 34);
            rbPravnoLice.Margin = new Padding(4, 5, 4, 5);
            rbPravnoLice.Name = "rbPravnoLice";
            rbPravnoLice.Size = new Size(122, 29);
            rbPravnoLice.TabIndex = 1;
            rbPravnoLice.TabStop = true;
            rbPravnoLice.Text = "Pravno lice";
            rbPravnoLice.UseVisualStyleBackColor = true;
            // 
            // rbFizickoLice
            // 
            rbFizickoLice.AutoSize = true;
            rbFizickoLice.Location = new Point(555, 34);
            rbFizickoLice.Margin = new Padding(4, 5, 4, 5);
            rbFizickoLice.Name = "rbFizickoLice";
            rbFizickoLice.Size = new Size(120, 29);
            rbFizickoLice.TabIndex = 0;
            rbFizickoLice.TabStop = true;
            rbFizickoLice.Text = "Fizičko lice";
            rbFizickoLice.UseVisualStyleBackColor = true;
            rbFizickoLice.CheckedChanged += rbFizickoLice_CheckedChanged;
            // 
            // gbPodaciFizickoLice
            // 
            gbPodaciFizickoLice.Controls.Add(rtbKomentar);
            gbPodaciFizickoLice.Controls.Add(lblKomentar);
            gbPodaciFizickoLice.Controls.Add(tbEmail);
            gbPodaciFizickoLice.Controls.Add(lblEmail);
            gbPodaciFizickoLice.Controls.Add(tbTelefon);
            gbPodaciFizickoLice.Controls.Add(lblTelefon);
            gbPodaciFizickoLice.Controls.Add(tbGrad);
            gbPodaciFizickoLice.Controls.Add(lblGrad);
            gbPodaciFizickoLice.Controls.Add(tbAdresa);
            gbPodaciFizickoLice.Controls.Add(lblAdresa);
            gbPodaciFizickoLice.Controls.Add(lblDatumRodjenja);
            gbPodaciFizickoLice.Controls.Add(dtpDatumRodjenja);
            gbPodaciFizickoLice.Controls.Add(tbBrojLicneKarte);
            gbPodaciFizickoLice.Controls.Add(lblBrojLicneKarte);
            gbPodaciFizickoLice.Controls.Add(tbJMBG);
            gbPodaciFizickoLice.Controls.Add(lblJMBG);
            gbPodaciFizickoLice.Controls.Add(tbPrezime);
            gbPodaciFizickoLice.Controls.Add(lblPrezime);
            gbPodaciFizickoLice.Controls.Add(tbIme);
            gbPodaciFizickoLice.Controls.Add(lblIme);
            gbPodaciFizickoLice.Location = new Point(17, 117);
            gbPodaciFizickoLice.Margin = new Padding(4, 5, 4, 5);
            gbPodaciFizickoLice.Name = "gbPodaciFizickoLice";
            gbPodaciFizickoLice.Padding = new Padding(4, 5, 4, 5);
            gbPodaciFizickoLice.Size = new Size(816, 343);
            gbPodaciFizickoLice.TabIndex = 1;
            gbPodaciFizickoLice.TabStop = false;
            gbPodaciFizickoLice.Text = "Podaci o fizičkom licu";
            // 
            // rtbKomentar
            // 
            rtbKomentar.Location = new Point(548, 184);
            rtbKomentar.Margin = new Padding(4, 5, 4, 5);
            rtbKomentar.Name = "rtbKomentar";
            rtbKomentar.Size = new Size(255, 132);
            rtbKomentar.TabIndex = 19;
            rtbKomentar.Text = "";
            // 
            // lblKomentar
            // 
            lblKomentar.AutoSize = true;
            lblKomentar.Location = new Point(451, 189);
            lblKomentar.Margin = new Padding(4, 0, 4, 0);
            lblKomentar.Name = "lblKomentar";
            lblKomentar.Size = new Size(93, 25);
            lblKomentar.TabIndex = 18;
            lblKomentar.Text = "Komentar:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(548, 135);
            tbEmail.Margin = new Padding(4, 5, 4, 5);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(255, 31);
            tbEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(484, 140);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // tbTelefon
            // 
            tbTelefon.Location = new Point(548, 87);
            tbTelefon.Margin = new Padding(4, 5, 4, 5);
            tbTelefon.Name = "tbTelefon";
            tbTelefon.Size = new Size(255, 31);
            tbTelefon.TabIndex = 15;
            tbTelefon.KeyPress += tbTelefon_KeyPress;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(470, 92);
            lblTelefon.Margin = new Padding(4, 0, 4, 0);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(72, 25);
            lblTelefon.TabIndex = 14;
            lblTelefon.Text = "Telefon:";
            // 
            // tbGrad
            // 
            tbGrad.Location = new Point(548, 39);
            tbGrad.Margin = new Padding(4, 5, 4, 5);
            tbGrad.Name = "tbGrad";
            tbGrad.Size = new Size(255, 31);
            tbGrad.TabIndex = 13;
            tbGrad.KeyPress += tbGrad_KeyPress;
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(488, 44);
            lblGrad.Margin = new Padding(4, 0, 4, 0);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(54, 25);
            lblGrad.TabIndex = 12;
            lblGrad.Text = "Grad:";
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(149, 280);
            tbAdresa.Margin = new Padding(4, 5, 4, 5);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(255, 31);
            tbAdresa.TabIndex = 11;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(73, 285);
            lblAdresa.Margin = new Padding(4, 0, 4, 0);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(71, 25);
            lblAdresa.TabIndex = 10;
            lblAdresa.Text = "Adresa:";
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize = true;
            lblDatumRodjenja.Location = new Point(12, 242);
            lblDatumRodjenja.Margin = new Padding(4, 0, 4, 0);
            lblDatumRodjenja.Name = "lblDatumRodjenja";
            lblDatumRodjenja.Size = new Size(135, 25);
            lblDatumRodjenja.TabIndex = 9;
            lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Format = DateTimePickerFormat.Short;
            dtpDatumRodjenja.Location = new Point(149, 232);
            dtpDatumRodjenja.Margin = new Padding(4, 5, 4, 5);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(255, 31);
            dtpDatumRodjenja.TabIndex = 8;
            // 
            // tbBrojLicneKarte
            // 
            tbBrojLicneKarte.Location = new Point(149, 184);
            tbBrojLicneKarte.Margin = new Padding(4, 5, 4, 5);
            tbBrojLicneKarte.Name = "tbBrojLicneKarte";
            tbBrojLicneKarte.Size = new Size(255, 31);
            tbBrojLicneKarte.TabIndex = 7;
            tbBrojLicneKarte.KeyPress += tbBrojLicneKarte_KeyPress;
            // 
            // lblBrojLicneKarte
            // 
            lblBrojLicneKarte.AutoSize = true;
            lblBrojLicneKarte.Location = new Point(13, 189);
            lblBrojLicneKarte.Margin = new Padding(4, 0, 4, 0);
            lblBrojLicneKarte.Name = "lblBrojLicneKarte";
            lblBrojLicneKarte.Size = new Size(131, 25);
            lblBrojLicneKarte.TabIndex = 6;
            lblBrojLicneKarte.Text = "Broj lične karte:";
            // 
            // tbJMBG
            // 
            tbJMBG.Location = new Point(149, 135);
            tbJMBG.Margin = new Padding(4, 5, 4, 5);
            tbJMBG.Name = "tbJMBG";
            tbJMBG.Size = new Size(255, 31);
            tbJMBG.TabIndex = 5;
            tbJMBG.KeyPress += tbJMBG_KeyPress;
            // 
            // lblJMBG
            // 
            lblJMBG.AutoSize = true;
            lblJMBG.Location = new Point(82, 140);
            lblJMBG.Margin = new Padding(4, 0, 4, 0);
            lblJMBG.Name = "lblJMBG";
            lblJMBG.Size = new Size(60, 25);
            lblJMBG.TabIndex = 4;
            lblJMBG.Text = "JMBG:";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(149, 87);
            tbPrezime.Margin = new Padding(4, 5, 4, 5);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(255, 31);
            tbPrezime.TabIndex = 3;
            tbPrezime.KeyPress += tbPrezime_KeyPress;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(65, 92);
            lblPrezime.Margin = new Padding(4, 0, 4, 0);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(78, 25);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(149, 39);
            tbIme.Margin = new Padding(4, 5, 4, 5);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(255, 31);
            tbIme.TabIndex = 1;
            tbIme.KeyPress += tbIme_KeyPress;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(98, 44);
            lblIme.Margin = new Padding(4, 0, 4, 0);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(46, 25);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime:";
            // 
            // gbPodaciPravnoLice
            // 
            gbPodaciPravnoLice.Controls.Add(lblPIB);
            gbPodaciPravnoLice.Controls.Add(rtbKomentarPravno);
            gbPodaciPravnoLice.Controls.Add(lblKomentarPravno);
            gbPodaciPravnoLice.Controls.Add(tbEmailPravno);
            gbPodaciPravnoLice.Controls.Add(lblEmailPravno);
            gbPodaciPravnoLice.Controls.Add(tbTelefonPravno);
            gbPodaciPravnoLice.Controls.Add(lblTelefonPravno);
            gbPodaciPravnoLice.Controls.Add(tbGradPravno);
            gbPodaciPravnoLice.Controls.Add(lblGradPravno);
            gbPodaciPravnoLice.Controls.Add(tbAdresaPravno);
            gbPodaciPravnoLice.Controls.Add(lblAdresaPravno);
            gbPodaciPravnoLice.Controls.Add(tbPIB);
            gbPodaciPravnoLice.Controls.Add(tbNazivFirme);
            gbPodaciPravnoLice.Controls.Add(lblNazivFirme);
            gbPodaciPravnoLice.Location = new Point(17, 117);
            gbPodaciPravnoLice.Margin = new Padding(4, 5, 4, 5);
            gbPodaciPravnoLice.Name = "gbPodaciPravnoLice";
            gbPodaciPravnoLice.Padding = new Padding(4, 5, 4, 5);
            gbPodaciPravnoLice.Size = new Size(816, 343);
            gbPodaciPravnoLice.TabIndex = 20;
            gbPodaciPravnoLice.TabStop = false;
            gbPodaciPravnoLice.Text = "Podaci o pravnom licu";
            // 
            // lblPIB
            // 
            lblPIB.AutoSize = true;
            lblPIB.Location = new Point(100, 90);
            lblPIB.Name = "lblPIB";
            lblPIB.Size = new Size(41, 25);
            lblPIB.TabIndex = 20;
            lblPIB.Text = "PIB:";
            // 
            // rtbKomentarPravno
            // 
            rtbKomentarPravno.Location = new Point(548, 184);
            rtbKomentarPravno.Margin = new Padding(4, 5, 4, 5);
            rtbKomentarPravno.Name = "rtbKomentarPravno";
            rtbKomentarPravno.Size = new Size(255, 132);
            rtbKomentarPravno.TabIndex = 19;
            rtbKomentarPravno.Text = "";
            // 
            // lblKomentarPravno
            // 
            lblKomentarPravno.AutoSize = true;
            lblKomentarPravno.Location = new Point(449, 187);
            lblKomentarPravno.Margin = new Padding(4, 0, 4, 0);
            lblKomentarPravno.Name = "lblKomentarPravno";
            lblKomentarPravno.Size = new Size(93, 25);
            lblKomentarPravno.TabIndex = 18;
            lblKomentarPravno.Text = "Komentar:";
            // 
            // tbEmailPravno
            // 
            tbEmailPravno.Location = new Point(548, 135);
            tbEmailPravno.Margin = new Padding(4, 5, 4, 5);
            tbEmailPravno.Name = "tbEmailPravno";
            tbEmailPravno.Size = new Size(255, 31);
            tbEmailPravno.TabIndex = 17;
            // 
            // lblEmailPravno
            // 
            lblEmailPravno.AutoSize = true;
            lblEmailPravno.Location = new Point(482, 138);
            lblEmailPravno.Margin = new Padding(4, 0, 4, 0);
            lblEmailPravno.Name = "lblEmailPravno";
            lblEmailPravno.Size = new Size(58, 25);
            lblEmailPravno.TabIndex = 16;
            lblEmailPravno.Text = "Email:";
            // 
            // tbTelefonPravno
            // 
            tbTelefonPravno.Location = new Point(548, 87);
            tbTelefonPravno.Margin = new Padding(4, 5, 4, 5);
            tbTelefonPravno.Name = "tbTelefonPravno";
            tbTelefonPravno.Size = new Size(255, 31);
            tbTelefonPravno.TabIndex = 15;
            // 
            // lblTelefonPravno
            // 
            lblTelefonPravno.AutoSize = true;
            lblTelefonPravno.Location = new Point(468, 90);
            lblTelefonPravno.Margin = new Padding(4, 0, 4, 0);
            lblTelefonPravno.Name = "lblTelefonPravno";
            lblTelefonPravno.Size = new Size(72, 25);
            lblTelefonPravno.TabIndex = 14;
            lblTelefonPravno.Text = "Telefon:";
            // 
            // tbGradPravno
            // 
            tbGradPravno.Location = new Point(548, 39);
            tbGradPravno.Margin = new Padding(4, 5, 4, 5);
            tbGradPravno.Name = "tbGradPravno";
            tbGradPravno.Size = new Size(255, 31);
            tbGradPravno.TabIndex = 13;
            // 
            // lblGradPravno
            // 
            lblGradPravno.AutoSize = true;
            lblGradPravno.Location = new Point(486, 42);
            lblGradPravno.Margin = new Padding(4, 0, 4, 0);
            lblGradPravno.Name = "lblGradPravno";
            lblGradPravno.Size = new Size(54, 25);
            lblGradPravno.TabIndex = 12;
            lblGradPravno.Text = "Grad:";
            // 
            // tbAdresaPravno
            // 
            tbAdresaPravno.Location = new Point(149, 135);
            tbAdresaPravno.Margin = new Padding(4, 5, 4, 5);
            tbAdresaPravno.Name = "tbAdresaPravno";
            tbAdresaPravno.Size = new Size(255, 31);
            tbAdresaPravno.TabIndex = 11;
            // 
            // lblAdresaPravno
            // 
            lblAdresaPravno.AutoSize = true;
            lblAdresaPravno.Location = new Point(70, 136);
            lblAdresaPravno.Margin = new Padding(4, 0, 4, 0);
            lblAdresaPravno.Name = "lblAdresaPravno";
            lblAdresaPravno.Size = new Size(71, 25);
            lblAdresaPravno.TabIndex = 10;
            lblAdresaPravno.Text = "Adresa:";
            // 
            // tbPIB
            // 
            tbPIB.Location = new Point(149, 87);
            tbPIB.Margin = new Padding(4, 5, 4, 5);
            tbPIB.Name = "tbPIB";
            tbPIB.Size = new Size(255, 31);
            tbPIB.TabIndex = 3;
            // 
            // tbNazivFirme
            // 
            tbNazivFirme.Location = new Point(149, 39);
            tbNazivFirme.Margin = new Padding(4, 5, 4, 5);
            tbNazivFirme.Name = "tbNazivFirme";
            tbNazivFirme.Size = new Size(255, 31);
            tbNazivFirme.TabIndex = 1;
            // 
            // lblNazivFirme
            // 
            lblNazivFirme.AutoSize = true;
            lblNazivFirme.Location = new Point(36, 42);
            lblNazivFirme.Margin = new Padding(4, 0, 4, 0);
            lblNazivFirme.Name = "lblNazivFirme";
            lblNazivFirme.Size = new Size(105, 25);
            lblNazivFirme.TabIndex = 0;
            lblNazivFirme.Text = "Naziv firme:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(721, 474);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(112, 34);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // KlijentDodaj
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 520);
            Controls.Add(gbPodaciPravnoLice);
            Controls.Add(btnSacuvaj);
            Controls.Add(gbPodaciFizickoLice);
            Controls.Add(gbTipKlijenta);
            Margin = new Padding(4, 5, 4, 5);
            Name = "KlijentDodaj";
            Text = "KlijentDodaj";
            gbTipKlijenta.ResumeLayout(false);
            gbTipKlijenta.PerformLayout();
            gbPodaciFizickoLice.ResumeLayout(false);
            gbPodaciFizickoLice.PerformLayout();
            gbPodaciPravnoLice.ResumeLayout(false);
            gbPodaciPravnoLice.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTipKlijenta;
        private RadioButton rbPravnoLice;
        private RadioButton rbFizickoLice;
        private GroupBox gbPodaciFizickoLice;
        private Label lblIme;
        private TextBox tbPrezime;
        private Label lblPrezime;
        private TextBox tbIme;
        private TextBox tbJMBG;
        private Label lblJMBG;
        private TextBox tbBrojLicneKarte;
        private Label lblBrojLicneKarte;
        private TextBox tbGrad;
        private Label lblGrad;
        private TextBox tbAdresa;
        private Label lblAdresa;
        private Label lblDatumRodjenja;
        private DateTimePicker dtpDatumRodjenja;
        private TextBox tbEmail;
        private Label lblEmail;
        private TextBox tbTelefon;
        private Label lblTelefon;
        private RichTextBox rtbKomentar;
        private Label lblKomentar;
        private Button btnSacuvaj;
        private GroupBox gbPodaciPravnoLice;
        private RichTextBox rtbKomentarPravno;
        private Label lblKomentarPravno;
        private TextBox tbEmailPravno;
        private Label lblEmailPravno;
        private TextBox tbTelefonPravno;
        private Label lblTelefonPravno;
        private TextBox tbGradPravno;
        private Label lblGradPravno;
        private TextBox tbAdresaPravno;
        private Label lblAdresaPravno;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox tbPIB;
        private Label label9;
        private TextBox tbNazivFirme;
        private Label lblNazivFirme;
        private Label lblPIB;
    }
}