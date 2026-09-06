namespace Prodavnica.Forme
{
    partial class KlijentiPregled
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
            lblPretraga = new Label();
            txtBoxPretraga = new TextBox();
            lblTipKlijenta = new Label();
            cmbTip = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnPretrazi = new Button();
            btnDodajKlijenta = new Button();
            btnIzmeniKorisnika = new Button();
            btnObrisiKorisnika = new Button();
            btnDetalji = new Button();
            btnOsvezi = new Button();
            groupBox1 = new GroupBox();
            dgvFizickaLica = new DataGridView();
            groupBox2 = new GroupBox();
            dgvPravnaLica = new DataGridView();
            colNazivFirme = new DataGridViewTextBoxColumn();
            colPib = new DataGridViewTextBoxColumn();
            colAdresa = new DataGridViewTextBoxColumn();
            colGrad2 = new DataGridViewTextBoxColumn();
            colTelefon2 = new DataGridViewTextBoxColumn();
            colEmail2 = new DataGridViewTextBoxColumn();
            colStatus2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblInfo = new Label();
            colIme = new DataGridViewTextBoxColumn();
            colJmbg = new DataGridViewTextBoxColumn();
            colBrLicne = new DataGridViewTextBoxColumn();
            colGrad = new DataGridViewTextBoxColumn();
            colTelefon = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFizickaLica).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPravnaLica).BeginInit();
            SuspendLayout();
            // 
            // lblPretraga
            // 
            lblPretraga.AutoSize = true;
            lblPretraga.Location = new Point(12, 14);
            lblPretraga.Name = "lblPretraga";
            lblPretraga.Size = new Size(109, 23);
            lblPretraga.TabIndex = 0;
            lblPretraga.Text = "Pretraga:";
            // 
            // txtBoxPretraga
            // 
            txtBoxPretraga.BackColor = SystemColors.GradientInactiveCaption;
            txtBoxPretraga.Location = new Point(118, 11);
            txtBoxPretraga.Name = "txtBoxPretraga";
            txtBoxPretraga.Size = new Size(182, 31);
            txtBoxPretraga.TabIndex = 1;
            // 
            // lblTipKlijenta
            // 
            lblTipKlijenta.AutoSize = true;
            lblTipKlijenta.Location = new Point(315, 15);
            lblTipKlijenta.Name = "lblTipKlijenta";
            lblTipKlijenta.Size = new Size(54, 23);
            lblTipKlijenta.TabIndex = 2;
            lblTipKlijenta.Text = "Tip:";
            // 
            // cmbTip
            // 
            cmbTip.BackColor = SystemColors.GradientInactiveCaption;
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(364, 11);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(156, 31);
            cmbTip.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(537, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(87, 23);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = SystemColors.GradientInactiveCaption;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(621, 12);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 31);
            cmbStatus.TabIndex = 5;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = SystemColors.GradientInactiveCaption;
            btnPretrazi.Location = new Point(777, 11);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(112, 34);
            btnPretrazi.TabIndex = 7;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // btnDodajKlijenta
            // 
            btnDodajKlijenta.BackColor = SystemColors.GradientInactiveCaption;
            btnDodajKlijenta.Location = new Point(11, 455);
            btnDodajKlijenta.Name = "btnDodajKlijenta";
            btnDodajKlijenta.Size = new Size(128, 64);
            btnDodajKlijenta.TabIndex = 8;
            btnDodajKlijenta.Text = "Dodaj";
            btnDodajKlijenta.UseVisualStyleBackColor = false;
            // 
            // btnIzmeniKorisnika
            // 
            btnIzmeniKorisnika.BackColor = SystemColors.GradientInactiveCaption;
            btnIzmeniKorisnika.Location = new Point(145, 455);
            btnIzmeniKorisnika.Name = "btnIzmeniKorisnika";
            btnIzmeniKorisnika.Size = new Size(128, 64);
            btnIzmeniKorisnika.TabIndex = 9;
            btnIzmeniKorisnika.Text = "Izmeni";
            btnIzmeniKorisnika.UseVisualStyleBackColor = false;
            // 
            // btnObrisiKorisnika
            // 
            btnObrisiKorisnika.BackColor = SystemColors.GradientInactiveCaption;
            btnObrisiKorisnika.Location = new Point(279, 455);
            btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            btnObrisiKorisnika.Size = new Size(128, 64);
            btnObrisiKorisnika.TabIndex = 10;
            btnObrisiKorisnika.Text = "Obriši";
            btnObrisiKorisnika.UseVisualStyleBackColor = false;
            // 
            // btnDetalji
            // 
            btnDetalji.BackColor = SystemColors.GradientInactiveCaption;
            btnDetalji.Location = new Point(413, 455);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(128, 64);
            btnDetalji.TabIndex = 11;
            btnDetalji.Text = "Detalji";
            btnDetalji.UseVisualStyleBackColor = false;
            // 
            // btnOsvezi
            // 
            btnOsvezi.BackColor = SystemColors.GradientInactiveCaption;
            btnOsvezi.Location = new Point(547, 455);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(128, 64);
            btnOsvezi.TabIndex = 14;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvFizickaLica);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 194);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fizička lica";
            // 
            // dgvFizickaLica
            // 
            dgvFizickaLica.AllowUserToAddRows = false;
            dgvFizickaLica.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvFizickaLica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFizickaLica.Columns.AddRange(new DataGridViewColumn[] { colIme, colJmbg, colBrLicne, colGrad, colTelefon, colEmail, colStatus });
            dgvFizickaLica.Location = new Point(6, 22);
            dgvFizickaLica.Name = "dgvFizickaLica";
            dgvFizickaLica.RowHeadersWidth = 62;
            dgvFizickaLica.Size = new Size(865, 166);
            dgvFizickaLica.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPravnaLica);
            groupBox2.Location = new Point(11, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(877, 194);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pravna lica";
            // 
            // dgvPravnaLica
            // 
            dgvPravnaLica.AllowUserToAddRows = false;
            dgvPravnaLica.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPravnaLica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPravnaLica.Columns.AddRange(new DataGridViewColumn[] { colNazivFirme, colPib, colAdresa, colGrad2, colTelefon2, colEmail2, colStatus2 });
            dgvPravnaLica.Location = new Point(7, 22);
            dgvPravnaLica.Name = "dgvPravnaLica";
            dgvPravnaLica.RowHeadersWidth = 62;
            dgvPravnaLica.Size = new Size(865, 166);
            dgvPravnaLica.TabIndex = 1;
            // 
            // colNazivFirme
            // 
            colNazivFirme.HeaderText = "Naziv firme";
            colNazivFirme.MinimumWidth = 8;
            colNazivFirme.Name = "colNazivFirme";
            colNazivFirme.Width = 150;
            // 
            // colPib
            // 
            colPib.HeaderText = "PIB";
            colPib.MinimumWidth = 8;
            colPib.Name = "colPib";
            colPib.Width = 150;
            // 
            // colAdresa
            // 
            colAdresa.HeaderText = "Adresa";
            colAdresa.MinimumWidth = 8;
            colAdresa.Name = "colAdresa";
            colAdresa.Width = 150;
            // 
            // colGrad2
            // 
            colGrad2.HeaderText = "Grad";
            colGrad2.MinimumWidth = 8;
            colGrad2.Name = "colGrad2";
            colGrad2.Width = 150;
            // 
            // colTelefon2
            // 
            colTelefon2.HeaderText = "Telefon";
            colTelefon2.MinimumWidth = 8;
            colTelefon2.Name = "colTelefon2";
            colTelefon2.Width = 150;
            // 
            // colEmail2
            // 
            colEmail2.HeaderText = "Email";
            colEmail2.MinimumWidth = 8;
            colEmail2.Name = "colEmail2";
            colEmail2.Width = 150;
            // 
            // colStatus2
            // 
            colStatus2.HeaderText = "Status";
            colStatus2.MinimumWidth = 8;
            colStatus2.Name = "colStatus2";
            colStatus2.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(712, 455);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 17;
            label1.Text = "Broj klijenta:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(747, 487);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(76, 23);
            lblInfo.TabIndex = 18;
            lblInfo.Text = "111111";
            // 
            // colIme
            // 
            colIme.HeaderText = "Ime";
            colIme.MinimumWidth = 8;
            colIme.Name = "colIme";
            colIme.Width = 150;
            // 
            // colJmbg
            // 
            colJmbg.HeaderText = "JMBG";
            colJmbg.MinimumWidth = 8;
            colJmbg.Name = "colJmbg";
            colJmbg.Width = 150;
            // 
            // colBrLicne
            // 
            colBrLicne.HeaderText = "Br. licne karte";
            colBrLicne.MinimumWidth = 8;
            colBrLicne.Name = "colBrLicne";
            colBrLicne.Width = 150;
            // 
            // colGrad
            // 
            colGrad.HeaderText = "Grad";
            colGrad.MinimumWidth = 8;
            colGrad.Name = "colGrad";
            colGrad.Width = 150;
            // 
            // colTelefon
            // 
            colTelefon.HeaderText = "Telefon";
            colTelefon.MinimumWidth = 8;
            colTelefon.Name = "colTelefon";
            colTelefon.Width = 150;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.Width = 150;
            // 
            // KlijentiPregled
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(904, 531);
            Controls.Add(lblInfo);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnOsvezi);
            Controls.Add(btnDetalji);
            Controls.Add(btnObrisiKorisnika);
            Controls.Add(btnIzmeniKorisnika);
            Controls.Add(btnDodajKlijenta);
            Controls.Add(btnPretrazi);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbTip);
            Controls.Add(lblTipKlijenta);
            Controls.Add(txtBoxPretraga);
            Controls.Add(lblPretraga);
            Name = "KlijentiPregled";
            Text = "KlijentiPregled";
            Load += KlijentiPregled_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFizickaLica).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPravnaLica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPretraga;
        private TextBox txtBoxPretraga;
        private Label lblTipKlijenta;
        private ComboBox cmbTip;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnPretrazi;
        private Button btnDodajKlijenta;
        private Button btnIzmeniKorisnika;
        private Button btnObrisiKorisnika;
        private Button btnDetalji;
        private Button btnOsvezi;
        private GroupBox groupBox1;
        private DataGridView dgvFizickaLica;
        private GroupBox groupBox2;
        private DataGridView dgvPravnaLica;
        private DataGridViewTextBoxColumn colNazivFirme;
        private DataGridViewTextBoxColumn colPib;
        private DataGridViewTextBoxColumn colAdresa;
        private DataGridViewTextBoxColumn colGrad2;
        private DataGridViewTextBoxColumn colTelefon2;
        private DataGridViewTextBoxColumn colEmail2;
        private DataGridViewTextBoxColumn colStatus2;
        private Label label1;
        private Label lblInfo;
        private DataGridViewTextBoxColumn colIme;
        private DataGridViewTextBoxColumn colJmbg;
        private DataGridViewTextBoxColumn colBrLicne;
        private DataGridViewTextBoxColumn colGrad;
        private DataGridViewTextBoxColumn colTelefon;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colStatus;
    }
}