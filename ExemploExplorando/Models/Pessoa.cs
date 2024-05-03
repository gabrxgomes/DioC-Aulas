using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {   
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome; //a ordem tem que ser 1 - var global da classe predominante no caso o parametro "Nome", 2 - depois a variavel local
            Sobrenome = sobrenome;
        }
        //vamos declarar os get e set da classe
        //prop gera automatico
        //public int MyProperty { get; set; }
        //mude para desable a ultima propriedade no .csproj para tirar o erro de nulo
        // public string Nome {get; set;}

        private string _nome; //faz referencia ao meu Nome
        // como uma variavel que armazena o valor do nome para modifica-lo e usa-lo

        private int _idade;
        public string Nome
        {
            // get //recebe valor
            // {
            //     return _nome.ToUpper();
            // }

            get => _nome.ToUpper(); //podemos resumir para se usar assim, uma body expression
            //maneira mais sucinta e performatica de se fazer o mesmo de cima
            //TRATAMENTO DOS DADOS

            set //atribui valor
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                    //tratamento de excessão
                }

                _nome = value;
            }
        }
        public string Sobrenome { get; set; } //propriedade

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        //propriedade
            



        public int Idade
        {
            get => _idade; //não tem a necessidade de se tratar os dados igual acontece com string

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }


        public void Apresentar(){
            Console.WriteLine($"Olá meu nome é, {NomeCompleto}, e a minha idade é {Idade}");
        }
        
    }
}