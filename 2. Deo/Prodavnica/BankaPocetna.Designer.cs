namespace Prodavnica
{
    partial class BankaPocetna
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
            btnPravnaLica = new Button();
            btnFizickaLica = new Button();
            labelBanka = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPravnaLica
            // 
            btnPravnaLica.BackColor = Color.Azure;
            btnPravnaLica.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPravnaLica.ForeColor = Color.SteelBlue;
            btnPravnaLica.Location = new Point(12, 479);
            btnPravnaLica.Name = "btnPravnaLica";
            btnPravnaLica.Size = new Size(200, 70);
            btnPravnaLica.TabIndex = 0;
            btnPravnaLica.Text = "PRAVNA LICA";
            btnPravnaLica.UseVisualStyleBackColor = false;
            // 
            // btnFizickaLica
            // 
            btnFizickaLica.BackColor = Color.Azure;
            btnFizickaLica.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFizickaLica.ForeColor = Color.SteelBlue;
            btnFizickaLica.Location = new Point(12, 403);
            btnFizickaLica.Name = "btnFizickaLica";
            btnFizickaLica.Size = new Size(200, 70);
            btnFizickaLica.TabIndex = 1;
            btnFizickaLica.Text = "FIZICKA LICA";
            btnFizickaLica.UseVisualStyleBackColor = false;
            // 
            // labelBanka
            // 
            labelBanka.AutoSize = true;
            labelBanka.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBanka.ForeColor = Color.DarkSlateBlue;
            labelBanka.Location = new Point(12, 9);
            labelBanka.Name = "labelBanka";
            labelBanka.Size = new Size(215, 85);
            labelBanka.TabIndex = 2;
            labelBanka.Text = "BANKA";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BankaPocetna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(578, 594);
            Controls.Add(pictureBox1);
            Controls.Add(labelBanka);
            Controls.Add(btnFizickaLica);
            Controls.Add(btnPravnaLica);
            Name = "BankaPocetna";
            Text = "BankaPocetna";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPravnaLica;
        private Button btnFizickaLica;
        private Label labelBanka;
        private PictureBox pictureBox1;
    }
}