using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;

            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);// mais semântico
            //return true;
        }

        public void ListarAlunos()
        {

            for (int count =  0; count < Alunos.Count; count++)
            {
                //passagem de parametros simples
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;

                //fazendo a interpolação
                string texto =  $"Nº {count + 1} - {Alunos[count].NomeCompleto}";//toda interpolação começa com o dolars
                //start in number 1 in this expression for not starts in number 0 if number 0 not existis in this context
                Console.WriteLine(texto);
            }


            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }

            
        }
    }
}