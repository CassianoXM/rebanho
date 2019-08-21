namespace SistRebanho.View
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRebanho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVacina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiagnostico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuraça = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManejo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPesagem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrdenha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCobertura = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReçatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebanhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coberturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.mnuManejo,
            this.mnuPesagem,
            this.mnuOrdenha,
            this.mnuCobertura,
            this.mnuParto,
            this.mnuReçatorio,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1420, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRebanho,
            this.mnuVacina,
            this.mnuDiagnostico,
            this.mnuraça});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // mnuRebanho
            // 
            this.mnuRebanho.Name = "mnuRebanho";
            this.mnuRebanho.Size = new System.Drawing.Size(180, 22);
            this.mnuRebanho.Text = "Rebanho";
            this.mnuRebanho.Click += new System.EventHandler(this.mnuRebanho_Click);
            // 
            // mnuVacina
            // 
            this.mnuVacina.Name = "mnuVacina";
            this.mnuVacina.Size = new System.Drawing.Size(180, 22);
            this.mnuVacina.Text = "Vacina";
            this.mnuVacina.Click += new System.EventHandler(this.mnuVacina_Click);
            // 
            // mnuDiagnostico
            // 
            this.mnuDiagnostico.Name = "mnuDiagnostico";
            this.mnuDiagnostico.Size = new System.Drawing.Size(180, 22);
            this.mnuDiagnostico.Text = "Diagnostico";
            // 
            // mnuraça
            // 
            this.mnuraça.Name = "mnuraça";
            this.mnuraça.Size = new System.Drawing.Size(180, 22);
            this.mnuraça.Text = "Raça";
            this.mnuraça.Click += new System.EventHandler(this.mnuraça_Click);
            // 
            // mnuManejo
            // 
            this.mnuManejo.Name = "mnuManejo";
            this.mnuManejo.Size = new System.Drawing.Size(71, 22);
            this.mnuManejo.Text = "Manejo";
            this.mnuManejo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuManejo.Click += new System.EventHandler(this.mnuManejo_Click);
            // 
            // mnuPesagem
            // 
            this.mnuPesagem.Name = "mnuPesagem";
            this.mnuPesagem.Size = new System.Drawing.Size(88, 22);
            this.mnuPesagem.Text = "Pesagem";
            this.mnuPesagem.Click += new System.EventHandler(this.mnuPesagem_Click);
            // 
            // mnuOrdenha
            // 
            this.mnuOrdenha.Name = "mnuOrdenha";
            this.mnuOrdenha.Size = new System.Drawing.Size(80, 22);
            this.mnuOrdenha.Text = "Ordenha";
            this.mnuOrdenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuCobertura
            // 
            this.mnuCobertura.Name = "mnuCobertura";
            this.mnuCobertura.Size = new System.Drawing.Size(90, 22);
            this.mnuCobertura.Text = "Cobertura";
            this.mnuCobertura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuCobertura.Click += new System.EventHandler(this.mnuCobertura_Click);
            // 
            // mnuParto
            // 
            this.mnuParto.Name = "mnuParto";
            this.mnuParto.Size = new System.Drawing.Size(58, 22);
            this.mnuParto.Text = "Parto";
            // 
            // mnuReçatorio
            // 
            this.mnuReçatorio.Name = "mnuReçatorio";
            this.mnuReçatorio.Size = new System.Drawing.Size(83, 22);
            this.mnuReçatorio.Text = "Relatorio";
            this.mnuReçatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(49, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebanhoToolStripMenuItem,
            this.raçaToolStripMenuItem,
            this.partoToolStripMenuItem,
            this.coberturaToolStripMenuItem,
            this.manejoToolStripMenuItem,
            this.vacinaToolStripMenuItem,
            this.diagnosticoToolStripMenuItem,
            this.pesagemToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // rebanhoToolStripMenuItem
            // 
            this.rebanhoToolStripMenuItem.Name = "rebanhoToolStripMenuItem";
            this.rebanhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rebanhoToolStripMenuItem.Text = "Rebanho";
            // 
            // raçaToolStripMenuItem
            // 
            this.raçaToolStripMenuItem.Name = "raçaToolStripMenuItem";
            this.raçaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raçaToolStripMenuItem.Text = "Raça";
            // 
            // partoToolStripMenuItem
            // 
            this.partoToolStripMenuItem.Name = "partoToolStripMenuItem";
            this.partoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.partoToolStripMenuItem.Text = "Parto";
            // 
            // coberturaToolStripMenuItem
            // 
            this.coberturaToolStripMenuItem.Name = "coberturaToolStripMenuItem";
            this.coberturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coberturaToolStripMenuItem.Text = "Cobertura";
            // 
            // manejoToolStripMenuItem
            // 
            this.manejoToolStripMenuItem.Name = "manejoToolStripMenuItem";
            this.manejoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manejoToolStripMenuItem.Text = "Manejo";
            // 
            // vacinaToolStripMenuItem
            // 
            this.vacinaToolStripMenuItem.Name = "vacinaToolStripMenuItem";
            this.vacinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vacinaToolStripMenuItem.Text = "Vacina";
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diagnosticoToolStripMenuItem.Text = "Diagnostico";
            // 
            // pesagemToolStripMenuItem
            // 
            this.pesagemToolStripMenuItem.Name = "pesagemToolStripMenuItem";
            this.pesagemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesagemToolStripMenuItem.Text = "Pesagem";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1420, 674);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mnuraça;
        public System.Windows.Forms.ToolStripMenuItem mnuRebanho;
        public System.Windows.Forms.ToolStripMenuItem mnuVacina;
        public System.Windows.Forms.ToolStripMenuItem mnuDiagnostico;
        public System.Windows.Forms.ToolStripMenuItem mnuOrdenha;
        public System.Windows.Forms.ToolStripMenuItem mnuPesagem;
        public System.Windows.Forms.ToolStripMenuItem mnuReçatorio;
        public System.Windows.Forms.ToolStripMenuItem mnuSair;
        public System.Windows.Forms.ToolStripMenuItem mnuParto;
        public System.Windows.Forms.ToolStripMenuItem mnuCobertura;
        public System.Windows.Forms.ToolStripMenuItem mnuManejo;
        public System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebanhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coberturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesagemToolStripMenuItem;
    }
}