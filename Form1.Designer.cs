namespace Gerenciador_de_processos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxProcesso = new System.Windows.Forms.TextBox();
            this.labelProcesso = new System.Windows.Forms.Label();
            this.labelNMaximoDeThreads = new System.Windows.Forms.Label();
            this.numericUpDownNMaximoDeThreads = new System.Windows.Forms.NumericUpDown();
            this.buttonMonitorar = new System.Windows.Forms.Button();
            this.listBoxProcessos = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelProcessosEmExecucao = new System.Windows.Forms.Label();
            this.labelQtdProcessos = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelProcessosEncerrados = new System.Windows.Forms.Label();
            this.qtdProcessosEncerrados = new System.Windows.Forms.Label();
            this.labelListBoxProcessos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNMaximoDeThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProcesso
            // 
            this.textBoxProcesso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxProcesso.Location = new System.Drawing.Point(48, 41);
            this.textBoxProcesso.Name = "textBoxProcesso";
            this.textBoxProcesso.Size = new System.Drawing.Size(258, 20);
            this.textBoxProcesso.TabIndex = 0;
            // 
            // labelProcesso
            // 
            this.labelProcesso.AutoSize = true;
            this.labelProcesso.Location = new System.Drawing.Point(45, 25);
            this.labelProcesso.Name = "labelProcesso";
            this.labelProcesso.Size = new System.Drawing.Size(51, 13);
            this.labelProcesso.TabIndex = 1;
            this.labelProcesso.Text = "Processo";
            // 
            // labelNMaximoDeThreads
            // 
            this.labelNMaximoDeThreads.AutoSize = true;
            this.labelNMaximoDeThreads.Location = new System.Drawing.Point(45, 85);
            this.labelNMaximoDeThreads.Name = "labelNMaximoDeThreads";
            this.labelNMaximoDeThreads.Size = new System.Drawing.Size(110, 13);
            this.labelNMaximoDeThreads.TabIndex = 2;
            this.labelNMaximoDeThreads.Text = "Nº máximo de threads";
            // 
            // numericUpDownNMaximoDeThreads
            // 
            this.numericUpDownNMaximoDeThreads.Location = new System.Drawing.Point(48, 101);
            this.numericUpDownNMaximoDeThreads.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownNMaximoDeThreads.Name = "numericUpDownNMaximoDeThreads";
            this.numericUpDownNMaximoDeThreads.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNMaximoDeThreads.TabIndex = 3;
            this.numericUpDownNMaximoDeThreads.Tag = "";
            // 
            // buttonMonitorar
            // 
            this.buttonMonitorar.Location = new System.Drawing.Point(231, 98);
            this.buttonMonitorar.Name = "buttonMonitorar";
            this.buttonMonitorar.Size = new System.Drawing.Size(75, 23);
            this.buttonMonitorar.TabIndex = 4;
            this.buttonMonitorar.Text = "Monitorar";
            this.buttonMonitorar.UseVisualStyleBackColor = true;
            this.buttonMonitorar.Click += new System.EventHandler(this.ButtonMonitorar_Click);
            // 
            // listBoxProcessos
            // 
            this.listBoxProcessos.FormattingEnabled = true;
            this.listBoxProcessos.Location = new System.Drawing.Point(62, 244);
            this.listBoxProcessos.Name = "listBoxProcessos";
            this.listBoxProcessos.Size = new System.Drawing.Size(220, 225);
            this.listBoxProcessos.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelProcessosEmExecucao
            // 
            this.labelProcessosEmExecucao.AutoSize = true;
            this.labelProcessosEmExecucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessosEmExecucao.Location = new System.Drawing.Point(45, 154);
            this.labelProcessosEmExecucao.Name = "labelProcessosEmExecucao";
            this.labelProcessosEmExecucao.Size = new System.Drawing.Size(148, 13);
            this.labelProcessosEmExecucao.TabIndex = 9;
            this.labelProcessosEmExecucao.Text = "Processos em execução:";
            // 
            // labelQtdProcessos
            // 
            this.labelQtdProcessos.AutoSize = true;
            this.labelQtdProcessos.Location = new System.Drawing.Point(199, 154);
            this.labelQtdProcessos.Name = "labelQtdProcessos";
            this.labelQtdProcessos.Size = new System.Drawing.Size(0, 13);
            this.labelQtdProcessos.TabIndex = 10;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // labelProcessosEncerrados
            // 
            this.labelProcessosEncerrados.AutoSize = true;
            this.labelProcessosEncerrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessosEncerrados.Location = new System.Drawing.Point(45, 197);
            this.labelProcessosEncerrados.Name = "labelProcessosEncerrados";
            this.labelProcessosEncerrados.Size = new System.Drawing.Size(137, 13);
            this.labelProcessosEncerrados.TabIndex = 11;
            this.labelProcessosEncerrados.Text = "Processos Encerrados:";
            // 
            // qtdProcessosEncerrados
            // 
            this.qtdProcessosEncerrados.AutoSize = true;
            this.qtdProcessosEncerrados.Location = new System.Drawing.Point(202, 197);
            this.qtdProcessosEncerrados.Name = "qtdProcessosEncerrados";
            this.qtdProcessosEncerrados.Size = new System.Drawing.Size(0, 13);
            this.qtdProcessosEncerrados.TabIndex = 12;
            // 
            // labelListBoxProcessos
            // 
            this.labelListBoxProcessos.AutoSize = true;
            this.labelListBoxProcessos.Location = new System.Drawing.Point(59, 228);
            this.labelListBoxProcessos.Name = "labelListBoxProcessos";
            this.labelListBoxProcessos.Size = new System.Drawing.Size(126, 13);
            this.labelListBoxProcessos.TabIndex = 13;
            this.labelListBoxProcessos.Text = "Processos em execução:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 515);
            this.Controls.Add(this.labelListBoxProcessos);
            this.Controls.Add(this.qtdProcessosEncerrados);
            this.Controls.Add(this.labelProcessosEncerrados);
            this.Controls.Add(this.labelQtdProcessos);
            this.Controls.Add(this.labelProcessosEmExecucao);
            this.Controls.Add(this.listBoxProcessos);
            this.Controls.Add(this.buttonMonitorar);
            this.Controls.Add(this.numericUpDownNMaximoDeThreads);
            this.Controls.Add(this.labelNMaximoDeThreads);
            this.Controls.Add(this.labelProcesso);
            this.Controls.Add(this.textBoxProcesso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de threads";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNMaximoDeThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProcesso;
        private System.Windows.Forms.TextBox textBoxProcesso;
        private System.Windows.Forms.Label labelNMaximoDeThreads;
        private System.Windows.Forms.NumericUpDown numericUpDownNMaximoDeThreads;
        private System.Windows.Forms.Button buttonMonitorar;
        private System.Windows.Forms.ListBox listBoxProcessos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelProcessosEmExecucao;
        internal System.Windows.Forms.Label labelQtdProcessos;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelProcessosEncerrados;
        private System.Windows.Forms.Label qtdProcessosEncerrados;
        private System.Windows.Forms.Label labelListBoxProcessos;
    }
}

