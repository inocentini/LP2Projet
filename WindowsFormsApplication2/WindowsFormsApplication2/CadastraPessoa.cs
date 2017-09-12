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
    public partial class wCadastro : Form
    {
        private bool editar = new bool();

        public bool Editar
        {
            get
            {
                return editar;
            }

            set
            {
                editar = value;
            }
        }

        public wCadastro(string cpf)
        {
            Editar = true;
            InitializeComponent();
            IDatabase db = new DatabaseDict();
            Pessoa p = db.Read(cpf);
            setDTO(p);
        }

        public wCadastro()
        {
            InitializeComponent();
        }

        private Pessoa getDTO()
        {
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Cpf = txtCPF.Text;
            p.Email = txtEmail.Text;
            p.Telefone = txtTelefone.Text;

            return p;
        }

        private void setDTO(Pessoa p)
        {
            txtNome.Text = p.Nome;
            txtCPF.Text = p.Cpf;
            txtEmail.Text = p.Email;
            txtTelefone.Text = p.Telefone;
        }

        private void getPessoa()
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IDatabase database = new DatabaseDict();
            database.Salvar(getDTO());
            Dispose();
        }

        private void wCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}