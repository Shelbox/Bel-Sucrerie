namespace ConsoleSQL
{
    partial class mod_commande
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.yes = new System.Windows.Forms.Button();
            this.total_ht = new System.Windows.Forms.TextBox();
            this.code_c = new System.Windows.Forms.TextBox();
            this.code_v = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.total_tva = new System.Windows.Forms.TextBox();
            this.date_livraison = new System.Windows.Forms.DateTimePicker();
            this.date_commande = new System.Windows.Forms.DateTimePicker();
            this.etat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(326, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 38);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(11, 12);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 38);
            this.btn_ajout.TabIndex = 18;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(111, 337);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 38);
            this.no.TabIndex = 17;
            this.no.Text = "Annuler";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(239, 337);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(75, 38);
            this.yes.TabIndex = 16;
            this.yes.Text = "Valider";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // total_ht
            // 
            this.total_ht.Location = new System.Drawing.Point(111, 213);
            this.total_ht.Name = "total_ht";
            this.total_ht.Size = new System.Drawing.Size(203, 20);
            this.total_ht.TabIndex = 15;
            // 
            // code_c
            // 
            this.code_c.Location = new System.Drawing.Point(111, 135);
            this.code_c.Name = "code_c";
            this.code_c.Size = new System.Drawing.Size(203, 20);
            this.code_c.TabIndex = 12;
            // 
            // code_v
            // 
            this.code_v.Location = new System.Drawing.Point(111, 109);
            this.code_v.Name = "code_v";
            this.code_v.Size = new System.Drawing.Size(203, 20);
            this.code_v.TabIndex = 11;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(111, 83);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(203, 20);
            this.numero.TabIndex = 10;
            // 
            // total_tva
            // 
            this.total_tva.Location = new System.Drawing.Point(111, 239);
            this.total_tva.Name = "total_tva";
            this.total_tva.Size = new System.Drawing.Size(203, 20);
            this.total_tva.TabIndex = 20;
            // 
            // date_livraison
            // 
            this.date_livraison.Location = new System.Drawing.Point(111, 161);
            this.date_livraison.Name = "date_livraison";
            this.date_livraison.Size = new System.Drawing.Size(200, 20);
            this.date_livraison.TabIndex = 22;
            // 
            // date_commande
            // 
            this.date_commande.Location = new System.Drawing.Point(111, 187);
            this.date_commande.Name = "date_commande";
            this.date_commande.Size = new System.Drawing.Size(200, 20);
            this.date_commande.TabIndex = 23;
            // 
            // etat
            // 
            this.etat.AutoSize = true;
            this.etat.Location = new System.Drawing.Point(111, 265);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(44, 17);
            this.etat.TabIndex = 24;
            this.etat.Text = "etat";
            this.etat.UseVisualStyleBackColor = true;
            // 
            // mod_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 445);
            this.Controls.Add(this.etat);
            this.Controls.Add(this.date_commande);
            this.Controls.Add(this.date_livraison);
            this.Controls.Add(this.total_tva);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.total_ht);
            this.Controls.Add(this.code_c);
            this.Controls.Add(this.code_v);
            this.Controls.Add(this.numero);
            this.Name = "mod_commande";
            this.Text = "Modification de commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_ajout;
        public System.Windows.Forms.Button no;
        public System.Windows.Forms.Button yes;
        public System.Windows.Forms.TextBox total_ht;
        public System.Windows.Forms.TextBox code_c;
        public System.Windows.Forms.TextBox code_v;
        public System.Windows.Forms.TextBox numero;
        public System.Windows.Forms.TextBox total_tva;
        private System.Windows.Forms.DateTimePicker date_livraison;
        private System.Windows.Forms.DateTimePicker date_commande;
        private System.Windows.Forms.CheckBox etat;
    }
}