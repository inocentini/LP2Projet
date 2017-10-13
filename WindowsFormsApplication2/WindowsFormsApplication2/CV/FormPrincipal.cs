﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormPrincipal : Form
    {
        FormListaPessoas flp = new FormListaPessoas();
        FormListaProdutos flpr = new FormListaProdutos();
        FormListaContas flc = new FormListaContas();

        public FormPrincipal()
        {
            InitializeComponent();
            flp.MdiParent = this;
            flpr.MdiParent = this;
            flc.MdiParent = this;
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flp.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpr.Show();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flc.Show();
        }
    }
}
