using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa //this is polimorfismo ! estou herdando os atributos
    //da classe Pessoa na minha classe aluno (: classe_que_vc_quer_herdar)
    {   
        public Aluno() //caso e queria instanciar aluno eu posso nao
        //passar nada o passar um nome.
        {

        }
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}