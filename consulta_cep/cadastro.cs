using System;
using System.Collections.Generic;
using ListaPessoas.ObjDados;

namespace ListaPessoas
{
    class Cadastro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Pessoas");

            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa Aluno_Pessoa = new Pessoa();
            Aluno_Pessoa.DataCriacao = DateTime.Now;
            Aluno_Pessoa.DataNascimento = DateTime.Parse("09/10/1956");
            Aluno_Pessoa.Nome = "Joao da Silva";
            Aluno_Pessoa.SobreNome = "Gomes";
            Aluno_Pessoa.Sexo = "M";



            Pessoa Aluno_Pessoa2 = new Pessoa();
            Aluno_Pessoa2.DataCriacao = DateTime.Now;
            Aluno_Pessoa2.DataNascimento = DateTime.Parse("09/10/2000");
            Aluno_Pessoa2.Nome = "fulano";
            Aluno_Pessoa2.SobreNome = "Da Silva";
            Aluno_Pessoa2.Sexo = "F";

            pessoas.Add(Aluno_Pessoa2);

            pessoas.Add(new
                Pessoa("Beltrano",
                        "Silverio",
                        "M",
                        DateTime.Parse("09/10/2000")));

            pessoas.Add(new
                Pessoa("Teutrano",
                        "De Souza",
                        "M",
                        DateTime.Parse("09/10/2003")));

            pessoas.Add(new
            Pessoa("Deutrano",
            "Arantes",
            "M",
            DateTime.Parse("09/10/2000")));


        }
    }
}