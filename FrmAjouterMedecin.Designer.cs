
namespace Mission3_vA
{
    partial class FrmAjouterMedecin
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
            this.grpAjoutMedecin = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtSpcAjou = new System.Windows.Forms.TextBox();
            this.txtTelAjou = new System.Windows.Forms.TextBox();
            this.txtAdressAjou = new System.Windows.Forms.TextBox();
            this.txtPrenomajou = new System.Windows.Forms.TextBox();
            this.txtNomAjou = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepaErg = new System.Windows.Forms.ComboBox();
            this.bdgAjoutMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.grpAjoutMedecin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAjoutMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAjoutMedecin
            // 
            this.grpAjoutMedecin.Controls.Add(this.cmbDepaErg);
            this.grpAjoutMedecin.Controls.Add(this.btnEnregistrer);
            this.grpAjoutMedecin.Controls.Add(this.txtSpcAjou);
            this.grpAjoutMedecin.Controls.Add(this.txtTelAjou);
            this.grpAjoutMedecin.Controls.Add(this.txtAdressAjou);
            this.grpAjoutMedecin.Controls.Add(this.txtPrenomajou);
            this.grpAjoutMedecin.Controls.Add(this.txtNomAjou);
            this.grpAjoutMedecin.Controls.Add(this.label8);
            this.grpAjoutMedecin.Controls.Add(this.label7);
            this.grpAjoutMedecin.Controls.Add(this.label6);
            this.grpAjoutMedecin.Controls.Add(this.label5);
            this.grpAjoutMedecin.Controls.Add(this.label4);
            this.grpAjoutMedecin.Controls.Add(this.label3);
            this.grpAjoutMedecin.Location = new System.Drawing.Point(12, 12);
            this.grpAjoutMedecin.Name = "grpAjoutMedecin";
            this.grpAjoutMedecin.Size = new System.Drawing.Size(455, 305);
            this.grpAjoutMedecin.TabIndex = 2;
            this.grpAjoutMedecin.TabStop = false;
            this.grpAjoutMedecin.Text = "Ajouter un  médecin";
            this.grpAjoutMedecin.Enter += new System.EventHandler(this.grpAjoutMedecin_Enter);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(288, 262);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(134, 23);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtSpcAjou
            // 
            this.txtSpcAjou.Location = new System.Drawing.Point(191, 176);
            this.txtSpcAjou.Name = "txtSpcAjou";
            this.txtSpcAjou.Size = new System.Drawing.Size(204, 20);
            this.txtSpcAjou.TabIndex = 10;
            // 
            // txtTelAjou
            // 
            this.txtTelAjou.Location = new System.Drawing.Point(104, 141);
            this.txtTelAjou.Name = "txtTelAjou";
            this.txtTelAjou.Size = new System.Drawing.Size(196, 20);
            this.txtTelAjou.TabIndex = 9;
            // 
            // txtAdressAjou
            // 
            this.txtAdressAjou.Location = new System.Drawing.Point(104, 103);
            this.txtAdressAjou.Name = "txtAdressAjou";
            this.txtAdressAjou.Size = new System.Drawing.Size(196, 20);
            this.txtAdressAjou.TabIndex = 8;
            // 
            // txtPrenomajou
            // 
            this.txtPrenomajou.Location = new System.Drawing.Point(104, 67);
            this.txtPrenomajou.Name = "txtPrenomajou";
            this.txtPrenomajou.Size = new System.Drawing.Size(196, 20);
            this.txtPrenomajou.TabIndex = 7;
            // 
            // txtNomAjou
            // 
            this.txtNomAjou.Location = new System.Drawing.Point(104, 37);
            this.txtNomAjou.Name = "txtNomAjou";
            this.txtNomAjou.Size = new System.Drawing.Size(196, 20);
            this.txtNomAjou.TabIndex = 6;
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
            // cmbDepaErg
            // 
            this.cmbDepaErg.FormattingEnabled = true;
            this.cmbDepaErg.Location = new System.Drawing.Point(136, 208);
            this.cmbDepaErg.Name = "cmbDepaErg";
            this.cmbDepaErg.Size = new System.Drawing.Size(121, 21);
            this.cmbDepaErg.TabIndex = 13;
            // 
            // bdgAjoutMedecin
            // 
            this.bdgAjoutMedecin.DataSource = typeof(Mission3_vA.medecin);
            // 
            // FrmAjouterMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAjoutMedecin);
            this.Name = "FrmAjouterMedecin";
            this.Text = "FrmAjouterMedecin";
            this.Load += new System.EventHandler(this.FrmAjouterMedecin_Load);
            this.grpAjoutMedecin.ResumeLayout(false);
            this.grpAjoutMedecin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAjoutMedecin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAjoutMedecin;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtSpcAjou;
        private System.Windows.Forms.TextBox txtTelAjou;
        private System.Windows.Forms.TextBox txtAdressAjou;
        private System.Windows.Forms.TextBox txtPrenomajou;
        private System.Windows.Forms.TextBox txtNomAjou;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepaErg;
        private System.Windows.Forms.BindingSource bdgAjoutMedecin;
    }
}