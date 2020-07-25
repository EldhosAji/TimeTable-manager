namespace TBManager
{
    partial class code
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDataSet = new TBManager.dbDataSet();
            this.courceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courceTableAdapter = new TBManager.dbDataSetTableAdapters.courceTableAdapter();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courceBindingSource
            // 
            this.courceBindingSource.DataMember = "cource";
            this.courceBindingSource.DataSource = this.dbDataSet;
            // 
            // courceTableAdapter
            // 
            this.courceTableAdapter.ClearBeforeFill = true;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "cource id";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "cource name";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 329);
            this.Controls.Add(this.dataGridView1);
            this.Name = "code";
            this.Text = "code";
            this.Load += new System.EventHandler(this.code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource courceBindingSource;
        private dbDataSetTableAdapters.courceTableAdapter courceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
    }
}