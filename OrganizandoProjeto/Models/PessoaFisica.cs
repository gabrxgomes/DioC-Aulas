using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizandoProjeto.Models
{
    public class PessoaFisica
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public int valor1 { get; set; }
        public int valor2 { get; set; }

        

        public string NomeRepLegal { get; set; }//treinando sobre abreviações em variaveis




        public void Apresentar(){

            Console.WriteLine($"Olá, meu nome é {Nome} \ne tenho {Idade} anos.");
        }

        public int CalcularCalculo(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            Console.WriteLine("" + resultado);
            return resultado;
        }
    }
}