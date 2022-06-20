namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selecao = new System.Windows.Forms.ToolStripMenuItem();
            this.insercao = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsort = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsort = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksort = new System.Windows.Forms.ToolStripMenuItem();
            this.mergesort = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergesortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.selecao,
            this.insercao,
            this.shellsort,
            this.heapsort,
            this.quicksort,
            this.mergesort});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algoritmoToolStripMenuItem.Text = "Animações";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Bolha";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // selecao
            // 
            this.selecao.Name = "selecao";
            this.selecao.Size = new System.Drawing.Size(180, 22);
            this.selecao.Text = "Seleção";
            this.selecao.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // insercao
            // 
            this.insercao.Name = "insercao";
            this.insercao.Size = new System.Drawing.Size(180, 22);
            this.insercao.Text = "Inserção";
            this.insercao.Click += new System.EventHandler(this.insercao_Click);
            // 
            // shellsort
            // 
            this.shellsort.Name = "shellsort";
            this.shellsort.Size = new System.Drawing.Size(180, 22);
            this.shellsort.Text = "Shellsort";
            this.shellsort.Click += new System.EventHandler(this.shellsort_Click);
            // 
            // heapsort
            // 
            this.heapsort.Name = "heapsort";
            this.heapsort.Size = new System.Drawing.Size(180, 22);
            this.heapsort.Text = "Heapsort";
            this.heapsort.Click += new System.EventHandler(this.heapsort_Click);
            // 
            // quicksort
            // 
            this.quicksort.Name = "quicksort";
            this.quicksort.Size = new System.Drawing.Size(180, 22);
            this.quicksort.Text = "Quicksort";
            this.quicksort.Click += new System.EventHandler(this.quicksort_Click);
            // 
            // mergesort
            // 
            this.mergesort.Name = "mergesort";
            this.mergesort.Size = new System.Drawing.Size(180, 22);
            this.mergesort.Text = "Mergesort";
            this.mergesort.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellsortToolStripMenuItem,
            this.heapsortToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.mergesortToolStripMenuItem});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aleatorio",
            "Crescente",
            "Decrescente"});
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "10.000",
            "50.000",
            "100.000",
            "500.000"});
            this.comboBox2.Location = new System.Drawing.Point(316, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            this.seleçãoToolStripMenuItem.Click += new System.EventHandler(this.seleçãoToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // shellsortToolStripMenuItem
            // 
            this.shellsortToolStripMenuItem.Name = "shellsortToolStripMenuItem";
            this.shellsortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shellsortToolStripMenuItem.Text = "Shellsort";
            // 
            // heapsortToolStripMenuItem
            // 
            this.heapsortToolStripMenuItem.Name = "heapsortToolStripMenuItem";
            this.heapsortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heapsortToolStripMenuItem.Text = "Heapsort";
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            // 
            // mergesortToolStripMenuItem
            // 
            this.mergesortToolStripMenuItem.Name = "mergesortToolStripMenuItem";
            this.mergesortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mergesortToolStripMenuItem.Text = "Mergesort";
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 2022/1 - Métodos de Ordenação";
            this.Load += new System.EventHandler(this.FormOrdenacao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergesort;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selecao;
        private System.Windows.Forms.ToolStripMenuItem insercao;
        private System.Windows.Forms.ToolStripMenuItem shellsort;
        private System.Windows.Forms.ToolStripMenuItem heapsort;
        private System.Windows.Forms.ToolStripMenuItem quicksort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergesortToolStripMenuItem;
    }
}

