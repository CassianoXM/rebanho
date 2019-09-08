namespace SistRebanho.View
{
    partial class FrmRaca
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
            this.GrdRaca = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.TxtRaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.raçaDataSet = new SistRebanho.View.RaçaDataSet();
            this.rACABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rACATableAdapter = new SistRebanho.View.RaçaDataSetTableAdapters.RACATableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raçaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdRaca
            // 
            this.GrdRaca.AutoGenerateColumns = false;
            this.GrdRaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdRaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.racaDataGridViewTextBoxColumn});
            this.GrdRaca.DataSource = this.rACABindingSource;
            this.GrdRaca.Location = new System.Drawing.Point(12, 138);
            this.GrdRaca.Name = "GrdRaca";
            this.GrdRaca.Size = new System.Drawing.Size(525, 233);
            this.GrdRaca.TabIndex = 43;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(309, 91);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 29);
            this.btnSair.TabIndex = 42;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(228, 91);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 29);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtRaca
            // 
            this.TxtRaca.Location = new System.Drawing.Point(66, 53);
            this.TxtRaca.Name = "TxtRaca";
            this.TxtRaca.Size = new System.Drawing.Size(319, 20);
            this.TxtRaca.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Raça";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id";
            // 
            // raçaDataSet
            // 
            this.raçaDataSet.DataSetName = "RaçaDataSet";
            this.raçaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rACABindingSource
            // 
            this.rACABindingSource.DataMember = "RACA";
            this.rACABindingSource.DataSource = this.raçaDataSet;
            // 
            // rACATableAdapter
            // 
            this.rACATableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racaDataGridViewTextBoxColumn
            // 
            this.racaDataGridViewTextBoxColumn.DataPropertyName = "raca";
            this.racaDataGridViewTextBoxColumn.HeaderText = "raca";
            this.racaDataGridViewTextBoxColumn.Name = "racaDataGridViewTextBoxColumn";
            // 
            // FrmRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 396);
            this.Controls.Add(this.GrdRaca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.TxtRaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRaca";
            this.Text = "FrmRaca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRaca_FormClosed);
            this.Load += new System.EventHandler(this.FrmRaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raçaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdRaca;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox TxtRaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private RaçaDataSet raçaDataSet;
        private System.Windows.Forms.BindingSource rACABindingSource;
        private RaçaDataSetTableAdapters.RACATableAdapter rACATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racaDataGridViewTextBoxColumn;
    }
}