using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Diretor : Professor //não funciona
    {
        public override void Apresentar() // não funciona
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e meu salario é {Salario}");
        }   
    }
}