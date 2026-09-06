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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            groupBox1 = new GroupBox();
            dgvFizickaLica = new DataGridView();
            colIme = new DataGridViewTextBoxColumn();
            colJmbg = new DataGridViewTextBoxColumn();
            colBrLicne = new DataGridViewTextBoxColumn();
            colGrad = new DataGridViewTextBoxColumn();
            colTelefon = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
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
            groupBoxPretraga = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFizickaLica).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPravnaLica).BeginInit();
            groupBoxPretraga.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(16, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtBoxPretraga
            // 
            txtBoxPretraga.BackColor = Color.FromArgb(51, 51, 51);
            txtBoxPretraga.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPretraga.ForeColor = Color.White;
            txtBoxPretraga.Location = new Point(79, 30);
            txtBoxPretraga.Name = "txtBoxPretraga";
            txtBoxPretraga.Size = new Size(143, 31);
            txtBoxPretraga.TabIndex = 1;
            // 
            // lblTipKlijenta
            // 
            lblTipKlijenta.AutoSize = true;
            lblTipKlijenta.ForeColor = Color.White;
            lblTipKlijenta.Location = new Point(33, 80);
            lblTipKlijenta.Name = "lblTipKlijenta";
            lblTipKlijenta.Size = new Size(40, 25);
            lblTipKlijenta.TabIndex = 2;
            lblTipKlijenta.Text = "Tip:";
            // 
            // cmbTip
            // 
            cmbTip.BackColor = Color.FromArgb(51, 51, 51);
            cmbTip.FlatStyle = FlatStyle.Flat;
            cmbTip.ForeColor = Color.White;
            cmbTip.FormattingEnabled = true;
            cmbTip.Location = new Point(79, 75);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(143, 33);
            cmbTip.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(11, 125);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(51, 51, 51);
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.ForeColor = Color.White;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(79, 120);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(143, 33);
            cmbStatus.TabIndex = 5;
            // 
            // btnPretrazi
            // 
            btnPretrazi.BackColor = Color.FromArgb(41, 41, 41);
            btnPretrazi.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnPretrazi.FlatStyle = FlatStyle.Flat;
            btnPretrazi.ForeColor = Color.White;
            btnPretrazi.Location = new Point(6, 165);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(217, 37);
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
            btnDodajKlijenta.Location = new Point(1023, 240);
            btnDodajKlijenta.Name = "btnDodajKlijenta";
            btnDodajKlijenta.Size = new Size(223, 70);
            btnDodajKlijenta.TabIndex = 8;
            btnDodajKlijenta.Text = "Dodaj";
            btnDodajKlijenta.UseVisualStyleBackColor = false;
            btnDodajKlijenta.Click += btnDodajKlijenta_Click;
            // 
            // btnIzmeniKorisnika
            // 
            btnIzmeniKorisnika.BackColor = Color.FromArgb(41, 41, 41);
            btnIzmeniKorisnika.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnIzmeniKorisnika.FlatStyle = FlatStyle.Flat;
            btnIzmeniKorisnika.ForeColor = Color.White;
            btnIzmeniKorisnika.Location = new Point(1023, 315);
            btnIzmeniKorisnika.Name = "btnIzmeniKorisnika";
            btnIzmeniKorisnika.Size = new Size(223, 70);
            btnIzmeniKorisnika.TabIndex = 9;
            btnIzmeniKorisnika.Text = "Izmeni";
            btnIzmeniKorisnika.UseVisualStyleBackColor = false;
            // 
            // btnObrisiKorisnika
            // 
            btnObrisiKorisnika.BackColor = Color.FromArgb(41, 41, 41);
            btnObrisiKorisnika.FlatAppearance.BorderColor = Color.FromArgb(71, 71, 71);
            btnObrisiKorisnika.FlatStyle = FlatStyle.Flat;
            btnObrisiKorisnika.ForeColor = Color.White;
            btnObrisiKorisnika.Location = new Point(1023, 392);
            btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            btnObrisiKorisnika.Size = new Size(223, 70);
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
            btnDetalji.Location = new Point(1023, 467);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(223, 70);
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
            btnOsvezi.Location = new Point(1023, 543);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(223, 70);
            btnOsvezi.TabIndex = 14;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvFizickaLica);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(11, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 340);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fizička lica";
            // 
            // dgvFizickaLica
            // 
            dgvFizickaLica.AllowUserToAddRows = false;
            dgvFizickaLica.BackgroundColor = Color.FromArgb(51, 51, 51);
            dgvFizickaLica.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFizickaLica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFizickaLica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFizickaLica.Columns.AddRange(new DataGridViewColumn[] { colIme, colJmbg, colBrLicne, colGrad, colTelefon, colEmail, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFizickaLica.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFizickaLica.EnableHeadersVisualStyles = false;
            dgvFizickaLica.GridColor = Color.FromArgb(71, 71, 71);
            dgvFizickaLica.Location = new Point(6, 23);
            dgvFizickaLica.Name = "dgvFizickaLica";
            dgvFizickaLica.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFizickaLica.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFizickaLica.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(61, 61, 61);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvFizickaLica.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFizickaLica.Size = new Size(989, 310);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPravnaLica);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(11, 363);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 340);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pravna lica";
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
            dgvPravnaLica.Location = new Point(6, 23);
            dgvPravnaLica.Name = "dgvPravnaLica";
            dgvPravnaLica.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPravnaLica.RowHeadersWidth = 62;
            dgvPravnaLica.Size = new Size(989, 310);
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
            label1.Location = new Point(1017, 617);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 17;
            label1.Text = "Broj klijenta:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(1130, 617);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(72, 25);
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
            groupBoxPretraga.Location = new Point(1017, 17);
            groupBoxPretraga.Name = "groupBoxPretraga";
            groupBoxPretraga.Size = new Size(229, 217);
            groupBoxPretraga.TabIndex = 20;
            groupBoxPretraga.TabStop = false;
            groupBoxPretraga.Text = "Pretraga";
            // 
            // KlijentiPregled
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1259, 743);
            Controls.Add(groupBoxPretraga);
            Controls.Add(lblInfo);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnOsvezi);
            Controls.Add(btnDetalji);
            Controls.Add(btnObrisiKorisnika);
            Controls.Add(btnIzmeniKorisnika);
            Controls.Add(btnDodajKlijenta);
            Name = "KlijentiPregled";
            Text = "KlijentiPregled";
            Load += KlijentiPregled_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFizickaLica).EndInit();
            groupBox2.ResumeLayout(false);
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
        private GroupBox groupBoxPretraga;
    }
}