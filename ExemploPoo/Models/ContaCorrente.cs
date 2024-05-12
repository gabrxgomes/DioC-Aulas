using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saldo realizado com sucesso");
            }
            else
            {
                //throw new Exception("O valor sacado é maior que o saldo disponivel");
                Console.WriteLine("O valor sacado é maior que o saldo disponivel");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é: " + saldo);
        }
    }
}