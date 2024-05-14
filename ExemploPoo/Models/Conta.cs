using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public abstract class Conta// não pode ser instanciada por ser uma classe abstrata
    {   
        protected decimal saldo; //o protected é tipo um private mais pernmissivo, nada externo pode alterar o saldo
        //mas as suas classes filhas vindo dessa classe podem alterar meu "saldo"
        public abstract void Creditar (decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
        
    }
}