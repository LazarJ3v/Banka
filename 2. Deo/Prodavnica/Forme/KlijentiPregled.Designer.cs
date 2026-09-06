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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblEmail = new Label();
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
            gbFizickaLica = new GroupBox();
            dgvFizickaLica = new DataGridView();
            colIme = new DataGridViewTextBoxColumn();
            colJmbg = new DataGridViewTextBoxColumn();
            colBrLicne = new DataGridViewTextBoxColumn();
            colGrad = new DataGridViewTextBoxColumn();
            colTelefon = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            gbPravnaLica = new GroupBox();
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
            groupBoxPretraga = new GroupBox();
            gbFizickaLica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFizickaLica).BeginInit();
            gbPravnaLica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPravnaLica).BeginInit();
            groupBoxPretraga.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(17, 31);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtBoxPretraga
            // 
            txtBoxPretraga.BackColor = Color.FromArgb(51, 51, 51);
            txtBoxPretraga.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPretraga.ForeColor = Color.White;
            txtBoxPretraga.Location = new Point(86, 28);
            txtBoxPretraga.Name = "txtBoxPretraga";
            txtBoxPretraga.Size = new Size(158, 31);
            txtBoxPretraga.TabIndex = 1;
            // 
            // lblTipKlijenta
            // 
            lblTipKlijenta.AutoSize = true;
            lblTipKlijenta.ForeColor = Color.White;
            lblTipKlijenta.Location = new Point(36, 74);
            lblTipKlijenta.Name = "lblTipKlijenta";
            lblTipKlijenta.Size = new Size(54, 23);
            lblTipKlijenta.TabIndex = 2;
            lblTipKlijenta.Text = "Tip:";
            // 
            // cmbTip
            // 
            cmbTip.BackColor = Color.FromArgb(51, 51, 51);
            cmbTip.FlatStyle = FlatStyle.Flat;
            cmbTip.ForeColor = Color.White;
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(86, 69);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(156, 31);
            cmbTip.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(13, 115);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(87, 23);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(51, 51, 51);
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.ForeColor = Color.White;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(86, 110);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(156, 31);
            cmbStatus.TabIndex = 5;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = Color.FromArgb(41, 41, 41);
            btnPretrazi.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnPretrazi.FlatStyle = FlatStyle.Flat;
            btnPretrazi.ForeColor = Color.White;
            btnPretrazi.Location = new Point(6, 152);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(239, 34);
            btnPretrazi.TabIndex = 7;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // btnDodajKlijenta
            // 
            btnDodajKlijenta.BackColor = Color.FromArgb(41, 41, 41);
            btnDodajKlijenta.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnDodajKlijenta.FlatStyle = FlatStyle.Flat;
            btnDodajKlijenta.ForeColor = Color.White;
            btnDodajKlijenta.Location = new Point(1125, 221);
            btnDodajKlijenta.Name = "btnDodajKlijenta";
            btnDodajKlijenta.Size = new Size(245, 64);
            btnDodajKlijenta.TabIndex = 8;
            btnDodajKlijenta.Text = "Dodaj";
            btnDodajKlijenta.UseVisualStyleBackColor = false;
            // 
            // btnIzmeniKorisnika
            // 
            btnIzmeniKorisnika.BackColor = Color.FromArgb(41, 41, 41);
            btnIzmeniKorisnika.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnIzmeniKorisnika.FlatStyle = FlatStyle.Flat;
            btnIzmeniKorisnika.ForeColor = Color.White;
            btnIzmeniKorisnika.Location = new Point(1125, 290);
            btnIzmeniKorisnika.Name = "btnIzmeniKorisnika";
            btnIzmeniKorisnika.Size = new Size(245, 64);
            btnIzmeniKorisnika.TabIndex = 9;
            btnIzmeniKorisnika.Text = "Izmeni";
            btnIzmeniKorisnika.UseVisualStyleBackColor = false;
            btnIzmeniKorisnika.Click += btnIzmeniKorisnika_Click;
            // 
            // btnObrisiKorisnika
            // 
            btnObrisiKorisnika.BackColor = Color.FromArgb(41, 41, 41);
            btnObrisiKorisnika.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnObrisiKorisnika.FlatStyle = FlatStyle.Flat;
            btnObrisiKorisnika.ForeColor = Color.White;
            btnObrisiKorisnika.Location = new Point(1125, 360);
            btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            btnObrisiKorisnika.Size = new Size(245, 64);
            btnObrisiKorisnika.TabIndex = 10;
            btnObrisiKorisnika.Text = "Obriši";
            btnObrisiKorisnika.UseVisualStyleBackColor = false;
            // 
            // btnDetalji
            // 
            btnDetalji.BackColor = Color.FromArgb(41, 41, 41);
            btnDetalji.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnDetalji.FlatStyle = FlatStyle.Flat;
            btnDetalji.ForeColor = Color.White;
            btnDetalji.Location = new Point(1125, 429);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(245, 64);
            btnDetalji.TabIndex = 11;
            btnDetalji.Text = "Detalji";
            btnDetalji.UseVisualStyleBackColor = false;
            // 
            // btnOsvezi
            // 
            btnOsvezi.BackColor = Color.FromArgb(41, 41, 41);
            btnOsvezi.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnOsvezi.FlatStyle = FlatStyle.Flat;
            btnOsvezi.ForeColor = Color.White;
            btnOsvezi.Location = new Point(1125, 500);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(245, 64);
            btnOsvezi.TabIndex = 14;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = false;
            // 
            // gbFizickaLica
            // 
            gbFizickaLica.Controls.Add(dgvFizickaLica);
            gbFizickaLica.ForeColor = Color.White;
            gbFizickaLica.Location = new Point(13, 15);
            gbFizickaLica.Name = "gbFizickaLica";
            gbFizickaLica.Size = new Size(1100, 313);
            gbFizickaLica.TabIndex = 15;
            gbFizickaLica.TabStop = false;
            gbFizickaLica.Text = "Fizička lica";
            // 
            // dgvFizickaLica
            // 
            dgvFizickaLica.AllowUserToAddRows = false;
            dgvFizickaLica.BackgroundColor = Color.FromArgb(51, 51, 51);
            dgvFizickaLica.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvFizickaLica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvFizickaLica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFizickaLica.Columns.AddRange(new DataGridViewColumn[] { colIme, colJmbg, colBrLicne, colGrad, colTelefon, colEmail, colStatus });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvFizickaLica.DefaultCellStyle = dataGridViewCellStyle6;
            dgvFizickaLica.EnableHeadersVisualStyles = false;
            dgvFizickaLica.GridColor = Color.FromArgb(71, 71, 71);
            dgvFizickaLica.Location = new Point(6, 21);
            dgvFizickaLica.Name = "dgvFizickaLica";
            dgvFizickaLica.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvFizickaLica.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvFizickaLica.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dgvFizickaLica.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvFizickaLica.Size = new Size(1087, 285);
            dgvFizickaLica.TabIndex = 0;
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
            // gbPravnaLica
            // 
            gbPravnaLica.Controls.Add(dgvPravnaLica);
            gbPravnaLica.ForeColor = Color.White;
            gbPravnaLica.Location = new Point(13, 334);
            gbPravnaLica.Name = "gbPravnaLica";
            gbPravnaLica.Size = new Size(1100, 313);
            gbPravnaLica.TabIndex = 16;
            gbPravnaLica.TabStop = false;
            gbPravnaLica.Text = "Pravna lica";
            // 
            // dgvPravnaLica
            // 
            dgvPravnaLica.AllowUserToAddRows = false;
            dgvPravnaLica.BackgroundColor = Color.FromArgb(51, 51, 51);
            dgvPravnaLica.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPravnaLica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPravnaLica.Columns.AddRange(new DataGridViewColumn[] { colNazivFirme, colPib, colAdresa, colGrad2, colTelefon2, colEmail2, colStatus2 });
            dgvPravnaLica.EnableHeadersVisualStyles = false;
            dgvPravnaLica.GridColor = Color.FromArgb(71, 71, 71);
            dgvPravnaLica.Location = new Point(6, 21);
            dgvPravnaLica.Name = "dgvPravnaLica";
            dgvPravnaLica.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPravnaLica.RowHeadersWidth = 62;
            dgvPravnaLica.Size = new Size(1087, 285);
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(1119, 567);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 17;
            label1.Text = "Broj klijenta:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(1243, 567);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(76, 23);
            lblInfo.TabIndex = 18;
            lblInfo.Text = "111111";
            // 
            // groupBoxPretraga
            // 
            groupBoxPretraga.Controls.Add(cmbStatus);
            groupBoxPretraga.Controls.Add(btnPretrazi);
            groupBoxPretraga.Controls.Add(lblStatus);
            groupBoxPretraga.Controls.Add(cmbTip);
            groupBoxPretraga.Controls.Add(lblTipKlijenta);
            groupBoxPretraga.Controls.Add(txtBoxPretraga);
            groupBoxPretraga.Controls.Add(lblEmail);
            groupBoxPretraga.ForeColor = Color.White;
            groupBoxPretraga.Location = new Point(1119, 15);
            groupBoxPretraga.Name = "groupBoxPretraga";
            groupBoxPretraga.Size = new Size(251, 199);
            groupBoxPretraga.TabIndex = 20;
            groupBoxPretraga.TabStop = false;
            groupBoxPretraga.Text = "Pretraga";
            // 
            // KlijentiPregled
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1384, 684);
            Controls.Add(groupBoxPretraga);
            Controls.Add(lblInfo);
            Controls.Add(label1);
            Controls.Add(gbPravnaLica);
            Controls.Add(gbFizickaLica);
            Controls.Add(btnOsvezi);
            Controls.Add(btnDetalji);
            Controls.Add(btnObrisiKorisnika);
            Controls.Add(btnIzmeniKorisnika);
            Controls.Add(btnDodajKlijenta);
            Name = "KlijentiPregled";
            Text = "KlijentiPregled";
            Load += KlijentiPregled_Load;
            gbFizickaLica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFizickaLica).EndInit();
            gbPravnaLica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPravnaLica).EndInit();
            groupBoxPretraga.ResumeLayout(false);
            groupBoxPretraga.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
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
        private GroupBox gbFizickaLica;
        private DataGridView dgvFizickaLica;
        private GroupBox gbPravnaLica;
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
        private GroupBox groupBoxPretraga;
    }
}