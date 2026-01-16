namespace Medicament
{
    partial class FrmModifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gsbrapports2016DataSet4 = new Medicament.gsbrapports2016DataSet4();
            this.button2 = new System.Windows.Forms.Button();
            this.familleTableAdapter = new Medicament.gsbrapports2016DataSet4TableAdapters.familleTableAdapter();
            this.gsbrapports2016DataSet1 = new Medicament.gsbrapports2016DataSet();
            this.gsbrapports2016DataSet5 = new Medicament.gsbrapports2016DataSet5();
            this.familleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.familleTableAdapter1 = new Medicament.gsbrapports2016DataSet5TableAdapters.familleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier la Famille";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.familleBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(127, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 491);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 200;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.Width = 200;
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataMember = "famille";
            this.familleBindingSource.DataSource = this.gsbrapports2016DataSet4;
            // 
            // gsbrapports2016DataSet4
            // 
            this.gsbrapports2016DataSet4.DataSetName = "gsbrapports2016DataSet4";
            this.gsbrapports2016DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(442, 106);
            this.button2.TabIndex = 3;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // familleTableAdapter
            // 
            this.familleTableAdapter.ClearBeforeFill = true;
            // 
            // gsbrapports2016DataSet1
            // 
            this.gsbrapports2016DataSet1.DataSetName = "gsbrapports2016DataSet";
            this.gsbrapports2016DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gsbrapports2016DataSet5
            // 
            this.gsbrapports2016DataSet5.DataSetName = "gsbrapports2016DataSet5";
            this.gsbrapports2016DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familleBindingSource1
            // 
            this.familleBindingSource1.DataMember = "famille";
            this.familleBindingSource1.DataSource = this.gsbrapports2016DataSet5;
            // 
            // familleTableAdapter1
            // 
            this.familleTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 874);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifier";
            this.Text = "FrmModifier";
            this.Load += new System.EventHandler(this.FrmModifier_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbrapports2016DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private gsbrapports2016DataSet4 gsbrapports2016DataSet4;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private gsbrapports2016DataSet4TableAdapters.familleTableAdapter familleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private gsbrapports2016DataSet gsbrapports2016DataSet1;
        private gsbrapports2016DataSet5 gsbrapports2016DataSet5;
        private System.Windows.Forms.BindingSource familleBindingSource1;
        private gsbrapports2016DataSet5TableAdapters.familleTableAdapter familleTableAdapter1;
    }
}