﻿namespace HouseManager
{
    partial class FormListaPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPagamentos));
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.cbbSituacao = new System.Windows.Forms.ComboBox();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.labFiltrarSituacao = new System.Windows.Forms.Label();
            this.labFiltrarPagamento = new System.Windows.Forms.Label();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnSituacao = new System.Windows.Forms.Button();
            this.colPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            this.dgvPagamentos.AllowUserToResizeRows = false;
            this.dgvPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPessoa,
            this.colConta,
            this.colApagar,
            this.colVencimento,
            this.colSituacao});
            this.dgvPagamentos.Location = new System.Drawing.Point(0, 24);
            this.dgvPagamentos.MultiSelect = false;
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.ReadOnly = true;
            this.dgvPagamentos.RowHeadersVisible = false;
            this.dgvPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamentos.Size = new System.Drawing.Size(793, 350);
            this.dgvPagamentos.TabIndex = 3;
            // 
            // cbbSituacao
            // 
            this.cbbSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSituacao.FormattingEnabled = true;
            this.cbbSituacao.Items.AddRange(new object[] {
            "Mostrar tudo",
            "Pagos",
            "Não pagos"});
            this.cbbSituacao.Location = new System.Drawing.Point(672, 39);
            this.cbbSituacao.Name = "cbbSituacao";
            this.cbbSituacao.Size = new System.Drawing.Size(109, 21);
            this.cbbSituacao.TabIndex = 2;
            this.cbbSituacao.SelectedIndexChanged += new System.EventHandler(this.cbbSituacao_SelectedIndexChanged);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(138, 6);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(643, 20);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // labFiltrarSituacao
            // 
            this.labFiltrarSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrarSituacao.AutoSize = true;
            this.labFiltrarSituacao.Location = new System.Drawing.Point(572, 42);
            this.labFiltrarSituacao.Name = "labFiltrarSituacao";
            this.labFiltrarSituacao.Size = new System.Drawing.Size(96, 13);
            this.labFiltrarSituacao.TabIndex = 13;
            this.labFiltrarSituacao.Text = "Filtrar por situação:";
            // 
            // labFiltrarPagamento
            // 
            this.labFiltrarPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrarPagamento.AutoSize = true;
            this.labFiltrarPagamento.Location = new System.Drawing.Point(5, 9);
            this.labFiltrarPagamento.Name = "labFiltrarPagamento";
            this.labFiltrarPagamento.Size = new System.Drawing.Size(127, 13);
            this.labFiltrarPagamento.TabIndex = 13;
            this.labFiltrarPagamento.Text = "Filtrar por nome da conta:";
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.cbbSituacao);
            this.pnlFiltro.Controls.Add(this.txtFiltrar);
            this.pnlFiltro.Controls.Add(this.labFiltrarPagamento);
            this.pnlFiltro.Controls.Add(this.labFiltrarSituacao);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(793, 79);
            this.pnlFiltro.TabIndex = 15;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnSituacao);
            this.pnlInfo.Controls.Add(this.dgvPagamentos);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 79);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(793, 459);
            this.pnlInfo.TabIndex = 16;
            // 
            // btnSituacao
            // 
            this.btnSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSituacao.Location = new System.Drawing.Point(605, 390);
            this.btnSituacao.Name = "btnSituacao";
            this.btnSituacao.Size = new System.Drawing.Size(176, 57);
            this.btnSituacao.TabIndex = 4;
            this.btnSituacao.Text = "Marcar como pago/não pago";
            this.btnSituacao.UseVisualStyleBackColor = true;
            this.btnSituacao.Click += new System.EventHandler(this.btnSituacao_Click);
            // 
            // colPessoa
            // 
            this.colPessoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPessoa.HeaderText = "Pessoa";
            this.colPessoa.Name = "colPessoa";
            this.colPessoa.ReadOnly = true;
            // 
            // colConta
            // 
            this.colConta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colConta.HeaderText = "Nome da conta";
            this.colConta.Name = "colConta";
            this.colConta.ReadOnly = true;
            // 
            // colApagar
            // 
            this.colApagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApagar.FillWeight = 80F;
            this.colApagar.HeaderText = "Valor a pagar";
            this.colApagar.Name = "colApagar";
            this.colApagar.ReadOnly = true;
            // 
            // colVencimento
            // 
            this.colVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVencimento.FillWeight = 60F;
            this.colVencimento.HeaderText = "Vencimento";
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSituacao.FillWeight = 40F;
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // FormListaPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 538);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 521);
            this.Name = "FormListaPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListaPagamentos_FormClosing);
            this.Load += new System.EventHandler(this.FormListaPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label labFiltrarPagamento;
        private System.Windows.Forms.ComboBox cbbSituacao;
        private System.Windows.Forms.Label labFiltrarSituacao;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
    }
}