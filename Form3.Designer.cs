namespace fairplay
{
    partial class Form3
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtrechercher = new System.Windows.Forms.TextBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.btnvalider = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfonction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsalaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbclasse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(78, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 22);
            this.txtid.TabIndex = 59;
            this.txtid.Visible = false;
            // 
            // txtrechercher
            // 
            this.txtrechercher.Location = new System.Drawing.Point(600, 166);
            this.txtrechercher.Name = "txtrechercher";
            this.txtrechercher.Size = new System.Drawing.Size(129, 22);
            this.txtrechercher.TabIndex = 57;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(219, 166);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(102, 36);
            this.btnmodifier.TabIndex = 56;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.Location = new System.Drawing.Point(338, 166);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(102, 36);
            this.btnsuprimer.TabIndex = 55;
            this.btnsuprimer.Text = "Suprimer";
            this.btnsuprimer.UseVisualStyleBackColor = true;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btnrechercher
            // 
            this.btnrechercher.Location = new System.Drawing.Point(458, 166);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(102, 36);
            this.btnrechercher.TabIndex = 54;
            this.btnrechercher.Text = "Rechercher";
            this.btnrechercher.UseVisualStyleBackColor = true;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(1, 218);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(799, 228);
            this.dGV1.TabIndex = 53;
            this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(95, 166);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(102, 36);
            this.btnvalider.TabIndex = 52;
            this.btnvalider.Text = "valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "departement";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(78, 96);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(129, 22);
            this.txtnom.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "nom";
            // 
            // txtfonction
            // 
            this.txtfonction.Location = new System.Drawing.Point(382, 46);
            this.txtfonction.Name = "txtfonction";
            this.txtfonction.Size = new System.Drawing.Size(129, 22);
            this.txtfonction.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fonction";
            // 
            // txtsalaire
            // 
            this.txtsalaire.Location = new System.Drawing.Point(382, 102);
            this.txtsalaire.Name = "txtsalaire";
            this.txtsalaire.Size = new System.Drawing.Size(129, 22);
            this.txtsalaire.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Salaire";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(78, 49);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(129, 22);
            this.txtprenom.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ajout Employee";
            // 
            // cmbclasse
            // 
            this.cmbclasse.FormattingEnabled = true;
            this.cmbclasse.Location = new System.Drawing.Point(639, 46);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(121, 24);
            this.cmbclasse.TabIndex = 60;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbclasse);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtrechercher);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfonction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsalaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtrechercher;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfonction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsalaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbclasse;
    }
}