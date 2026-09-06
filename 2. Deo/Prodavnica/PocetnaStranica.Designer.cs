namespace Prodavnica
{
    partial class PocetnaStranica
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
            btnKlijenti = new Button();
            btnRacuni = new Button();
            btnKrediti = new Button();
            btnTransakcije = new Button();
            btnDepoziti = new Button();
            btnKamate = new Button();
            btnSigurnosneKontrole = new Button();
            SuspendLayout();
            // 
            // btnKlijenti
            // 
            btnKlijenti.Location = new Point(12, 307);
            btnKlijenti.Name = "btnKlijenti";
            btnKlijenti.Size = new Size(183, 30);
            btnKlijenti.TabIndex = 0;
            btnKlijenti.Text = "Klijenti";
            btnKlijenti.UseVisualStyleBackColor = true;
            btnKlijenti.Click += btnKlijenti_Click;
            // 
            // btnRacuni
            // 
            btnRacuni.Location = new Point(201, 307);
            btnRacuni.Name = "btnRacuni";
            btnRacuni.Size = new Size(183, 30);
            btnRacuni.TabIndex = 1;
            btnRacuni.Text = "Racuni";
            btnRacuni.UseVisualStyleBackColor = true;
            // 
            // btnKrediti
            // 
            btnKrediti.Location = new Point(390, 343);
            btnKrediti.Name = "btnKrediti";
            btnKrediti.Size = new Size(183, 30);
            btnKrediti.TabIndex = 2;
            btnKrediti.Text = "Krediti";
            btnKrediti.UseVisualStyleBackColor = true;
            // 
            // btnTransakcije
            // 
            btnTransakcije.Location = new Point(390, 307);
            btnTransakcije.Name = "btnTransakcije";
            btnTransakcije.Size = new Size(183, 30);
            btnTransakcije.TabIndex = 3;
            btnTransakcije.Text = "Transakcije";
            btnTransakcije.UseVisualStyleBackColor = true;
            // 
            // btnDepoziti
            // 
            btnDepoziti.Location = new Point(201, 343);
            btnDepoziti.Name = "btnDepoziti";
            btnDepoziti.Size = new Size(183, 30);
            btnDepoziti.TabIndex = 4;
            btnDepoziti.Text = "Depoziti";
            btnDepoziti.UseVisualStyleBackColor = true;
            // 
            // btnKamate
            // 
            btnKamate.Location = new Point(12, 343);
            btnKamate.Name = "btnKamate";
            btnKamate.Size = new Size(183, 30);
            btnKamate.TabIndex = 5;
            btnKamate.Text = "Kamate";
            btnKamate.UseVisualStyleBackColor = true;
            // 
            // btnSigurnosneKontrole
            // 
            btnSigurnosneKontrole.Location = new Point(12, 379);
            btnSigurnosneKontrole.Name = "btnSigurnosneKontrole";
            btnSigurnosneKontrole.Size = new Size(561, 30);
            btnSigurnosneKontrole.TabIndex = 6;
            btnSigurnosneKontrole.Text = "SigurnosneKontrole";
            btnSigurnosneKontrole.UseVisualStyleBackColor = true;
            // 
            // PocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 421);
            Controls.Add(btnSigurnosneKontrole);
            Controls.Add(btnKamate);
            Controls.Add(btnDepoziti);
            Controls.Add(btnTransakcije);
            Controls.Add(btnKrediti);
            Controls.Add(btnRacuni);
            Controls.Add(btnKlijenti);
            Name = "PocetnaStranica";
            Text = "PocetnaStranica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKlijenti;
        private Button btnRacuni;
        private Button btnKrediti;
        private Button btnTransakcije;
        private Button btnDepoziti;
        private Button btnKamate;
        private Button btnSigurnosneKontrole;
    }
}