using System;
using System.Collections.Generic;

namespace BancoGraphql.Entities
{
    public class Banco
    {
        public Banco(int iD, List<Agencia> agencias, List<Gerente> gerentes, List<Produto> produtos)
        {
            ID = iD;
            Agencias = agencias;
            Gerentes = gerentes;
            Produtos = produtos;
        }
        public int ID { get; set; }

        public List<Agencia> Agencias { get; set; }
        public List<Gerente> Gerentes { get; set; }
        public List<Produto> Produtos { get; set; }
    }

    public class Agencia
    {
        public Agencia(int iD, int numero, int endereco)
        {
            ID = iD;
            Numero = numero;
            Endereco = endereco;
        }

        public int ID { get; set; }
        public int Numero { get; set; }
        public int Endereco { get; set; }
    }

    public class Endereco
    {
        public Endereco(int iD, string rua, int numero, string cidade, string estado, string cep)
        {
            ID = iD;
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public int ID { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Cep { get; set; }
    }

    public class Gerente
    {
        public Gerente(int iD, string nome, string cpf, int agencia)
        {
            ID = iD;
            Nome = nome;
            Cpf = cpf;
            Agencia = agencia;
        }

        public int ID { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public int Agencia { get; set; }
    }

    public class Produto
    {
        public Produto(int iD, string nome, double valor)
        {
            ID = iD;
            Nome = nome;
            Valor = valor;
        }

        public int ID { get; set; }
        public String Nome { get; set; }
        public double Valor { get; set; }
    }
}