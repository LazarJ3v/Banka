namespace Prodavnica
{
    partial class Form1
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
            cmdRead = new Button();
            cmdCreate = new Button();
            cmdManytoOne = new Button();
            cmdOneToMany = new Button();
            cmdCreateOdeljenje = new Button();
            cmdManyToMany = new Button();
            cmdCreateRadnik = new Button();
            cmdCreateRadiU = new Button();
            cmdTPC = new Button();
            cmdCreateVojnik = new Button();
            button1 = new Button();
            cmdCreateSubclassOdeljenje = new Button();
            cmdGet = new Button();
            cmdRefresh = new Button();
            cmdQuery = new Button();
            cmdQuery1 = new Button();
            cmdQueryParameters = new Button();
            cmdQueryNamedParamters = new Button();
            cmdQueryNamedParameters1 = new Button();
            smdEnumerable = new Button();
            cmdScalar = new Button();
            cmdUnique = new Button();
            cmdMultiple = new Button();
            cmdPaging = new Button();
            cmdCriteria = new Button();
            cmdSQL = new Button();
            cmdQueryOver = new Button();
            cmdUpdate = new Button();
            cmdDelete = new Button();
            cmdTransaction = new Button();
            cmdLINQ = new Button();
            cmdLINQ1 = new Button();
            cmdLINQ2 = new Button();
            button_dtoexample1 = new Button();
            SuspendLayout();
            // 
            // cmdRead
            // 
            cmdRead.Location = new Point(24, 23);
            cmdRead.Margin = new Padding(6, 5, 6, 5);
            cmdRead.Name = "cmdRead";
            cmdRead.Size = new Size(497, 41);
            cmdRead.TabIndex = 0;
            cmdRead.Text = "Ucitavanje podataka o Racunu";
            cmdRead.UseVisualStyleBackColor = true;
            cmdRead.Click += cmdRead_Click;
            // 
            // cmdCreate
            // 
            cmdCreate.Location = new Point(24, 76);
            cmdCreate.Margin = new Padding(6, 5, 6, 5);
            cmdCreate.Name = "cmdCreate";
            cmdCreate.Size = new Size(497, 41);
            cmdCreate.TabIndex = 1;
            cmdCreate.Text = "Dodavanje nove prodavnice";
            cmdCreate.UseVisualStyleBackColor = true;
            cmdCreate.Click += cmdCreate_Click;
            // 
            // cmdManytoOne
            // 
            cmdManytoOne.Location = new Point(24, 129);
            cmdManytoOne.Margin = new Padding(6, 5, 6, 5);
            cmdManytoOne.Name = "cmdManytoOne";
            cmdManytoOne.Size = new Size(497, 41);
            cmdManytoOne.TabIndex = 2;
            cmdManytoOne.Text = "Veza Many-to-One";
            cmdManytoOne.UseVisualStyleBackColor = true;
            cmdManytoOne.Click += cmdManytoOne_Click;
            // 
            // cmdOneToMany
            // 
            cmdOneToMany.Location = new Point(24, 182);
            cmdOneToMany.Margin = new Padding(6, 5, 6, 5);
            cmdOneToMany.Name = "cmdOneToMany";
            cmdOneToMany.Size = new Size(497, 41);
            cmdOneToMany.TabIndex = 3;
            cmdOneToMany.Text = "Veza One-to-Many";
            cmdOneToMany.UseVisualStyleBackColor = true;
            cmdOneToMany.Click += cmdOneToMany_Click;
            // 
            // cmdCreateOdeljenje
            // 
            cmdCreateOdeljenje.Location = new Point(24, 235);
            cmdCreateOdeljenje.Margin = new Padding(6, 5, 6, 5);
            cmdCreateOdeljenje.Name = "cmdCreateOdeljenje";
            cmdCreateOdeljenje.Size = new Size(497, 41);
            cmdCreateOdeljenje.TabIndex = 4;
            cmdCreateOdeljenje.Text = "Kreiranje odeljenja";
            cmdCreateOdeljenje.UseVisualStyleBackColor = true;
            cmdCreateOdeljenje.Click += cmdCreateOdeljenje_Click;
            // 
            // cmdManyToMany
            // 
            cmdManyToMany.Location = new Point(24, 288);
            cmdManyToMany.Margin = new Padding(6, 5, 6, 5);
            cmdManyToMany.Name = "cmdManyToMany";
            cmdManyToMany.Size = new Size(497, 41);
            cmdManyToMany.TabIndex = 5;
            cmdManyToMany.Text = "HasManytoMany";
            cmdManyToMany.UseVisualStyleBackColor = true;
            cmdManyToMany.Click += cmdManyToMany_Click;
            // 
            // cmdCreateRadnik
            // 
            cmdCreateRadnik.Location = new Point(24, 341);
            cmdCreateRadnik.Margin = new Padding(6, 5, 6, 5);
            cmdCreateRadnik.Name = "cmdCreateRadnik";
            cmdCreateRadnik.Size = new Size(497, 41);
            cmdCreateRadnik.TabIndex = 6;
            cmdCreateRadnik.Text = "Kreiranje radnika";
            cmdCreateRadnik.UseVisualStyleBackColor = true;
            cmdCreateRadnik.Click += cmdCreateRadnik_Click;
            // 
            // cmdCreateRadiU
            // 
            cmdCreateRadiU.Location = new Point(24, 395);
            cmdCreateRadiU.Margin = new Padding(6, 5, 6, 5);
            cmdCreateRadiU.Name = "cmdCreateRadiU";
            cmdCreateRadiU.Size = new Size(497, 41);
            cmdCreateRadiU.TabIndex = 7;
            cmdCreateRadiU.Text = "Kreiranje RadiU";
            cmdCreateRadiU.UseVisualStyleBackColor = true;
            cmdCreateRadiU.Click += cmdCreateRadiU_Click;
            // 
            // cmdTPC
            // 
            cmdTPC.Location = new Point(24, 446);
            cmdTPC.Margin = new Padding(6, 5, 6, 5);
            cmdTPC.Name = "cmdTPC";
            cmdTPC.Size = new Size(497, 41);
            cmdTPC.TabIndex = 8;
            cmdTPC.Text = "Table-per-Class inheritance";
            cmdTPC.UseVisualStyleBackColor = true;
            cmdTPC.Click += cmdTPC_Click;
            // 
            // cmdCreateVojnik
            // 
            cmdCreateVojnik.Location = new Point(24, 497);
            cmdCreateVojnik.Margin = new Padding(6, 5, 6, 5);
            cmdCreateVojnik.Name = "cmdCreateVojnik";
            cmdCreateVojnik.Size = new Size(497, 41);
            cmdCreateVojnik.TabIndex = 9;
            cmdCreateVojnik.Text = "Kreiranje vojnika";
            cmdCreateVojnik.UseVisualStyleBackColor = true;
            cmdCreateVojnik.Click += cmdCreateVojnik_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 550);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(497, 41);
            button1.TabIndex = 10;
            button1.Text = "Table-per-Class-Hierarchy inheritance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmdCreateSubclassOdeljenje
            // 
            cmdCreateSubclassOdeljenje.Location = new Point(24, 603);
            cmdCreateSubclassOdeljenje.Margin = new Padding(6, 5, 6, 5);
            cmdCreateSubclassOdeljenje.Name = "cmdCreateSubclassOdeljenje";
            cmdCreateSubclassOdeljenje.Size = new Size(497, 41);
            cmdCreateSubclassOdeljenje.TabIndex = 11;
            cmdCreateSubclassOdeljenje.Text = "Kreiranje podklase Odeljenja";
            cmdCreateSubclassOdeljenje.UseVisualStyleBackColor = true;
            cmdCreateSubclassOdeljenje.Click += cmdCreateSubclassOdeljenje_Click;
            // 
            // cmdGet
            // 
            cmdGet.Location = new Point(565, 23);
            cmdGet.Margin = new Padding(6, 5, 6, 5);
            cmdGet.Name = "cmdGet";
            cmdGet.Size = new Size(497, 41);
            cmdGet.TabIndex = 12;
            cmdGet.Text = "Koriscenje metode Get";
            cmdGet.UseVisualStyleBackColor = true;
            cmdGet.Click += cmdGet_Click;
            // 
            // cmdRefresh
            // 
            cmdRefresh.Location = new Point(565, 76);
            cmdRefresh.Margin = new Padding(6, 5, 6, 5);
            cmdRefresh.Name = "cmdRefresh";
            cmdRefresh.Size = new Size(497, 41);
            cmdRefresh.TabIndex = 13;
            cmdRefresh.Text = "Koriscenje metode Refresh";
            cmdRefresh.UseVisualStyleBackColor = true;
            cmdRefresh.Click += cmdRefresh_Click;
            // 
            // cmdQuery
            // 
            cmdQuery.Location = new Point(565, 127);
            cmdQuery.Margin = new Padding(6, 5, 6, 5);
            cmdQuery.Name = "cmdQuery";
            cmdQuery.Size = new Size(497, 41);
            cmdQuery.TabIndex = 14;
            cmdQuery.Text = "Krieranje upita";
            cmdQuery.UseVisualStyleBackColor = true;
            cmdQuery.Click += cmdFind1_Click;
            // 
            // cmdQuery1
            // 
            cmdQuery1.Location = new Point(565, 179);
            cmdQuery1.Margin = new Padding(6, 5, 6, 5);
            cmdQuery1.Name = "cmdQuery1";
            cmdQuery1.Size = new Size(497, 41);
            cmdQuery1.TabIndex = 15;
            cmdQuery1.Text = "Krieranje upita 1";
            cmdQuery1.UseVisualStyleBackColor = true;
            cmdQuery1.Click += cmdQuery1_Click;
            // 
            // cmdQueryParameters
            // 
            cmdQueryParameters.Location = new Point(565, 230);
            cmdQueryParameters.Margin = new Padding(6, 5, 6, 5);
            cmdQueryParameters.Name = "cmdQueryParameters";
            cmdQueryParameters.Size = new Size(497, 41);
            cmdQueryParameters.TabIndex = 16;
            cmdQueryParameters.Text = "Krieranje upita sa parametrima";
            cmdQueryParameters.UseVisualStyleBackColor = true;
            cmdQueryParameters.Click += cmdQueryParameters_Click;
            // 
            // cmdQueryNamedParamters
            // 
            cmdQueryNamedParamters.Location = new Point(565, 288);
            cmdQueryNamedParamters.Margin = new Padding(6, 5, 6, 5);
            cmdQueryNamedParamters.Name = "cmdQueryNamedParamters";
            cmdQueryNamedParamters.Size = new Size(497, 41);
            cmdQueryNamedParamters.TabIndex = 17;
            cmdQueryNamedParamters.Text = "Krieranje upita sa imenovanim parametrima";
            cmdQueryNamedParamters.UseVisualStyleBackColor = true;
            cmdQueryNamedParamters.Click += cmdQueryNamedParamters_Click;
            // 
            // cmdQueryNamedParameters1
            // 
            cmdQueryNamedParameters1.Location = new Point(565, 341);
            cmdQueryNamedParameters1.Margin = new Padding(6, 5, 6, 5);
            cmdQueryNamedParameters1.Name = "cmdQueryNamedParameters1";
            cmdQueryNamedParameters1.Size = new Size(497, 41);
            cmdQueryNamedParameters1.TabIndex = 18;
            cmdQueryNamedParameters1.Text = "Krieranje upita sa imenovanim parametrima 1";
            cmdQueryNamedParameters1.UseVisualStyleBackColor = true;
            cmdQueryNamedParameters1.Click += cmdQueryNamedParameters1_Click;
            // 
            // smdEnumerable
            // 
            smdEnumerable.Location = new Point(565, 395);
            smdEnumerable.Margin = new Padding(6, 5, 6, 5);
            smdEnumerable.Name = "smdEnumerable";
            smdEnumerable.Size = new Size(497, 41);
            smdEnumerable.TabIndex = 19;
            smdEnumerable.Text = "Koriscenje Enumerable";
            smdEnumerable.UseVisualStyleBackColor = true;
            smdEnumerable.Click += smdEnumerable_Click;
            // 
            // cmdScalar
            // 
            cmdScalar.Location = new Point(565, 446);
            cmdScalar.Margin = new Padding(6, 5, 6, 5);
            cmdScalar.Name = "cmdScalar";
            cmdScalar.Size = new Size(497, 41);
            cmdScalar.TabIndex = 20;
            cmdScalar.Text = "Skalarni rezultati";
            cmdScalar.UseVisualStyleBackColor = true;
            cmdScalar.Click += cmdScalar_Click;
            // 
            // cmdUnique
            // 
            cmdUnique.Location = new Point(565, 497);
            cmdUnique.Margin = new Padding(6, 5, 6, 5);
            cmdUnique.Name = "cmdUnique";
            cmdUnique.Size = new Size(497, 41);
            cmdUnique.TabIndex = 22;
            cmdUnique.Text = "Unique rezultat";
            cmdUnique.UseVisualStyleBackColor = true;
            cmdUnique.Click += cmdUnique_Click;
            // 
            // cmdMultiple
            // 
            cmdMultiple.Location = new Point(565, 550);
            cmdMultiple.Margin = new Padding(6, 5, 6, 5);
            cmdMultiple.Name = "cmdMultiple";
            cmdMultiple.Size = new Size(497, 41);
            cmdMultiple.TabIndex = 23;
            cmdMultiple.Text = "Visestruki rezultati";
            cmdMultiple.UseVisualStyleBackColor = true;
            cmdMultiple.Click += cmdMultiple_Click;
            // 
            // cmdPaging
            // 
            cmdPaging.Location = new Point(565, 603);
            cmdPaging.Margin = new Padding(6, 5, 6, 5);
            cmdPaging.Name = "cmdPaging";
            cmdPaging.Size = new Size(497, 41);
            cmdPaging.TabIndex = 24;
            cmdPaging.Text = "Stranicenje";
            cmdPaging.UseVisualStyleBackColor = true;
            cmdPaging.Click += cmdPaging_Click;
            // 
            // cmdCriteria
            // 
            cmdCriteria.Location = new Point(1100, 21);
            cmdCriteria.Margin = new Padding(6, 5, 6, 5);
            cmdCriteria.Name = "cmdCriteria";
            cmdCriteria.Size = new Size(497, 41);
            cmdCriteria.TabIndex = 25;
            cmdCriteria.Text = "Kreiranej Criteria";
            cmdCriteria.UseVisualStyleBackColor = true;
            cmdCriteria.Click += cmdCriteria_Click;
            // 
            // cmdSQL
            // 
            cmdSQL.Location = new Point(1100, 127);
            cmdSQL.Margin = new Padding(6, 5, 6, 5);
            cmdSQL.Name = "cmdSQL";
            cmdSQL.Size = new Size(497, 41);
            cmdSQL.TabIndex = 26;
            cmdSQL.Text = "Native SQL";
            cmdSQL.UseVisualStyleBackColor = true;
            cmdSQL.Click += cmdSQL_Click;
            // 
            // cmdQueryOver
            // 
            cmdQueryOver.Location = new Point(1100, 73);
            cmdQueryOver.Margin = new Padding(6, 5, 6, 5);
            cmdQueryOver.Name = "cmdQueryOver";
            cmdQueryOver.Size = new Size(497, 41);
            cmdQueryOver.TabIndex = 27;
            cmdQueryOver.Text = "Kreiranje QueryOver";
            cmdQueryOver.UseVisualStyleBackColor = true;
            cmdQueryOver.Click += cmdQueryOver_Click;
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(1100, 179);
            cmdUpdate.Margin = new Padding(6, 5, 6, 5);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(497, 41);
            cmdUpdate.TabIndex = 28;
            cmdUpdate.Text = "Update";
            cmdUpdate.UseVisualStyleBackColor = true;
            cmdUpdate.Click += cmdUpdate_Click;
            // 
            // cmdDelete
            // 
            cmdDelete.Location = new Point(1100, 235);
            cmdDelete.Margin = new Padding(6, 5, 6, 5);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(497, 41);
            cmdDelete.TabIndex = 29;
            cmdDelete.Text = "Delete";
            cmdDelete.UseVisualStyleBackColor = true;
            cmdDelete.Click += cmdDelete_Click;
            // 
            // cmdTransaction
            // 
            cmdTransaction.Location = new Point(1100, 287);
            cmdTransaction.Margin = new Padding(6, 5, 6, 5);
            cmdTransaction.Name = "cmdTransaction";
            cmdTransaction.Size = new Size(497, 41);
            cmdTransaction.TabIndex = 30;
            cmdTransaction.Text = "Transakcija";
            cmdTransaction.UseVisualStyleBackColor = true;
            cmdTransaction.Click += cmdTransaction_Click;
            // 
            // cmdLINQ
            // 
            cmdLINQ.Location = new Point(1100, 340);
            cmdLINQ.Margin = new Padding(6, 5, 6, 5);
            cmdLINQ.Name = "cmdLINQ";
            cmdLINQ.Size = new Size(497, 41);
            cmdLINQ.TabIndex = 31;
            cmdLINQ.Text = "LINQ";
            cmdLINQ.UseVisualStyleBackColor = true;
            cmdLINQ.Click += cmdLINQ_Click;
            // 
            // cmdLINQ1
            // 
            cmdLINQ1.Location = new Point(1100, 395);
            cmdLINQ1.Margin = new Padding(6, 5, 6, 5);
            cmdLINQ1.Name = "cmdLINQ1";
            cmdLINQ1.Size = new Size(497, 41);
            cmdLINQ1.TabIndex = 32;
            cmdLINQ1.Text = "LINQ 1";
            cmdLINQ1.UseVisualStyleBackColor = true;
            cmdLINQ1.Click += cmdLINQ1_Click;
            // 
            // cmdLINQ2
            // 
            cmdLINQ2.Location = new Point(1100, 446);
            cmdLINQ2.Margin = new Padding(6, 5, 6, 5);
            cmdLINQ2.Name = "cmdLINQ2";
            cmdLINQ2.Size = new Size(497, 41);
            cmdLINQ2.TabIndex = 33;
            cmdLINQ2.Text = "LINQ 2";
            cmdLINQ2.UseVisualStyleBackColor = true;
            cmdLINQ2.Click += cmdLINQ2_Click;
            // 
            // button_dtoexample1
            // 
            button_dtoexample1.Location = new Point(1100, 497);
            button_dtoexample1.Margin = new Padding(6, 5, 6, 5);
            button_dtoexample1.Name = "button_dtoexample1";
            button_dtoexample1.Size = new Size(497, 41);
            button_dtoexample1.TabIndex = 34;
            button_dtoexample1.Text = "Pregled odeljenja";
            button_dtoexample1.UseVisualStyleBackColor = true;
            button_dtoexample1.Click += button_dtoexample1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 695);
            Controls.Add(button_dtoexample1);
            Controls.Add(cmdLINQ2);
            Controls.Add(cmdLINQ1);
            Controls.Add(cmdLINQ);
            Controls.Add(cmdTransaction);
            Controls.Add(cmdDelete);
            Controls.Add(cmdUpdate);
            Controls.Add(cmdQueryOver);
            Controls.Add(cmdSQL);
            Controls.Add(cmdCriteria);
            Controls.Add(cmdPaging);
            Controls.Add(cmdMultiple);
            Controls.Add(cmdUnique);
            Controls.Add(cmdScalar);
            Controls.Add(smdEnumerable);
            Controls.Add(cmdQueryNamedParameters1);
            Controls.Add(cmdQueryNamedParamters);
            Controls.Add(cmdQueryParameters);
            Controls.Add(cmdQuery1);
            Controls.Add(cmdQuery);
            Controls.Add(cmdRefresh);
            Controls.Add(cmdGet);
            Controls.Add(cmdCreateSubclassOdeljenje);
            Controls.Add(button1);
            Controls.Add(cmdCreateVojnik);
            Controls.Add(cmdTPC);
            Controls.Add(cmdCreateRadiU);
            Controls.Add(cmdCreateRadnik);
            Controls.Add(cmdManyToMany);
            Controls.Add(cmdCreateOdeljenje);
            Controls.Add(cmdOneToMany);
            Controls.Add(cmdManytoOne);
            Controls.Add(cmdCreate);
            Controls.Add(cmdRead);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdManytoOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdCreateOdeljenje;
        private System.Windows.Forms.Button cmdManyToMany;
        private System.Windows.Forms.Button cmdCreateRadnik;
        private System.Windows.Forms.Button cmdCreateRadiU;
        private System.Windows.Forms.Button cmdTPC;
        private System.Windows.Forms.Button cmdCreateVojnik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdCreateSubclassOdeljenje;
        private System.Windows.Forms.Button cmdGet;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdQuery;
        private System.Windows.Forms.Button cmdQuery1;
        private System.Windows.Forms.Button cmdQueryParameters;
        private System.Windows.Forms.Button cmdQueryNamedParamters;
        private System.Windows.Forms.Button cmdQueryNamedParameters1;
        private System.Windows.Forms.Button smdEnumerable;
        private System.Windows.Forms.Button cmdScalar;
        private System.Windows.Forms.Button cmdUnique;
        private System.Windows.Forms.Button cmdMultiple;
        private System.Windows.Forms.Button cmdPaging;
        private System.Windows.Forms.Button cmdCriteria;
        private System.Windows.Forms.Button cmdSQL;
        private System.Windows.Forms.Button cmdQueryOver;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdTransaction;
        private System.Windows.Forms.Button cmdLINQ;
        private System.Windows.Forms.Button cmdLINQ1;
        private System.Windows.Forms.Button cmdLINQ2;
        private System.Windows.Forms.Button button_dtoexample1;
    }
}

