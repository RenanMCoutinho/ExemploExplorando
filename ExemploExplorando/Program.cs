// See https://aka.ms/new-console-template for more information


using ExemploExplorando.Models;
using System.Reflection.PortableExecutable;


//pessoa pessoa1 = new pessoa();
//pessoa1.nome = "renan ";
//pessoa1.sobrenome = "marcilio";
//pessoa1.idade = 30;
//pessoa1.apresentar();

Pessoa p1 = new Pessoa();
p1.Nome = "Renan";
p1.sobrenome = "Marcilio";

Pessoa p2 = new Pessoa();
p2.Nome = "João";
p2.sobrenome = "Silva";

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês Básico";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AddAluno(p1);
cursoIngles.AddAluno(p2);
cursoIngles.ListarAlunos();
