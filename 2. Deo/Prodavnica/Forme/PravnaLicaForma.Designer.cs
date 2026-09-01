namespace Prodavnica.Forme
{
    partial class PravnaLicaForma
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
            labelPravnaLica = new Label();
            listPravnaLica = new ListView();
            btnDodajPravnoLice = new Button();
            btnIzmeniPravnoLice = new Button();
            btnObrisiPravnoLice = new Button();
            btnDetalji = new Button();
            SuspendLayout();
            // 
            // labelPravnaLica
            // 
            labelPravnaLica.AutoSize = true;
            labelPravnaLica.Font = new Font("Bell MT", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPravnaLica.Location = new Point(12, 9);
            labelPravnaLica.Name = "labelPravnaLica";
            labelPravnaLica.Size = new Size(120, 25);
            labelPravnaLica.TabIndex = 0;
            labelPravnaLica.Text = "Pravna lica:";
            // 
            // listPravnaLica
            // 
            listPravnaLica.BackColor = Color.Azure;
            listPravnaLica.Location = new Point(12, 37);
            listPravnaLica.Name = "listPravnaLica";
            listPravnaLica.Size = new Size(954, 400);
            listPravnaLica.TabIndex = 1;
            listPravnaLica.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodajPravnoLice
            // 
            btnDodajPravnoLice.BackColor = Color.Azure;
            btnDodajPravnoLice.Location = new Point(12, 452);
            btnDodajPravnoLice.Name = "btnDodajPravnoLice";
            btnDodajPravnoLice.Size = new Size(112, 34);
            btnDodajPravnoLice.TabIndex = 2;
            btnDodajPravnoLice.Text = "Dodaj";
            btnDodajPravnoLice.UseVisualStyleBackColor = false;
            // 
            // btnIzmeniPravnoLice
            // 
            btnIzmeniPravnoLice.BackColor = Color.Azure;
            btnIzmeniPravnoLice.Location = new Point(130, 452);
            btnIzmeniPravnoLice.Name = "btnIzmeniPravnoLice";
            btnIzmeniPravnoLice.Size = new Size(112, 34);
            btnIzmeniPravnoLice.TabIndex = 3;
            btnIzmeniPravnoLice.Text = "Izmeni";
            btnIzmeniPravnoLice.UseVisualStyleBackColor = false;
            // 
            // btnObrisiPravnoLice
            // 
            btnObrisiPravnoLice.BackColor = Color.Salmon;
            btnObrisiPravnoLice.Location = new Point(248, 452);
            btnObrisiPravnoLice.Name = "btnObrisiPravnoLice";
            btnObrisiPravnoLice.Size = new Size(112, 34);
            btnObrisiPravnoLice.TabIndex = 4;
            btnObrisiPravnoLice.Text = "Obrisi";
            btnObrisiPravnoLice.UseVisualStyleBackColor = false;
            // 
            // btnDetalji
            // 
            btnDetalji.BackColor = Color.Azure;
            btnDetalji.Location = new Point(854, 452);
            btnDetalji.Name = "btnDetalji";
            btnDetalji.Size = new Size(112, 34);
            btnDetalji.TabIndex = 5;
            btnDetalji.Text = "Detalji";
            btnDetalji.UseVisualStyleBackColor = false;
            // 
            // PravnaLicaForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(978, 744);
            Controls.Add(btnDetalji);
            Controls.Add(btnObrisiPravnoLice);
            Controls.Add(btnIzmeniPravnoLice);
            Controls.Add(btnDodajPravnoLice);
            Controls.Add(listPravnaLica);
            Controls.Add(labelPravnaLica);
            Name = "PravnaLicaForma";
            Text = "PravnaLicaForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPravnaLica;
        private ListView listPravnaLica;
        private Button btnDodajPravnoLice;
        private Button btnIzmeniPravnoLice;
        private Button btnObrisiPravnoLice;
        private Button btnDetalji;
    }
}