
namespace Mission3_vA
{
    partial class FrmRapport
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
            this.btnChercher = new System.Windows.Forms.Button();
            this.cmbDeparRpp = new System.Windows.Forms.ComboBox();
            this.cmbNomRapp = new System.Windows.Forms.ComboBox();
            this.bdgRapMed = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRapport = new System.Windows.Forms.GroupBox();
            this.dataGridRapport = new System.Windows.Forms.DataGridView();
            this.dateDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirRapport = new System.Windows.Forms.BindingSource(this.components);
            this.btnXML = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            this.offrirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdgRepMedic = new System.Windows.Forms.BindingSource(this.components);
            this.grBChercher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapMed)).BeginInit();
            this.grpRapport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrirRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRepMedic)).BeginInit();
            this.SuspendLayout();
            // 
            // grBChercher
            // 
            this.grBChercher.Controls.Add(this.btnChercher);
            this.grBChercher.Controls.Add(this.cmbDeparRpp);
            this.grBChercher.Controls.Add(this.cmbNomRapp);
            this.grBChercher.Controls.Add(this.label2);
            this.grBChercher.Controls.Add(this.label1);
            this.grBChercher.Location = new System.Drawing.Point(0, 0);
            this.grBChercher.Name = "grBChercher";
            this.grBChercher.Size = new System.Drawing.Size(669, 159);
            this.grBChercher.TabIndex = 1;
            this.grBChercher.TabStop = false;
            this.grBChercher.Text = "Chercher un médecin";
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(372, 56);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(97, 23);
            this.btnChercher.TabIndex = 4;
            this.btnChercher.Text = "Recherche";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // cmbDeparRpp
            // 
            this.cmbDeparRpp.FormattingEnabled = true;
            this.cmbDeparRpp.Location = new System.Drawing.Point(104, 76);
            this.cmbDeparRpp.Name = "cmbDeparRpp";
            this.cmbDeparRpp.Size = new System.Drawing.Size(178, 21);
            this.cmbDeparRpp.TabIndex = 3;
            // 
            // cmbNomRapp
            // 
            this.cmbNomRapp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgRapMed, "nom", true));
            this.cmbNomRapp.DataSource = this.bdgRapMed;
            this.cmbNomRapp.DisplayMember = "nom";
            this.cmbNomRapp.FormattingEnabled = true;
            this.cmbNomRapp.Location = new System.Drawing.Point(104, 42);
            this.cmbNomRapp.Name = "cmbNomRapp";
            this.cmbNomRapp.Size = new System.Drawing.Size(178, 21);
            this.cmbNomRapp.TabIndex = 2;
            this.cmbNomRapp.SelectedIndexChanged += new System.EventHandler(this.cmbNomRapp_SelectedIndexChanged);
            // 
            // bdgRapMed
            // 
            this.bdgRapMed.DataSource = typeof(Mission3_vA.medecin);
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
            // grpRapport
            // 
            this.grpRapport.Controls.Add(this.dataGridRapport);
            this.grpRapport.Controls.Add(this.btnXML);
            this.grpRapport.Controls.Add(this.label3);
            this.grpRapport.Location = new System.Drawing.Point(13, 166);
            this.grpRapport.Name = "grpRapport";
            this.grpRapport.Size = new System.Drawing.Size(656, 255);
            this.grpRapport.TabIndex = 2;
            this.grpRapport.TabStop = false;
            this.grpRapport.Text = "Dernier Rapport ";
            this.grpRapport.Enter += new System.EventHandler(this.grpRapport_Enter);
            // 
            // dataGridRapport
            // 
            this.dataGridRapport.AutoGenerateColumns = false;
            this.dataGridRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridView,
            this.motifDataGridView,
            this.bilanDataGridView,
            this.medecinDataGridView,
            this.offrirDataGridView,
            this.visiteurDataGridView});
            this.dataGridRapport.DataSource = this.offrirRapport;
            this.dataGridRapport.Location = new System.Drawing.Point(6, 51);
            this.dataGridRapport.Name = "dataGridRapport";
            this.dataGridRapport.Size = new System.Drawing.Size(639, 150);
            this.dataGridRapport.TabIndex = 11;
            this.dataGridRapport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRapport_CellContentClick);
            // 
            // dateDataGridView
            // 
            this.dateDataGridView.DataPropertyName = "date";
            this.dateDataGridView.HeaderText = "date";
            this.dateDataGridView.Name = "dateDataGridView";
            // 
            // motifDataGridView
            // 
            this.motifDataGridView.DataPropertyName = "motif";
            this.motifDataGridView.HeaderText = "motif";
            this.motifDataGridView.Name = "motifDataGridView";
            // 
            // bilanDataGridView
            // 
            this.bilanDataGridView.DataPropertyName = "bilan";
            this.bilanDataGridView.HeaderText = "bilan";
            this.bilanDataGridView.Name = "bilanDataGridView";
            // 
            // medecinDataGridView
            // 
            this.medecinDataGridView.DataPropertyName = "medecin";
            this.medecinDataGridView.HeaderText = "medecin";
            this.medecinDataGridView.Name = "medecinDataGridView";
            // 
            // offrirDataGridView
            // 
            this.offrirDataGridView.DataPropertyName = "offrir";
            this.offrirDataGridView.HeaderText = "offrir";
            this.offrirDataGridView.Name = "offrirDataGridView";
            // 
            // visiteurDataGridView
            // 
            this.visiteurDataGridView.DataPropertyName = "visiteur";
            this.visiteurDataGridView.HeaderText = "visiteur";
            this.visiteurDataGridView.Name = "visiteurDataGridView";
            // 
            // offrirRapport
            // 
            this.offrirRapport.DataSource = typeof(Mission3_vA.rapport);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(333, 212);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(141, 23);
            this.btnXML.TabIndex = 10;
            this.btnXML.Text = "Exporter au format .xml ";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(Mission3_vA.rapport);
            // 
            // offrirBindingSource
            // 
            this.offrirBindingSource.DataSource = typeof(Mission3_vA.offrir);
            // 
            // bdgRepMedic
            // 
            this.bdgRepMedic.DataSource = typeof(Mission3_vA.offrir);
            // 
            // FrmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.grpRapport);
            this.Controls.Add(this.grBChercher);
            this.Name = "FrmRapport";
            this.Text = "FrmRapport";
            this.Load += new System.EventHandler(this.FrmRapport_Load);
            this.grBChercher.ResumeLayout(false);
            this.grBChercher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapMed)).EndInit();
            this.grpRapport.ResumeLayout(false);
            this.grpRapport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrirRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offrirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRepMedic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBChercher;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.ComboBox cmbDeparRpp;
        private System.Windows.Forms.ComboBox cmbNomRapp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRapport;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdgRapMed;
        private System.Windows.Forms.BindingSource bdgRepMedic;
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.BindingSource offrirBindingSource;
        private System.Windows.Forms.DataGridView dataGridRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiteurDataGridView;
        private System.Windows.Forms.BindingSource offrirRapport;
    }
}