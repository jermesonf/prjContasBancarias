namespace Interface
{
    partial class frmContasBancarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasBancarias));
            this.lblAgencia = new MetroFramework.Controls.MetroLabel();
            this.lblConta = new MetroFramework.Controls.MetroLabel();
            this.lblValor = new MetroFramework.Controls.MetroLabel();
            this.txtAgencia = new MetroFramework.Controls.MetroTextBox();
            this.txtConta = new MetroFramework.Controls.MetroTextBox();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.tabContas = new System.Windows.Forms.TabControl();
            this.tabCorrente = new System.Windows.Forms.TabPage();
            this.dgvCorrente = new System.Windows.Forms.DataGridView();
            this.colAgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPoupanca = new System.Windows.Forms.TabPage();
            this.dgvPoupanca = new System.Windows.Forms.DataGridView();
            this.colAgenciaPoupanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContaPoupanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPoupanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPoupanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.prgTempo = new MetroFramework.Controls.MetroProgressBar();
            this.tmrBemvindo = new System.Windows.Forms.Timer(this.components);
            this.tabContas.SuspendLayout();
            this.tabCorrente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrente)).BeginInit();
            this.tabPoupanca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoupanca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(40, 81);
            this.lblAgencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(56, 19);
            this.lblAgencia.TabIndex = 0;
            this.lblAgencia.Text = "Agência";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(40, 171);
            this.lblConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(47, 19);
            this.lblConta.TabIndex = 1;
            this.lblConta.Text = "Conta:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(442, 81);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(61, 19);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor: R$";
            // 
            // txtAgencia
            // 
            // 
            // 
            // 
            this.txtAgencia.CustomButton.Image = null;
            this.txtAgencia.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.txtAgencia.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgencia.CustomButton.Name = "";
            this.txtAgencia.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtAgencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAgencia.CustomButton.TabIndex = 1;
            this.txtAgencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAgencia.CustomButton.UseSelectable = true;
            this.txtAgencia.CustomButton.Visible = false;
            this.txtAgencia.Lines = new string[0];
            this.txtAgencia.Location = new System.Drawing.Point(40, 113);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgencia.MaxLength = 32767;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.PasswordChar = '\0';
            this.txtAgencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgencia.SelectedText = "";
            this.txtAgencia.SelectionLength = 0;
            this.txtAgencia.SelectionStart = 0;
            this.txtAgencia.ShortcutsEnabled = true;
            this.txtAgencia.Size = new System.Drawing.Size(210, 34);
            this.txtAgencia.TabIndex = 3;
            this.txtAgencia.UseSelectable = true;
            this.txtAgencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAgencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConta
            // 
            // 
            // 
            // 
            this.txtConta.CustomButton.Image = null;
            this.txtConta.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.txtConta.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConta.CustomButton.Name = "";
            this.txtConta.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtConta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConta.CustomButton.TabIndex = 1;
            this.txtConta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConta.CustomButton.UseSelectable = true;
            this.txtConta.CustomButton.Visible = false;
            this.txtConta.Lines = new string[0];
            this.txtConta.Location = new System.Drawing.Point(40, 203);
            this.txtConta.Margin = new System.Windows.Forms.Padding(4);
            this.txtConta.MaxLength = 32767;
            this.txtConta.Name = "txtConta";
            this.txtConta.PasswordChar = '\0';
            this.txtConta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConta.SelectedText = "";
            this.txtConta.SelectionLength = 0;
            this.txtConta.SelectionStart = 0;
            this.txtConta.ShortcutsEnabled = true;
            this.txtConta.Size = new System.Drawing.Size(210, 34);
            this.txtConta.TabIndex = 4;
            this.txtConta.UseSelectable = true;
            this.txtConta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txtValor.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(442, 113);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(246, 34);
            this.txtValor.TabIndex = 5;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabContas
            // 
            this.tabContas.Controls.Add(this.tabCorrente);
            this.tabContas.Controls.Add(this.tabPoupanca);
            this.tabContas.Location = new System.Drawing.Point(34, 310);
            this.tabContas.Margin = new System.Windows.Forms.Padding(4);
            this.tabContas.Name = "tabContas";
            this.tabContas.SelectedIndex = 0;
            this.tabContas.Size = new System.Drawing.Size(660, 322);
            this.tabContas.TabIndex = 6;
            // 
            // tabCorrente
            // 
            this.tabCorrente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabCorrente.Controls.Add(this.dgvCorrente);
            this.tabCorrente.Location = new System.Drawing.Point(4, 28);
            this.tabCorrente.Margin = new System.Windows.Forms.Padding(4);
            this.tabCorrente.Name = "tabCorrente";
            this.tabCorrente.Padding = new System.Windows.Forms.Padding(4);
            this.tabCorrente.Size = new System.Drawing.Size(652, 290);
            this.tabCorrente.TabIndex = 0;
            this.tabCorrente.Text = "Conta Corrente";
            // 
            // dgvCorrente
            // 
            this.dgvCorrente.AllowUserToAddRows = false;
            this.dgvCorrente.AllowUserToDeleteRows = false;
            this.dgvCorrente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorrente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAgencia,
            this.colConta,
            this.colValor,
            this.colTipo});
            this.dgvCorrente.Location = new System.Drawing.Point(9, 9);
            this.dgvCorrente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCorrente.Name = "dgvCorrente";
            this.dgvCorrente.ReadOnly = true;
            this.dgvCorrente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCorrente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvCorrente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCorrente.Size = new System.Drawing.Size(630, 266);
            this.dgvCorrente.TabIndex = 1;
            // 
            // colAgencia
            // 
            this.colAgencia.HeaderText = "Agência";
            this.colAgencia.Name = "colAgencia";
            this.colAgencia.ReadOnly = true;
            // 
            // colConta
            // 
            this.colConta.HeaderText = "Conta";
            this.colConta.Name = "colConta";
            this.colConta.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor R$";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo de Conta";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // tabPoupanca
            // 
            this.tabPoupanca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPoupanca.Controls.Add(this.dgvPoupanca);
            this.tabPoupanca.Location = new System.Drawing.Point(4, 28);
            this.tabPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.tabPoupanca.Name = "tabPoupanca";
            this.tabPoupanca.Padding = new System.Windows.Forms.Padding(4);
            this.tabPoupanca.Size = new System.Drawing.Size(652, 290);
            this.tabPoupanca.TabIndex = 1;
            this.tabPoupanca.Text = "Conta Poupança";
            // 
            // dgvPoupanca
            // 
            this.dgvPoupanca.AllowUserToAddRows = false;
            this.dgvPoupanca.AllowUserToDeleteRows = false;
            this.dgvPoupanca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoupanca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoupanca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAgenciaPoupanca,
            this.colContaPoupanca,
            this.colValorPoupanca,
            this.colTipoPoupanca});
            this.dgvPoupanca.Location = new System.Drawing.Point(9, 9);
            this.dgvPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPoupanca.Name = "dgvPoupanca";
            this.dgvPoupanca.ReadOnly = true;
            this.dgvPoupanca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvPoupanca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPoupanca.Size = new System.Drawing.Size(630, 266);
            this.dgvPoupanca.TabIndex = 2;
            // 
            // colAgenciaPoupanca
            // 
            this.colAgenciaPoupanca.HeaderText = "Agência";
            this.colAgenciaPoupanca.Name = "colAgenciaPoupanca";
            this.colAgenciaPoupanca.ReadOnly = true;
            // 
            // colContaPoupanca
            // 
            this.colContaPoupanca.HeaderText = "Conta";
            this.colContaPoupanca.Name = "colContaPoupanca";
            this.colContaPoupanca.ReadOnly = true;
            // 
            // colValorPoupanca
            // 
            this.colValorPoupanca.HeaderText = "Valor R$";
            this.colValorPoupanca.Name = "colValorPoupanca";
            this.colValorPoupanca.ReadOnly = true;
            // 
            // colTipoPoupanca
            // 
            this.colTipoPoupanca.HeaderText = "Tipo de Conta";
            this.colTipoPoupanca.Name = "colTipoPoupanca";
            this.colTipoPoupanca.ReadOnly = true;
            // 
            // cboTipo
            // 
            this.cboTipo.AccessibleName = "";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 23;
            this.cboTipo.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança"});
            this.cboTipo.Location = new System.Drawing.Point(442, 203);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(244, 29);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cboTipo.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(442, 171);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Tipo de Conta:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(549, 249);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(137, 41);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(85, 236);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(577, 112);
            this.lblBemVindo.TabIndex = 10;
            this.lblBemVindo.Text = "Bem-Vindo!";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBemVindo.Visible = false;
            // 
            // prgTempo
            // 
            this.prgTempo.Location = new System.Drawing.Point(594, 32);
            this.prgTempo.Name = "prgTempo";
            this.prgTempo.Size = new System.Drawing.Size(100, 23);
            this.prgTempo.TabIndex = 11;
            this.prgTempo.Visible = false;
            this.prgTempo.Click += new System.EventHandler(this.prgTempo_Click);
            // 
            // tmrBemvindo
            // 
            this.tmrBemvindo.Enabled = true;
            this.tmrBemvindo.Tick += new System.EventHandler(this.tmrBemvindo_Tick);
            // 
            // frmContasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 665);
            this.Controls.Add(this.prgTempo);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.tabContas);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblAgencia);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContasBancarias";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Text = "Contas Bancárias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContasBancarias_FormClosing);
            this.Load += new System.EventHandler(this.frmContasBancarias_Load);
            this.tabContas.ResumeLayout(false);
            this.tabCorrente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrente)).EndInit();
            this.tabPoupanca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoupanca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAgencia;
        private MetroFramework.Controls.MetroLabel lblConta;
        private MetroFramework.Controls.MetroLabel lblValor;
        private MetroFramework.Controls.MetroTextBox txtAgencia;
        private MetroFramework.Controls.MetroTextBox txtConta;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private System.Windows.Forms.TabControl tabContas;
        private System.Windows.Forms.TabPage tabCorrente;
        private System.Windows.Forms.TabPage tabPoupanca;
        private MetroFramework.Controls.MetroComboBox cboTipo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvCorrente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridView dgvPoupanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgenciaPoupanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContaPoupanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPoupanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPoupanca;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private System.Windows.Forms.Label lblBemVindo;
        private MetroFramework.Controls.MetroProgressBar prgTempo;
        private System.Windows.Forms.Timer tmrBemvindo;
    }
}

