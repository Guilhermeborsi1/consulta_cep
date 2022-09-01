using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPessoas.ObjDados
{
    /// <summary>
    /// Construtor da Classe de Pesspas
    /// </summary>
    public class Pessoa
    {
        public Pessoa() { }
        /// <summary>
        /// Paramentros de Nome
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Paramentros de Sobre Nome
        /// </summary>
        public string SobreNome { get; set; }
        /// <summary>
        /// Sexo a Pessoa
        /// </summary>
        public string Sexo { get; set; }
        /// <summary>
        /// Data de Nascimento da Pessoa
        /// </summary>
        public DateTime DataNascimento { get; set; }
        /// <summary>
        /// Data de Criação da Pessoa
        /// </summary>
        public DateTime DataCriacao { get; set; }

        /// <summary>
        ///  Criação de Metodos de Pessoa
        /// </summary>
        /// <param name="nome"> Informe o Nome da Pessoa</param>
        /// <param name="sobrenome"> Informe o Sobre Nome da Pessoa</param>
        /// <param name="sexo">Informe o Sexo da Pessoa</param>
        /// <param name="datanascimento">Data de Nascimento da Pessoa</param>
        public Pessoa(
            string nome,
            string sobrenome,
            string sexo,
            DateTime datanascimento)
        {
            this.Nome = nome;
            this.SobreNome = sobrenome;
            this.Sexo = sexo;
            this.DataNascimento = datanascimento;
            this.DataCriacao = DateTime.Now;
        }


    }
}