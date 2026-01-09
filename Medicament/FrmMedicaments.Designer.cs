namespace Medicament
{
    partial class FrmMedicaments
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.familleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gsbrapports2016DataSet1 = new Medicament.gsbrapports2016DataSet1();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.familleTableAdapter = new Medicament.gsbrapports2016DataSet1TableAdapters.familleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.familleBindingSource1;
            this.comboBox1.DisplayMember = "libelle";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(733, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // familleBindingSource1
            // 
            this.familleBindingSource1.DataMember = "famille";
            this.familleBindingSource1.DataSource = this.gsbrapports2016DataSet1;
            // 
            // gsbrapports2016DataSet1
            // 
            this.gsbrapports2016DataSet1.DataSetName = "gsbrapports2016DataSet1";
            this.gsbrapports2016DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(Medicament.famille);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Famille Médicaments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "sélectionner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // familleTableAdapter
            // 
            this.familleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmMedicaments";
            this.Text = "Famille medicaments";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private gsbrapports2016DataSet1 gsbrapports2016DataSet1;
        private System.Windows.Forms.BindingSource familleBindingSource1;
        private gsbrapports2016DataSet1TableAdapters.familleTableAdapter familleTableAdapter;
    }
}

