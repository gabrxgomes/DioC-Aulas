using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Pessoa
    {   
        public Pessoa()
        {
            
        }

        //quero que o meu atributo nome seja algo obrigatorio
        //então vamos criar um construtor
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu email é {Email} e tenho {Idade} anos.");
        }
    }
}