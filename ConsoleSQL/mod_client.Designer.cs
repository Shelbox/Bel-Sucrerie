namespace ConsoleSQL
{
    partial class mod_client
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
            this.code_c = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code_c
            // 
            this.code_c.Location = new System.Drawing.Point(112, 83);
            this.code_c.Name = "code_c";
            this.code_c.Size = new System.Drawing.Size(203, 20);
            this.code_c.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(112, 109);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(203, 20);
            this.nom.TabIndex = 1;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(112, 135);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(203, 20);
            this.adresse.TabIndex = 2;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(112, 161);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(203, 20);
            this.cp.TabIndex = 3;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(112, 187);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(203, 20);
            this.ville.TabIndex = 4;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(112, 213);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(203, 20);
            this.telephone.TabIndex = 5;
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(240, 270);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(75, 38);
            this.yes.TabIndex = 6;
            this.yes.Text = "Valider";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(112, 270);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 38);
            this.no.TabIndex = 7;
            this.no.Text = "Annuler";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(12, 12);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 38);
            this.btn_ajout.TabIndex = 8;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(327, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 38);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // mod_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 444);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.code_c);
            this.Name = "mod_client";
            this.Text = "Modification de client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox code_c;
        public System.Windows.Forms.TextBox nom;
        public System.Windows.Forms.TextBox adresse;
        public System.Windows.Forms.TextBox cp;
        public System.Windows.Forms.TextBox ville;
        public System.Windows.Forms.TextBox telephone;
        public System.Windows.Forms.Button yes;
        public System.Windows.Forms.Button no;
        public System.Windows.Forms.Button btn_ajout;
        public System.Windows.Forms.Button btn_delete;
    }
}