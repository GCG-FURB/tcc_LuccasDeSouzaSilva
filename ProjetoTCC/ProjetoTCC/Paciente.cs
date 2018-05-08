﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC
{
    class Paciente
    {
        static private long Count = 0;

        public long ID { get; private set; }
        public string nome { get; private set; }
        public DateTime dataNasc { get; private set; }
        private string caminhoFoto;
        public string cpf { get; private set; }
        public string rg { get; private set; }
        private string descricao;

        public Paciente(string nome, DateTime dataNasc, string caminhoFoto, string cpf, string rg, string descricao)
        {
            Paciente.Count++;
            this.ID = Paciente.Count;
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.caminhoFoto = caminhoFoto;
            this.cpf = cpf;
            this.rg = rg;
            this.descricao = descricao;
        }
        
    }
}
