namespace Prodavnica.Forme
{
    partial class FizickaLicaForma
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
            labelFizickaLica = new Label();
            listFizickaLica = new ListView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnDetalji = new Button();
            SuspendLayout();
            // 
            // labelFizickaLica
            // 
            labelFizickaLica.AutoSize = true;
            labelFizickaLica.Location = new Point(12, 9);
            labelFizickaLica.Name = "labelFizickaLica";
            labelFizickaLica.Size = new Size(97, 25);
            labelFizickaLica.TabIndex = 0;
            labelFizickaLica.Text = "Fizicka lica:";
            // 
            // listFizickaLica
            // 
            listFizickaLica.BackColor = Color.Azure;
            listFizickaLica.Location = new Point(12, 37);
            listFizickaLica.Name = "listFizickaLica";
            listFizickaLica.Size = new Size(954, 400);
            listFizickaLica.TabIndex = 1;
            listFizickaLica.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Azure;
            btnDodaj.Location = new Point(12, 443);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Azure;
            btnIzmeni.Location = new Point(130, 443);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(112, 34);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Salmon;
            btnObrisi.Location = new Point(248, 443);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(112, 34);
            btnObrisi.TabIndex = 4;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = false;
            // 
            // btnDetalji
            // 
            btnDetalji.BackColor = Color.Azure;
            btnDetalji.Location = new Point(854, 443);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(112, 34);
            btnDetalji.TabIndex = 7;
            btnDetalji.Text = "Detalji";
            btnDetalji.UseVisualStyleBackColor = false;
            // 
            // FizickaLicaForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(978, 744);
            Controls.Add(btnDetalji);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(listFizickaLica);
            Controls.Add(labelFizickaLica);
            Name = "FizickaLicaForma";
            Text = "FizickaLicaForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFizickaLica;
        private ListView listFizickaLica;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnDetalji;
    }
}