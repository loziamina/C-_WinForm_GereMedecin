
namespace Mission3_vA
{
    partial class FrmGererMedecin
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
            this.components = new System.ComponentModel.Container();
            this.grBChercher = new System.Windows.Forms.GroupBox();
            this.btnSupprime = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbNomCh = new System.Windows.Forms.ComboBox();
            this.bdgMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpModifierMedecin = new System.Windows.Forms.GroupBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.txtSpc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNomMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepaMod = new System.Windows.Forms.ComboBox();
            this.grBChercher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
            this.grpModifierMedecin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBChercher
            // 
            this.grBChercher.Controls.Add(this.btnSupprime);
            this.grBChercher.Controls.Add(this.btnAjout);
            this.grBChercher.Controls.Add(this.btnChercher);
            this.grBChercher.Controls.Add(this.cmbDepart);
            this.grBChercher.Controls.Add(this.cmbNomCh);
            this.grBChercher.Controls.Add(this.label2);
            this.grBChercher.Controls.Add(this.label1);
            this.grBChercher.Location = new System.Drawing.Point(12, 32);
            this.grBChercher.Name = "grBChercher";
            this.grBChercher.Size = new System.Drawing.Size(553, 159);
            this.grBChercher.TabIndex = 0;
            this.grBChercher.TabStop = false;
            this.grBChercher.Text = "Chercher un médecin";
            // 
            // btnSupprime
            // 
            this.btnSupprime.Location = new System.Drawing.Point(323, 60);
            this.btnSupprime.Name = "btnSupprime";
            this.btnSupprime.Size = new System.Drawing.Size(159, 23);
            this.btnSupprime.TabIndex = 6;
            this.btnSupprime.Text = "Supprimer un médecin";
            this.btnSupprime.UseVisualStyleBackColor = true;
            this.btnSupprime.Click += new System.EventHandler(this.btnSupprime_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(323, 31);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(159, 23);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter un médecin";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(150, 119);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(75, 23);
            this.btnChercher.TabIndex = 4;
            this.btnChercher.Text = "Recherche";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // cmbDepart
            // 
            this.cmbDepart.DisplayMember = "departement";
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(104, 78);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbDepart.TabIndex = 3;
            this.cmbDepart.ValueMember = "departement";
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.cmbDepart_SelectedIndexChanged);
            // 
            // cmbNomCh
            // 
            this.cmbNomCh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgMedecin, "nom", true));
            this.cmbNomCh.DataSource = this.bdgMedecin;
            this.cmbNomCh.DisplayMember = "nom";
            this.cmbNomCh.FormattingEnabled = true;
            this.cmbNomCh.Location = new System.Drawing.Point(104, 42);
            this.cmbNomCh.Name = "cmbNomCh";
            this.cmbNomCh.Size = new System.Drawing.Size(121, 21);
            this.cmbNomCh.TabIndex = 2;
            this.cmbNomCh.SelectedIndexChanged += new System.EventHandler(this.cmbNomCh_SelectedIndexChanged);
            // 
            // bdgMedecin
            // 
            this.bdgMedecin.DataSource = typeof(Mission3_vA.medecin);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Département : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // grpModifierMedecin
            // 
            this.grpModifierMedecin.Controls.Add(this.cmbDepaMod);
            this.grpModifierMedecin.Controls.Add(this.btnModif);
            this.grpModifierMedecin.Controls.Add(this.txtSpc);
            this.grpModifierMedecin.Controls.Add(this.txtTel);
            this.grpModifierMedecin.Controls.Add(this.txtAdress);
            this.grpModifierMedecin.Controls.Add(this.txtPrenom);
            this.grpModifierMedecin.Controls.Add(this.txtNomMod);
            this.grpModifierMedecin.Controls.Add(this.label8);
            this.grpModifierMedecin.Controls.Add(this.label7);
            this.grpModifierMedecin.Controls.Add(this.label6);
            this.grpModifierMedecin.Controls.Add(this.label5);
            this.grpModifierMedecin.Controls.Add(this.label4);
            this.grpModifierMedecin.Controls.Add(this.label3);
            this.grpModifierMedecin.Location = new System.Drawing.Point(12, 197);
            this.grpModifierMedecin.Name = "grpModifierMedecin";
            this.grpModifierMedecin.Size = new System.Drawing.Size(553, 250);
            this.grpModifierMedecin.TabIndex = 1;
            this.grpModifierMedecin.TabStop = false;
            this.grpModifierMedecin.Text = "Les Informations d\'un medecin";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(403, 216);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(134, 23);
            this.btnModif.TabIndex = 12;
            this.btnModif.Text = "Valider la modification";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // txtSpc
            // 
            this.txtSpc.Location = new System.Drawing.Point(191, 176);
            this.txtSpc.Name = "txtSpc";
            this.txtSpc.Size = new System.Drawing.Size(204, 20);
            this.txtSpc.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(104, 141);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(196, 20);
            this.txtTel.TabIndex = 9;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(104, 103);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(196, 20);
            this.txtAdress.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(104, 67);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(196, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // txtNomMod
            // 
            this.txtNomMod.Location = new System.Drawing.Point(104, 37);
            this.txtNomMod.Name = "txtNomMod";
            this.txtNomMod.Size = new System.Drawing.Size(196, 20);
            this.txtNomMod.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Deppartement : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Spécialité complémentaire : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tel : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adresse : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prénom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom : ";
            // 
            // cmbDepaMod
            // 
            this.cmbDepaMod.FormattingEnabled = true;
            this.cmbDepaMod.Location = new System.Drawing.Point(150, 213);
            this.cmbDepaMod.Name = "cmbDepaMod";
            this.cmbDepaMod.Size = new System.Drawing.Size(121, 21);
            this.cmbDepaMod.TabIndex = 13;
            // 
            // FrmGererMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpModifierMedecin);
            this.Controls.Add(this.grBChercher);
            this.Name = "FrmGererMedecin";
            this.Text = "FrmGererMedecin";
            this.Load += new System.EventHandler(this.FrmGererMedecin_Load);
            this.grBChercher.ResumeLayout(false);
            this.grBChercher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
            this.grpModifierMedecin.ResumeLayout(false);
            this.grpModifierMedecin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBChercher;
        private System.Windows.Forms.Button btnSupprime;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbNomCh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpModifierMedecin;
        private System.Windows.Forms.TextBox txtSpc;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNomMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.BindingSource bdgMedecin;
        private System.Windows.Forms.ComboBox cmbDepaMod;
    }
}