using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int AlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {

            Console.WriteLine($"Alunos do curso de: {Nome}");
            Console.WriteLine($"Total de matrículas: {AlunosMatriculados()}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"{count + 1}  - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);

            }


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