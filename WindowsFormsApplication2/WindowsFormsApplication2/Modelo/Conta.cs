﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManager
{
    public class Conta
    {
        //Declaração de variáveis
        private int id;
        private string nome;
        private string detalhes;
        private double valor;
        private DateTime vencimento;
        private Pessoa responsavel;

        //Construtor e properties feitos, dúvida quanto a lista de pessoas e o quanto ja pagaram.

        public Conta()
        {

        }
        public Conta(int id, string nome, string detalhes, double valor, DateTime vencimento, Pessoa responsavel)
        {
            this.Id = id;
            this.Nome = nome;
            this.Detalhes = detalhes;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.Responsavel = responsavel;
        }

        //Properties
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Detalhes
        {
            get
            {
                return detalhes;
            }

            set
            {
                detalhes = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public DateTime Vencimento
        {
            get
            {
                return vencimento;
            }

            set
            {
                vencimento = value;
            }
        }

        public Pessoa Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                responsavel = value;
            }
        }
    }
}
