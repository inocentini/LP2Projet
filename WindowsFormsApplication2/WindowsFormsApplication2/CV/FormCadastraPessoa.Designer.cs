﻿namespace WindowsFormsApplication2
{
    partial class wCadastro
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
            this.labNome = new System.Windows.Forms.Label();
            this.labCPF = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labTelefone = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNome
            // 
            this.labNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(20, 34);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(38, 13);
            this.labNome.TabIndex = 0;
            this.labNome.Text = "Nome:";
            // 
            // labCPF
            // 
            this.labCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labCPF.AutoSize = true;
            this.labCPF.Location = new System.Drawing.Point(25, 10);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(30, 13);
            this.labCPF.TabIndex = 1;
            this.labCPF.Text = "CPF:";
            // 
            // labEmail
            // 
            this.labEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(20, 68);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(35, 13);
            this.labEmail.TabIndex = 2;
            this.labEmail.Text = "Email:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(77, 142);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(198, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labTelefone
            // 
            this.labTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(17, 96);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(52, 13);
            this.labTelefone.TabIndex = 8;
            this.labTelefone.Text = "Telefone:";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.Location = new System.Drawing.Point(77, 3);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(77, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(77, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Location = new System.Drawing.Point(77, 96);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.labCPF);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.labNome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.labEmail);
            this.panel1.Controls.Add(this.labTelefone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 213);
            this.panel1.TabIndex = 13;
            // 
            // wCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 213);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(416, 252);
            this.MinimizeBox = false;
            this.Name = "wCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.wCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Panel panel1;
    }
}
