﻿using ExemploPoo.Models;



ContaCorrente c1 = new ContaCorrente(123, 1000);

//c1.saldo = 5; //impossivel acessar pois o .saldo é privado na minha 
//classe conta corrente


c1.ExibirSaldo(); //chamandoo metodo que faz o print do saldo
c1.Sacar(5000);
c1.ExibirSaldo();













//inicio poo abstração
// Pessoa p1 = new Pessoa();

// p1.Nome = "John";
// p1.Idade = 20;

// p1.Apresentar();
