﻿using HouseManager.CV;

namespace HouseManager
{
    partial class FormRelatorioCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioCompra));
            this.crvRelatorioCompra = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioCompra1 = new HouseManager.CV.RelatorioCompra();
            this.SuspendLayout();
            // 
            // crvRelatorioCompra
            // 
            this.crvRelatorioCompra.ActiveViewIndex = 0;
            this.crvRelatorioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorioCompra.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorioCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorioCompra.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorioCompra.Name = "crvRelatorioCompra";
            this.crvRelatorioCompra.ReportSource = this.RelatorioCompra1;
            this.crvRelatorioCompra.ShowCloseButton = false;
            this.crvRelatorioCompra.ShowGroupTreeButton = false;
            this.crvRelatorioCompra.ShowLogo = false;
            this.crvRelatorioCompra.ShowParameterPanelButton = false;
            this.crvRelatorioCompra.ShowRefreshButton = false;
            this.crvRelatorioCompra.Size = new System.Drawing.Size(866, 493);
            this.crvRelatorioCompra.TabIndex = 0;
            this.crvRelatorioCompra.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormRelatorioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 493);
            this.Controls.Add(this.crvRelatorioCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioCompra";
            this.Text = "Relatório";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorioCompra;
        private RelatorioCompra RelatorioCompra1;
    }
}