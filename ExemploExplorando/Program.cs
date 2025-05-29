using ExemploExplorando.Models;
using System.Reflection.PortableExecutable;
using System.Globalization;


Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
fila.Dequeue();
Console.WriteLine("Após o Remover o 1º:");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);

}

//ExemploExcecao exemploExcecao = new ExemploExcecao();

//exemploExcecao.Metodo1();


//try
//{
//    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }
//}

//catch (FileNotFoundException ex)
//{
//    Console.WriteLine($"Arquivo ñ encontrado! {ex.Message}");
//}
//catch (DirectoryNotFoundException ex)
//{
//    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//}

//catch (Exception ex)
//{
//    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//}

//finally
//{
//    Console.WriteLine("Chegou no finally, independente de erro ou não, sempre será executado!");
//}

























//pessoa pessoa1 = new pessoa();
//pessoa1.nome = "renan ";
//pessoa1.sobrenome = "marcilio";
//pessoa1.idade = 30;
//pessoa1.apresentar();

//Pessoa p1 = new Pessoa(nome: "Renan", sobrenome: "Marcilio");
//Pessoa p2 = new Pessoa("João", "Silva");

//Curso cursoIngles = new Curso();
//cursoIngles.Nome = "Inglês Básico";
//cursoIngles.Alunos = new List<Pessoa>();

//cursoIngles.AddAluno(p1);
//cursoIngles.AddAluno(p2);
//cursoIngles.ListarAlunos();


//double porc = .20;
//decimal valorMonetario = 82.40m;

//Console.WriteLine(porc.ToString("P"));

//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

//string dataString = "2025-13-28 21:55";

//bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
//if (sucesso)
//{
//    Console.WriteLine($"Sucesso {date}");
//}
//else
//{

//    Console.WriteLine($"Error {dataString}");
//}

