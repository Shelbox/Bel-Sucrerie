namespace ConsoleSQL
{
    partial class index
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
            this.grille = new System.Windows.Forms.DataGridView();
            this.recherche = new System.Windows.Forms.Button();
            this.selectTable = new System.Windows.Forms.ComboBox();
            this.debug = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).BeginInit();
            this.SuspendLayout();
            // 
            // grille
            // 
            this.grille.AllowUserToAddRows = false;
            this.grille.AllowUserToDeleteRows = false;
            this.grille.AllowUserToResizeColumns = false;
            this.grille.AllowUserToResizeRows = false;
            this.grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grille.Location = new System.Drawing.Point(30, 208);
            this.grille.MultiSelect = false;
            this.grille.Name = "grille";
            this.grille.Size = new System.Drawing.Size(1147, 380);
            this.grille.TabIndex = 0;
            this.grille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(1079, 104);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(98, 39);
            this.recherche.TabIndex = 1;
            this.recherche.Text = "recherche";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            // 
            // selectTable
            // 
            this.selectTable.FormattingEnabled = true;
            this.selectTable.Location = new System.Drawing.Point(1056, 52);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(121, 21);
            this.selectTable.TabIndex = 2;
            this.selectTable.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(30, 12);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(268, 165);
            this.debug.TabIndex = 3;
            this.debug.Text = "";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 600);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.selectTable);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.grille);
            this.Name = "index";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grille;
        public System.Windows.Forms.Button recherche;
        public System.Windows.Forms.ComboBox selectTable;
        public System.Windows.Forms.RichTextBox debug;
    }
}

