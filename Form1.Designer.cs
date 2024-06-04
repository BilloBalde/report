namespace fairplay
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagrammeEmployeesfonctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesDepartementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departementToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.departementToolStripMenuItem.Text = "Departement";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEmployeesToolStripMenuItem,
            this.diagrammeEmployeesfonctionToolStripMenuItem,
            this.listeDesDepartementsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // listeDesEmployeesToolStripMenuItem
            // 
            this.listeDesEmployeesToolStripMenuItem.Name = "listeDesEmployeesToolStripMenuItem";
            this.listeDesEmployeesToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.listeDesEmployeesToolStripMenuItem.Text = "liste des employees";
            this.listeDesEmployeesToolStripMenuItem.Click += new System.EventHandler(this.listeDesEmployeesToolStripMenuItem_Click);
            // 
            // diagrammeEmployeesfonctionToolStripMenuItem
            // 
            this.diagrammeEmployeesfonctionToolStripMenuItem.Name = "diagrammeEmployeesfonctionToolStripMenuItem";
            this.diagrammeEmployeesfonctionToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.diagrammeEmployeesfonctionToolStripMenuItem.Text = "Diagramme employees/fonction";
            this.diagrammeEmployeesfonctionToolStripMenuItem.Click += new System.EventHandler(this.diagrammeEmployeesfonctionToolStripMenuItem_Click);
            // 
            // listeDesDepartementsToolStripMenuItem
            // 
            this.listeDesDepartementsToolStripMenuItem.Name = "listeDesDepartementsToolStripMenuItem";
            this.listeDesDepartementsToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.listeDesDepartementsToolStripMenuItem.Text = "liste des departements";
            this.listeDesDepartementsToolStripMenuItem.Click += new System.EventHandler(this.listeDesDepartementsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagrammeEmployeesfonctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesDepartementsToolStripMenuItem;
    }
}

