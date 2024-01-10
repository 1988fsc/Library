using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Pessoa
    {
        public Pessoa()
        { }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome : {NomeCompleto}, Idade: {Idade}");
        }

    }
}



// Manipula as classes Curso e Pessoa (Migra Pessoa para aluno adiciona aos Cursos e lista os campos)

/*Pessoa p1 = new Pessoa(nome: "Felipe", sobrenome: "Campos");

Pessoa p2 = new Pessoa();
p2.Nome = "Felipe";
p2.Sobrenome = "Souza";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
Console.WriteLine($"{cursoDeIngles.AlunosMatriculados()}");*/