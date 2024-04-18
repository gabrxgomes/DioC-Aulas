// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using ExemploExplorando.Models;



// pessoa1.Nome = "José";
// pessoa1.Sobrenome = "Carvalho";
// pessoa1.Idade = 50;
// pessoa1.Apresentar();

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Lucas";
pessoa1.Sobrenome = "Silva";


Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Carlos";
pessoa2.Sobrenome = "Fernandes";



Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome =  "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();


cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();