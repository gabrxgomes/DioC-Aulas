using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor()//caso queria instanciar professor
        //eu posso passar um nome ou nao passar nada
        {

        }

        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }
        

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e meu salario é {Salario}");
        }
    }


}