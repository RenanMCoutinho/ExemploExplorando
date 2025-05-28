using ExemploExplorando.Models;
using System.Reflection.PortableExecutable;


//pessoa pessoa1 = new pessoa();
//pessoa1.nome = "renan ";
//pessoa1.sobrenome = "marcilio";
//pessoa1.idade = 30;
//pessoa1.apresentar();

Pessoa p1 = new Pessoa("Renan", "Marcilio");
Pessoa p2 = new Pessoa("João", "Silva");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês Básico";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AddAluno(p1);
cursoIngles.AddAluno(p2);
cursoIngles.ListarAlunos();
